using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Issuing_documents : Form
    {
        SqlConnection con = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");

gggggggggggggg
        ClsData CLSDATA = new ClsData();
        public Issuing_documents()
        {
            InitializeComponent();
        }
        bool startok = false;
        DataSet ds1 = new DataSet();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        Boolean check_Cmb(ComboBox cmb)
        {
            if ((cmb.SelectedValue == null) || string.IsNullOrEmpty(cmb.Text))
            {
                MessageBox.Show("برجاء ادخال البيانات", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmb.Focus();

                return false;
            }
            return true;
        }
        Boolean check_Cmb(TextBox txt)
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

            if (check_Cmb(CmbClientNamee) == false) { return false; }
            if (check_Cmb(CmbType) == false) { return false; }

            {

            }
            return true;
        }
        private void Check_Connection_is_Open()
        {

            if (con.State == ConnectionState.Open)
            {

            }
            else
            {
                con.Open();
            }
        }
        private void Issuing_documents_Load(object sender, EventArgs e)
        {
            try
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                CLSDATA.FillCmb("Add_Client", CmbClientNamee);
                CLSDATA.FillCmb("Archif_Catagory", CmbType);
                Add_DG_Btn(Dg5, "حذف", "Delete");
                //   Add_DG_Btn(Dg5, "استعراض", "View");
                fillData("0");

            }
            catch (Exception)
            {


            }

            finally
            {
                startok = true;
            }


        }
        private void Increment()
        {
            string i = txt_Serial.Text;
            string o = txt_NumSer.Text;
            string m = txt_cc.Text;
            string n = txt_NameSerial.Text;
            string l = txt_NameSerial.Text;
            string d = Dt1.Text;
            txt_End_Serial.Text = i + m + n + d + l + o;

        }
        private void Add_DG_Btn(DataGridView Datagride, string txt, string Col_Name)
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = txt;
            col.Name = Col_Name;
            if (Col_Name == "Delete") { col.DefaultCellStyle.ForeColor = System.Drawing.Color.Red; }
            col.Width = 60;
            Datagride.Columns.Add(col);
        }

        private void fillData(string cataid)
        {

            {
                string sql = @"Select ld.ID,ld.cc,ld.Date_1,ld.Date_2,cd.Name,ar.Name,ld.Description,ld.Be_Doc,sa.End_Serial from dbo.Lssu_Doc ld
                            inner join dbo.Add_Client cd on ld.cc = cd.Id
                            inner join dbo.Archif_Catagory ar on ld.ss = ar.ID
                            inner join dbo.Serial sa on ld.ser = sa.End_Serial Where ld.cc = case  '" + cataid + "' when '' then ld.cc else '" + cataid + "' end";


                CLSDATA.FillDataGrid1(Dg5, sql);
                try
                {
                    Dg5.Columns["ID"].HeaderText = "كود العميل";
                    Dg5.Columns["Name"].HeaderText = "أسم العميل";
                    Dg5.Columns["cc"].Visible = false;
                    Dg5.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    Dg5.Columns["Name1"].HeaderText = "نوع المستند";
                    Dg5.Columns["Date_1"].HeaderText = "الفترة من";
                    Dg5.Columns["Date_2"].HeaderText = "الفترة الي";
                    Dg5.Columns["Description"].HeaderText = "وصف المستند";
                    Dg5.Columns["Be_Doc"].HeaderText = "المستند";
                    Dg5.Columns["End_Serial"].HeaderText = "كود المستند";



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CmbClientNamee.Text))
            {
                MessageBox.Show("برجاء ادخال البيانات", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (String.IsNullOrEmpty(TxtAfter.Text))
            {
                MessageBox.Show("برجاء تحميل الملف بعد الاعتماد ", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            try
            {
                CLSDATA.SQLExe(@"INSERT INTO Lssu_Doc ([cc],[ss],[ser],[Date_1],[Date_2],[Description],[Be_Doc],[Af_Doc])
                VALUES(" + CmbClientNamee.SelectedValue.ToString() + "," + CmbType.SelectedValue.ToString() + ",'" + txt_End_Serial.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," +
                "N'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',N'" + Txtk.Text + "',N'" + TxtFileNamee.Text + "'," +
                "N'" + TxtAfter.Text + "')");
                MessageBox.Show("تم حفظ البيانات بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                fillData(CmbClientNamee.SelectedValue.ToString());
                hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void hide()
        {
            txtIDD.Text = string.Empty;
        //    CmbClientNamee.Text = string.Empty;
            CmbType.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            Txtk.Text = string.Empty;
            TxtFileNamee.Text = string.Empty;
            txtpathhh.Text = string.Empty;
            TxtAfter.Text = string.Empty;
            txt_End_Serial.Text = string.Empty;

        }
        private void upd_Before_Click(object sender, EventArgs e)
        {
            {
                Ofd3.Title = "اختر الملف";
                // Ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Ofd3.ShowDialog();
                TxtFileNamee.Text = Ofd3.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = CLSDATA.SQLruturn(@"SELECT ShortCutName FROM [dbo].[Archif_Catagory] where ID = " + CmbType.SelectedValue.ToString() + "");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtpathhh.Text = ds.Tables[0].Rows[0]["ShortCutName"].ToString();
                
                }
            }
            catch (Exception )
            {

                MessageBox.Show("برجاء تحديد نوع المستند", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                try
                {
                    DataSet ds = CLSDATA.SQLruturn(@"SELECT Name FROM [dbo].[dbo.Add_Client] where ID = " + CmbClientNamee.SelectedValue.ToString() + "");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtpathhh.Text = ds.Tables[0].Rows[0]["Name"].ToString();

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("برجاء تحديد نوع المستند", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Dg5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if (e.RowIndex < 0)
            {
                MessageBox.Show(e.RowIndex.ToString());
            }
            if (Dg5.Columns[e.ColumnIndex].HeaderText == "View")
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = Dg5.Rows[index];
                CmbClientNamee.Text = selectedRow.Cells[0].ToString();
                Check_Connection_is_Open();
                string str = "Select Arcif_Doc from dbo.Lssu_Doc where ID =" + Dg5.Rows[e.RowIndex].Cells["ID"].Value.ToString() + "";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(str, con);
                sda.Fill(ds);
                string FileName = Dg5.Rows[e.RowIndex].Cells["Be_Doc"].ToString();
                byte[] File_Data = (byte[])ds.Tables[0].Rows[0]["Arcif_Doc"];
                FileStream Fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                Fs.Write(File_Data, 0, File_Data.Length);
                Fs.Close();
                System.Diagnostics.Process.Start(FileName);

            }
            if (Dg5.Columns[e.ColumnIndex].HeaderText == "Delete")

            {
                if (Tb_Users.Pr_Delete == "False")
                {
                    MessageBox.Show("هذا المستخدم لا يملك صلاحية الحذف", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("هل تريد الحذف", " 0AF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (String.IsNullOrEmpty(txtIDD.Text.ToString()))
                    {
                        MessageBox.Show("من فضلك حدد الصف المراد حذفه");
                    }
                    SqlConnection cn = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "Delete from Lssu_Doc where ID =" + txtIDD.Text + "";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    fillData(CmbClientNamee.SelectedValue.ToString());
                    MessageBox.Show("تم حذف البيانات بنجاح", " 0AF", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void txtIDD_TextChanged(object sender, EventArgs e)
        {
            txtIDD.ReadOnly = true;
        }

        private void Dg5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (e.RowIndex < 0) return;
                txtIDD.Text = Dg5.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                CmbClientNamee.Text = Dg5.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                CmbType.Text = Dg5.Rows[e.RowIndex].Cells["Name1"].Value.ToString();
                dateTimePicker1.Text = Dg5.Rows[e.RowIndex].Cells["Date_1"].Value.ToString();
                dateTimePicker2.Text = Dg5.Rows[e.RowIndex].Cells["Date_2"].Value.ToString();
             //   Txtk.Text = Dg5.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                 TxtFileNamee.Text = Dg5.Rows[e.RowIndex].Cells["Be_Doc"].Value.ToString();
              
                Txtk.Text = Dg5.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                txt_End_Serial.Text = Dg5.Rows[e.RowIndex].Cells["End_Serial"].Value.ToString();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            {
          



            }
        }

        private void Upd_After_Click(object sender, EventArgs e)
        {
              {
                Ofd3.Title = "اختر الملف";
                // Ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Ofd3.ShowDialog();
                TxtAfter.Text = Ofd3.FileName;
            }
        }

        private void txtSearchh_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmbClientNamee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startok == false)
            {
                return;
            }
            fillData(CmbClientNamee.SelectedValue.ToString());
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل تريد الخروج من البرنامج", " 0AF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void CmbClientNamee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmbType.Focus();
            }
        }

        private void CmbType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
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
                Txtk.Focus();
            }
        }

        private void Txtk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSavee.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtFileNamee.Text))
            {
                MessageBox.Show("برجاء تحميل الملف", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                DataSet ds = CLSDATA.SQLruturn(@"SELECT  isnull(Max([nmb_Serial]) + 1,1001) MaxId FROM dbo.Serial");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txt_NumSer.Text = ds.Tables[0].Rows[0]["MaxId"].ToString();

                }
                DataSet ds1 = CLSDATA.SQLruturn(@"SELECT ShortCutName FROM [dbo].[Archif_Catagory] where ID = " + CmbType.SelectedValue.ToString() + "");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    txt_cc.Text = ds1.Tables[0].Rows[0]["ShortCutName"].ToString();
                }
                DataSet ds2 = CLSDATA.SQLruturn(@"SELECT D_ate FROM [dbo].[Serial] where ID = " + CmbType.SelectedValue.ToString() + "");
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    Dt1.Text = ds2.Tables[0].Rows[0]["D_ate"].ToString();
                }
                Increment();
                CLSDATA.SQLExe(@"INSERT INTO dbo.Serial (Serial,Serial_Name,N_Serial,nmb_Serial,End_Serial,D_ate,User_Id)
                VALUES('" + txt_Serial.Text.Trim() + "',N'" + txt_NameSerial.Text + "',N'" + txt_cc.Text + "',N'" + txt_NumSer.Text + "',N'" + txt_End_Serial.Text + "','"+Dt1.Value.ToString("yyyy")+"'," + Tb_Users.UserID.ToString() + ")");


                fillData("0");
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
     
        }

        private void Serial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpathhh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_End_Serial_TextChanged(object sender, EventArgs e)
        {
            txt_End_Serial.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (Tb_Users.Pr_Edit == "False")
                {
                    MessageBox.Show("هذا المستخدم لا يملك صلاحية التعديل", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (check_Cmb(txtIDD) == false) { return; }
                if (Check_Data() == false) { return; }
                Check_Connection_is_Open();
                SqlCommand com = new SqlCommand(@"Update dbo.Lssu_Doc set cc = " + CmbClientNamee.SelectedValue.ToString() + ", ss = " + CmbType.SelectedValue.ToString() + ",Description = N'" + Txtk.Text.Trim() + "',Date_1 = '" + dateTimePicker1.Text + "',Date_2 =  '" + dateTimePicker2.Text + "'" +
                    ",Be_Doc ='"+ TxtFileNamee.Text+ "' where ID=" + txtIDD.Text.Trim() + "", con);
                com.ExecuteNonQuery();
                fillData("0");
                MessageBox.Show("تم تعديل البيانات بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Dg5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
   
}

