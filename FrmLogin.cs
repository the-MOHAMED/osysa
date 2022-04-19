using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApplication2
{
    public partial class FrmLogin : Form
    {
        ClsData Cls = new ClsData();
      
            public FrmLogin()
        {

            InitializeComponent();

        }

        bool Check(CheckBox chk)
        {
            if (chk.Checked)
            {
                return false;
            }
            return true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
               ClsData.con.ConnectionString = (@"data source=DESKTOP-OBJDOO9\Sql2008; initial catalog= data; integrated security=true");
                //DataSet ds = new DataSet();

               // ClsData.con.ConnectionString = (@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
                DataSet ds = new DataSet();


                ds = Cls.SQLruturn("select * from dbo.Table_Login Where Name = '" + TxtName.Text.ToString() + "' And PassWord = '" + TxtPassword.Text.ToString() + "'");
                if (ds.Tables[0].Rows.Count > 0)

                {
                    Tb_Users.UserID = ds.Tables[0].Rows[0]["ID"].ToString();
                    Tb_Users.Pr_Edit  = ds.Tables[0].Rows[0]["Pr_Edit"].ToString();
                    Tb_Users.Pr_Delete = ds.Tables[0].Rows[0]["Pr_Delete"].ToString();

                    FrmMain f2 = new FrmMain();
                    f2.Show();

                }

                
            }
            catch (Exception)
            {

                MessageBox.Show("Login Error ");
                return;
            }
           
            ClsData.con.Close();

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)

        {

        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode  == Keys.Enter)
            {
                BtnLogin.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)

        {

       }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}