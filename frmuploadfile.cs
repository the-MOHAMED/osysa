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
    public partial class frmuploadfile : Form
    {
      SqlConnection con = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
        SqlCommand com = new SqlCommand();
        bool startok = false;

        ClsData CLSDATA = new ClsData();
        public frmuploadfile()
        {
            InitializeComponent();
            
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

        void fillData(string CustId,string CataID)
        {

            try
            {

                string sql = @"Select TB.ID,cd.Name,ac.Name,TB.Date,TB.Date_2,TB.File_Path from dbo.Archif_Data TB
                             inner join dbo.Add_Client cd on TB.CustID = cd.Id
                             inner join dbo.Archif_Catagory ac on TB.CataID = ac.id
                               Where tb.CustID = case  '" + CustId + "' when '' then tb.CustID else '" + CustId + "' end "+
                              "And tb.CataID  = case  '" + CataID + "' when '' then tb.CataID else '" + CataID + "' end ";




                CLSDATA.FillDataGrid(Dg2,sql);
               
                try
                {


                    Dg2.Columns["ID"].HeaderText = "كود ألعميل";
                    Dg2.Columns["Name"].HeaderText = "اسم العميل";
                    Dg2.Columns["Name1"].HeaderText = "نوع المستند";
                    Dg2.Columns["File_Path"].HeaderText = "المستندات";
                    Dg2 .Columns["File_Path"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    Dg2.Columns["Date"].HeaderText = "الفترة من";
                    Dg2.Columns["Date_2"].HeaderText = "الي";



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

     /*   private void Btn_save_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Txt_path.Text))
            {
                MessageBox.Show("برجاء ادخال اسم العميل");
                return;
            }
            try
            {
                Check_Connection_is_Open();
                SqlCommand com = new SqlCommand(@"INSERT INTO dbo.Archif_Data ([CustID],[File_Path])
                VALUES(" + CmbN.SelectedValue.ToString() + ",'" + Txt_path.Text + "')", con);
               
                byte[] images = null;
                FileStream stream = new FileStream(Txt_path.Text.Trim(), FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                // com.Parameters.Add(new SqlParameter("@images", images));
               com.Parameters.Add(new SqlParameter("File_Path", SqlDbType.VarBinary)).Value = images;
                com.ExecuteNonQuery();
                MessageBox.Show("تم الحفظ بنجاح ", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                fillData();
                con.Close();
                // CLSDATA.insertImg(imglocation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }*/

        private void TXTID_TextChanged(object sender, EventArgs e)
        {
           txtdi.ReadOnly = true;
        }

        private void Dg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show(e.RowIndex.ToString());
            }
            if (Dg2.Columns[e.ColumnIndex].HeaderText == "View")
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = Dg2.Rows[index];
                CmbN.Text = selectedRow.Cells[0].ToString();
                Check_Connection_is_Open();
                string str = "Select Arch_Doc from dbo.Archif_Data where ID =" + Dg2.Rows[e.RowIndex].Cells["ID"].Value.ToString() + "";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(str, con);
                sda.Fill(ds);
                string FileName = Dg2.Rows[e.RowIndex].Cells["File_Path"].ToString();
                byte[] File_Data = (byte[])ds.Tables[0].Rows[0]["Arch_Doc"];
                FileStream Fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                Fs.Write(File_Data, 0, File_Data.Length);
                Fs.Close();
                System.Diagnostics.Process.Start(FileName);
            }
        }
        private void Add_DG_Btn(DataGridView Datagride, string txt, string Col_Name)
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = txt;
            col.Name = Col_Name;
            if (Col_Name == "View") { col.DefaultCellStyle.ForeColor = System.Drawing.Color.Red; }
            col.Width = 60;
            Datagride.Columns.Add(col);
        }

        private void frmuploadfile_Load(object sender, EventArgs e)
        {
            try
            {
                
                CLSDATA.FillCmb("Add_Client", CmbN);
                CLSDATA.FillCmb("Archif_Catagory", Cmb1);
                fillData("0","0");
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                Add_DG_Btn(Dg2, "استعراض", "View");
                Add_DG_Btn(Dg2, "حذف", "Delete");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
    finally
            {
                
                startok = true;
            }
                
              

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtdi.Text = Dg2.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                CmbN.Text = Dg2.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                Cmb1.Text = Dg2.Rows[e.RowIndex].Cells["Name1"].Value.ToString();
                dateTimePicker1.Text = Dg2.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                dateTimePicker2.Text = Dg2.Rows[e.RowIndex].Cells["Date_2"].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("برجاء تحديد الصف", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (Dg2.Columns[e.ColumnIndex].HeaderText == "Delete")

            {

                DialogResult dialogResult = MessageBox.Show("هل تريد الحذف", " 0AF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (String.IsNullOrEmpty(txtdi.Text.ToString()))
                    {
                        MessageBox.Show("من فضلك حدد الصف المراد حذفه");
                    }
                    SqlConnection cn = new SqlConnection(@"data source=DESKTOP-OBJDOO9\Sql2008; initial catalog= data; integrated security=true");
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "Delete from Archif_Data where ID =" + txtdi.Text + "";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    fillData(CmbN.SelectedValue.ToString(), Cmb1.SelectedValue.ToString()); ;
                    MessageBox.Show("تم حذف البيانات بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }  }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CmbN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (startok == true)
                    
                {
                    string calat = "0";
                    if (string.IsNullOrEmpty(Cmb1.SelectedValue.ToString()) == true)
                    {
                   }
                    else
                    {
                        calat = Cmb1.SelectedValue.ToString();
                     }
                    fillData(CmbN.SelectedValue.ToString(),calat);
                    return;
                }
            }
            catch (Exception )
            {

                MessageBox.Show("حدد نوع المستند", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
         
           
        }

        private void Cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (startok == true)

                {
                    string calat = "0";
                    if (string.IsNullOrEmpty(Cmb1.SelectedValue.ToString()) == true)
                    {
                    }
                    else
                    {
                        calat = Cmb1.SelectedValue.ToString();
                    }
                    fillData(CmbN.SelectedValue.ToString(), calat);
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("حدد اسم العميل ", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
