using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
   public partial class Client : Form
    {

FELFELFELFLEF
        SqlConnection con = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");

        //DataTable ;
        // string imglocation;
        //  bool startok = false;


        ClsData CLSDATA = new ClsData();
        public Client()
        {
            InitializeComponent();
            this.ActiveControl = txt00;
            txt00.Focus();
        }


        private void Client_Load(object sender, EventArgs e)
        {
            fillData();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt00.Text))
            {
                MessageBox.Show("برجاء ادخال اسم العميل");
                return;
            }

            try
            {
                CLSDATA.SQLExe(@"INSERT INTO dbo.Add_Client([Name],[Trade_Name],[Nmb_1],[Nmb_2],[Nmb_3],[Nmb_4],[User_ID])
          VALUES(N'" + txt00.Text + "',N'"+txt_tr_Name.Text.Trim()+"',N'" + Txt_1.Text.Trim() + "',N'" + Txt_2.Text.Trim() + "',N'" + Txt_3.Text + "',N'" + Txt_4.Text + "'," + Tb_Users.UserID.ToString() + ")");
                fillData();
                MessageBox.Show("تم الأضافة بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TxtId.Text = string.Empty;
                txt00.Text = string.Empty;
                Txt_1.Text = string.Empty;
                Txt_2.Text = string.Empty;
                Txt_3.Text = string.Empty;
                Txt_4.Text = string.Empty;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show(e.RowIndex.ToString());
            }
            if (Dg1.Columns[e.ColumnIndex].HeaderText == "View")
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = Dg1.Rows[index];
                txt00.Text = selectedRow.Cells[0].ToString();
                Check_Connection_is_Open();
                string str = "Select Client_Name from dbo.Add_Client where ID =" + Dg1.Rows[e.RowIndex].Cells["ID_"].Value.ToString() + "";
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(str, con);
                sda.Fill(ds);
            }

        }

        private void fillData()
        {

            {
                string sql = @"SELECT [ID],[Name],[Trade_Name],[Nmb_1],[Nmb_2],[Nmb_3],[Nmb_4] FROM [Add_Client]";
                  
                CLSDATA.FillDataGrid(Dg1, sql);
                try
                {
                    Dg1.Columns["ID"].HeaderText = "كود العميل";
                    Dg1.Columns["Name"].HeaderText = "أسم العميل";
                    Dg1.Columns["Trade_Name"].HeaderText = "ألاسم التجاري";
                    Dg1.Columns["Nmb_1"].HeaderText = "رقم السجيل التجاري";
                    Dg1.Columns["Nmb_2"].HeaderText = "رقم ألسجل الضريبي";
                    Dg1.Columns["Nmb_3"].HeaderText = "الرقم التأميني";
                //    Dg1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    Dg1.Columns["Nmb_4"].HeaderText = "المأمورية التابع لها";
                    Dg1.Columns["ID"].Width = 35;
                    Dg1.Columns["Name"].Width = 200;
                    Dg1.Columns["Trade_Name"].Width = 200;
                    


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            TxtId.ReadOnly = true;
        }

        private void txt00_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt00_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex < 0) return;
                TxtId.Text = Dg1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txt00.Text = Dg1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txt_tr_Name.Text = Dg1.Rows[e.RowIndex].Cells["Trade_Name"].Value.ToString();
                Txt_1.Text = Dg1.Rows[e.RowIndex].Cells["Nmb_1"].Value.ToString();
                Txt_2.Text = Dg1.Rows[e.RowIndex].Cells["Nmb_2"].Value.ToString();
                Txt_3.Text = Dg1.Rows[e.RowIndex].Cells["Nmb_3"].Value.ToString();
                Txt_4.Text = Dg1.Rows[e.RowIndex].Cells["Nmb_4"].Value.ToString();


            }
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
                    Check_Connection_is_Open();      
                SqlCommand com = new SqlCommand(@"Update dbo.Add_Client set Name =N'" + txt00.Text + "',Nmb_1 = N'" + Txt_1.Text + "',Trade_Name = '"+txt_tr_Name.Text+"',Nmb_2 = N'"+Txt_2.Text+ "',Nmb_3 = N'" + Txt_3.Text + "',Nmb_4 = N'" + Txt_4.Text + "' where ID=" + TxtId.Text.Trim() + "", con);
                com.ExecuteNonQuery();
                fillData();
                MessageBox.Show("تم تعديل البيانات بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (Tb_Users.Pr_Delete == "False")
                {
                    MessageBox.Show("هذا المستخدم لا يملك صلاحية الحذف", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                    DialogResult dialogResult = MessageBox.Show("هل تريد الحذف فعلا", "OAF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (String.IsNullOrEmpty(txt00.Text.ToString()))
                    {
                        MessageBox.Show("من فضلك حدد الصف المراد حذفه", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    SqlConnection cn = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "Delete from Add_Client where ID =" + TxtId.Text + "";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    fillData();
                    cn.Close();
                    //   ViewData(txt00.Text.ToString());
                    MessageBox.Show("تم حذف البيانات ", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txt00_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Txt_1.Focus();
                }

            }
        }

        private void Txt_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Txt_2.Focus();
            }

        }

        private void Txt_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Txt_3.Focus();
            }

        }

        private void Txt_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Txt_4.Focus();
            }

        }

        private void Txt_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt00_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }     }


