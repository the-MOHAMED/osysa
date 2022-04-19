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
    public partial class Frm_Accounts : Form
    {
        ClsData CLSDATA = new ClsData();
        bool startok = false;
        SqlConnection con = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
        public Frm_Accounts()
        {
            InitializeComponent();
        }

        private void Frm_Accounts_Load(object sender, EventArgs e)
        {
            try
            {
                CLSDATA.FillCmb("Add_Client", Cmb_Name_Acc);
                fillData(Cmb_Name_Acc.SelectedValue.ToString());
            }
            catch (Exception)
            {

                
            }


            finally
            {
                startok = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("هل تريد الخروج من البرنامج", " 0AF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }
        private void fillData(string CustIdd)
        {

            {
                string sql = @"SELECT ac.ID,ad.Name,ac.Name,ac.Password,ac.password_SS,ac.Card_Nub FROM Accounts  ac
                             inner join  dbo.Add_Client ad on ac.Ccust = ad.ID
                             Where ac.Ccust = case  '" + CustIdd + "' when '' then ac.Ccust else '" + CustIdd + "' end";


                CLSDATA.FillDataGrid1(Dg0, sql);
                try
                {
                    Dg0.Columns["ID"].HeaderText = "الكود";
                    Dg0.Columns["Name"].HeaderText = "أسم العميل";
                    Dg0.Columns["Name1"].HeaderText = "أسم الدخول";
                    Dg0.Columns["Password"].HeaderText = "كلمة السر";
                    Dg0.Columns["password_SS"].HeaderText = "كلمة سر المرتبات";
                    Dg0.Columns["Card_Nub"].HeaderText = "الرقم القومي للمسؤل :";
                    Dg0.Columns["ID"].Width = 30;
                  //  Dg0.Columns["Name"].Width = 100;
                    Dg0.Columns["Name1"].Width = 100;
                    Dg0.Columns["Password"].Width = 100;
                    Dg0.Columns["password_SS"].Width = 100;
                    Dg0.Columns["Card_Nub"].Width = 100;
                    Dg0.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Cmb_Name_Acc.Text))
            {
                MessageBox.Show("برجاء ادخال البيانات", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                CLSDATA.SQLExe(@"INSERT INTO dbo.Accounts (Ccust,Name,Password,Password_ss,Card_Nub)
                VALUES(" + Cmb_Name_Acc.SelectedValue.ToString() + ",N'" + Txtlo.Text.Trim() + "',N'" + txtpa.Text.Trim() + "','" + txt_pa_ss.Text.Trim() + "','" + txt_Caed_Num.Text.Trim() + "')");
                fillData(Cmb_Name_Acc.SelectedValue.ToString());
                MessageBox.Show("تم حفظ البيانات بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
             //   Cmb_Name_Acc.Text = string.Empty;
                Txtlo.Text = string.Empty;
                txtpa.Text = string.Empty;
                txt_pa_ss.Text = string.Empty;
            }
            catch
            {

            }
        }

        private void Dg0_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            try
            {
                txt_id.Text = Dg0.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                Cmb_Name_Acc.Text = Dg0.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                Txtlo.Text = Dg0.Rows[e.RowIndex].Cells["Name1"].Value.ToString();
                txtpa.Text = Dg0.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txt_pa_ss.Text = Dg0.Rows[e.RowIndex].Cells["password_SS"].Value.ToString();
                txt_Caed_Num.Text = Dg0.Rows[e.RowIndex].Cells["Card_Nub"].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void Txtlo_TextChanged(object sender, EventArgs e)
        {

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
                SqlCommand com = new SqlCommand(@"Update dbo.Accounts set Name =N'" + Txtlo.Text + "',Password = N'" + txtpa.Text + "',password_ss= '" + txt_pa_ss.Text + "',Card_Nub= '"+txt_Caed_Num.Text+"' Where ID = " + txt_id.Text + "", con);
                com.ExecuteNonQuery();
                fillData(Cmb_Name_Acc.SelectedValue.ToString());
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
                    if (String.IsNullOrEmpty(txt_id.Text.ToString()))
                    {
                        MessageBox.Show("من فضلك حدد الصف المراد حذفه", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    SqlConnection cn = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "Delete from dbo.Accounts where ID =" + txt_id.Text + "";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    fillData(Cmb_Name_Acc.SelectedValue.ToString());
                    cn.Close();
                    MessageBox.Show("تم حذف البيانات ", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Cmb_Name_Acc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startok == false)
            {
                return;
            }
            fillData(Cmb_Name_Acc.SelectedValue.ToString());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }


