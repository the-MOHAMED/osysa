using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    public partial class frmArchif : Form
    {
       
        SqlConnection cn = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");

        string imglocation;
        bool startok = false;

        ClsData CLSDATA = new ClsData();

        public frmArchif()
        {
            InitializeComponent();
        }

        private void frmArchif_Load(object sender, EventArgs e)
        {
            try
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                CLSDATA.FillCmb("Add_Client", CmbClientName);
                CLSDATA.FillCmb("Archif_Catagory", CmbArchif);
                ViewData("0");
                Add_DG_Btn(Dg, "استعراض", "View");
                Add_DG_Btn(Dg, "حذف", "Delete");

            }
            catch (Exception)
            {
                
               
            }
            finally
            {
                startok = true;
            }
            
                   




            }  

        void dd(ComboBox cmb)
        {
        }
        private void ComFile_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// تحميل بيانات الداتا جريد
        /// </summary>
        private void Add_DG_Btn(DataGridView Datagride,string txt,string Col_Name)
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = txt;
            col.Name = Col_Name ;
          if (Col_Name == "Delete") { col.DefaultCellStyle.ForeColor = System.Drawing.Color.Red; }
            col.Width = 60;
            Datagride.Columns.Add(col);
        }
        void ViewData(string CustId)
        {
            try
            {
                string sql = @"Select TB.ID,TB.CustID,cd.Name,ar.Name,TB.CataID,TB.Date,TB.Date_2,TB.Description,TB.UserID,TB.File_Path,TB.Notes from dbo.Archif_Data TB  inner join dbo.Add_Client cd on TB.CustID = cd.Id 
                               inner join dbo.Archif_Catagory ar on TB.CataID = ar.ID
                               Where tb.CustID = case  '" + CustId + "' when '' then tb.CustID else '" + CustId + "' end and tb.UserId = "+ Tb_Users.UserID.ToString() + "";
                            
                CLSDATA.FillDataGrid(Dg, sql);
                try
                {
               
                
                Dg.Columns["ID"].HeaderText = "كود العميل";
                Dg.Columns["Name"].HeaderText = "اسم العميل";
                Dg.Columns["Name1"].HeaderText = "نوع المستند";
                Dg.Columns["CustID"].Visible = false;
                Dg.Columns["CataID"].Visible = false;
                Dg.Columns["Description"].HeaderText = "وصف الملف";
                Dg.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Dg.Columns["Date"].HeaderText = "تاريخ المستند ";
                Dg.Columns["Date_2"].HeaderText = " انتهاء الصلاحية ";
                Dg.Columns["UserID"].Visible = false;
                Dg.Columns["File_Path"].HeaderText = "مسار الملف";
                Dg.Columns["Notes"].HeaderText = "ملاحظات";
                 
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
      

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show(e.RowIndex.ToString());
            }
            if (Dg.Columns[e.ColumnIndex].HeaderText == "View")
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = Dg.Rows[index];
                CmbClientName.Text = selectedRow.Cells[0].ToString();
                Check_Connection_is_Open();
                string str = "Select Arch_Doc from dbo.Archif_Data where ID =" + Dg.Rows[e.RowIndex].Cells["ID"].Value.ToString() + "";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(str, cn);
                sda.Fill(ds);
                string FileName = Dg.Rows[e.RowIndex].Cells["File_Path"].ToString();
                byte[] File_Data = (byte[])ds.Tables[0].Rows[0]["Arch_Doc"];
                FileStream Fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                Fs.Write(File_Data, 0, File_Data.Length);
                Fs.Close();
                System.Diagnostics.Process.Start(FileName);
              
            }
            if (Dg.Columns[e.ColumnIndex].HeaderText == "Delete")

            {
                if (Tb_Users.Pr_Delete == "False")
                {
                    MessageBox.Show("هذا المستخدم لا يملك صلاحية الحذف", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("هل تريد الحذف", " 0AF", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (String.IsNullOrEmpty(txtID.Text.ToString()))
                    {
                        MessageBox.Show("من فضلك حدد الصف المراد حذفه");
                    }
                //    SqlConnection cn = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
                  SqlConnection cn = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "Delete from Archif_Data where ID =" + txtID.Text + "";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    ViewData(CmbClientName.SelectedValue.ToString());
                    MessageBox.Show("تم حذف البيانات بنجاح", " 0AF", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                }
            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(CmbClientName.Text))
            {
                MessageBox.Show("برجاء ادخال البيانات","OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Check_Connection_is_Open();
                SqlCommand com = new SqlCommand(@"insert into Archif_Data (CustID,CataID,Description,File_Path,Arch_Doc,Date,Date_2,Notes,UserID)
                values(" + CmbClientName.SelectedValue.ToString() + "," + CmbArchif.SelectedValue.ToString() + "" +
                ",N'" + TxtDes.Text + "','" + txtFilePath.Text.Trim()  +"',@Arch_Doc,'"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'" + 
                ",'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',N'"+ Txt_Notes.Text+ "'," + Tb_Users.UserID.ToString()  + ")", cn);
                byte[] images = null;
                FileStream stream = new FileStream(txtFilePath.Text.Trim(), FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
             ///   com.Parameters.Add(new SqlParameter("@images", images));
                com.Parameters.Add(new SqlParameter("@Arch_Doc", SqlDbType.VarBinary)).Value = images;
               com.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ViewData(CmbClientName.SelectedValue.ToString());
                Clear();
                cn.Close();
              
                // CLSDATA.insertImg(imglocation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            
           }
        }
        void Clear()
        {
            txtID.Clear();
          //  CmbClientName.Text = string.Empty;
            CmbArchif.Text = string.Empty;
            TxtDes.Clear();
            TxtFileName.Clear();
            txtFilePath.Clear();
            Txt_Notes.Clear();
        }
        private void CmbClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startok == false)
            {
                return;
            }
            ViewData(CmbClientName.SelectedValue.ToString ());
        }

        internal void ShowFormIMG()
        {
            throw new NotImplementedException();
        }

        private void ClearData()
        {
            throw new NotImplementedException();
        }

        private void DisplayData()
        {
            throw new NotImplementedException();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtID.Text = Dg.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            CmbClientName.SelectedValue = Dg.Rows[e.RowIndex].Cells["CustID"].Value.ToString();
            CmbArchif.SelectedValue = Dg.Rows[e.RowIndex].Cells["CataID"].Value.ToString();
            TxtDes.Text = Dg.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            dateTimePicker1.Text = Dg.Rows[e.RowIndex].Cells["Date"].Value.ToString();
            dateTimePicker2.Text = Dg.Rows[e.RowIndex].Cells["Date_2"].Value.ToString();
            txtFilePath.Text = Dg.Rows[e.RowIndex].Cells["File_Path"].Value.ToString();
            Txt_Notes.Text = Dg.Rows[e.RowIndex].Cells["Notes"].Value.ToString();


        }
        /// <summary>
        /// في حالة الاتصال مفتوح لا تفتح الاتصال مره اخري
        /// </summary>
       private void Check_Connection_is_Open()
        {
             
            if (cn.State == ConnectionState.Open)
            {
              
            }
            else
            {
                cn.Open();
            }
        }
       Boolean Check_Cmb(ComboBox cmb)
    {
        if ((cmb.SelectedValue == null) || string.IsNullOrEmpty(cmb.Text))
        {
            MessageBox.Show("برجاء ادخال البيانات","OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            cmb.Focus();

            return false;
        }
        return true;
    }
       Boolean Check_Cmb(TextBox txt)
       {
           if (string.IsNullOrEmpty(txt.Text))
           {
               MessageBox.Show("برجاء ادخال البيانات", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               txt.Focus();

               return false;
           }
           return true;
       }
       Boolean Check_Data()
       {

           if (Check_Cmb(CmbClientName) == false) { return false; }
           if (Check_Cmb(CmbArchif) == false) { return false; }
          
           {
               
           }
           return true;
       }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tb_Users.Pr_Edit == "False")
                {
                    MessageBox.Show("هذا المستخدم لا يملك صلاحية التعديل ");
                    return;
                }
                if (Check_Cmb(txtID) == false) { return; }
                if (Check_Data() == false) { return; }
                Check_Connection_is_Open();
                SqlCommand com = new SqlCommand(@"Update Archif_Data set CustID = " + CmbClientName.SelectedValue.ToString() + ", CataID = " + CmbArchif.SelectedValue.ToString() + ",Description = '" + TxtDes.Text.Trim() + "',Date = '" + dateTimePicker1.Text + "',Date_2 =  '" + dateTimePicker2.Text + "' where ID=" + txtID.Text.Trim() + "", cn);
                com.ExecuteNonQuery();
                ViewData("0");
                MessageBox.Show("تم تعديل البيانات بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);
            }

        }

      

        private void BtnLoadImg_Click(object sender, EventArgs e)
        {
            Ofd.Title = "اختر الملف";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png file(*.png)|*.png|jpg files(*.png)|*.jpg|all files(*.*)|*.* ";
            
            if 
               (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                //Img.ImageLocation = imglocation;

                txtFilePath.Text = imglocation;

            }
        }

       /* private void button1_Click_1(object sender, EventArgs e)
        {
            CLSDATA.insertImg(imglocation);
        SqlCommand Cmd;
            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            cn.Open();
            string sqlQuery = "insert into Archif_Data(Img)values(@images) ";
            Cmd = new SqlCommand(sqlQuery, cn);
            Cmd.Parameters.Add(new SqlParameter("@images", images));
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم حفظ البيانات ");
        }*/

        private void Img_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void TxtDown_TextChanged(object sender, EventArgs e)
        {
            
        }

       // private void button1_Click_2(object sender, EventArgs e)
        /*{
            Ofd.Title = "اختر الملف";
                txtFilePath.Text = Ofd.FileName;
            TxtFileName.Text = Path.GetFileName(Ofd.FileName);
           // Ofd.Multiselect = true;
            Ofd.ShowDialog();
          //  foreach (string f in Ofd.FileNames)
           // {
            //    MessageBox.Show(f);
            //} 


    



        }*/

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ViewData("0");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                Ofd.Title = "اختر الملف";
                // Ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Ofd.ShowDialog();
                txtFilePath.Text = Ofd.FileName;
                TxtFileName.Text = Path.GetFileName(Ofd.FileName);
             //   Txtk.Text = Path.GetExtension(Ofd.FileName);
               imglocation = Path.GetExtension(Ofd.FileName);








            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmbClientName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmbArchif.Focus();
            }

        }

        private void CmbArchif_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtDes.Focus();
            }

        }

        private void TxtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker2.Focus();
            }
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("هل تريد الخروج من البرنامج", " 0AF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Tb_Users.Pr_Edit == "False")
            {
                MessageBox.Show("هذا المستخدم لا يملك صلاحية التعديل","OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            try
            {
                if (Check_Cmb(txtID) == false) { return; }
                if (Check_Data() == false) { return; }
                Check_Connection_is_Open();
                SqlCommand com = new SqlCommand(@"Update Archif_Data set CustID = " + CmbClientName.SelectedValue.ToString() + ", CataID = " + CmbArchif.SelectedValue.ToString() + ",Description = N'" + TxtDes.Text.Trim() + "',Date = '" + dateTimePicker1.Text + "',Date_2 =  '" + dateTimePicker2.Text + "' where ID=" + txtID.Text.Trim() + "", cn);
                com.ExecuteNonQuery();
                ViewData("0");
                MessageBox.Show("تم تعديل البيانات بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close(); 
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);
            }


        }
    }
} 

