using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Frm_Password_Account : Form
    {
        ClsData Cls = new ClsData();
        public Frm_Password_Account()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsData.con.ConnectionString = (@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
            DataSet ds = new DataSet();
            ds = Cls.SQLruturn("select * from dbo.Password_Accounts Where Password_acc = '" + txt_Password_Accounts.Text.ToString() + "'");
            if (ds.Tables[0].Rows.Count > 0)

            {
                Tb_Users.UserID = ds.Tables[0].Rows[0]["ID"].ToString();

                Frm_Accounts fr = new Frm_Accounts();
                fr.ShowDialog();
                txt_Password_Accounts.Text = string.Empty;


            }
            else
            {
                MessageBox.Show("Login Error ");
                return;
            }


            ClsData.con.Close();
        }

        private void txt_Password_Accounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
