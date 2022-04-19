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
    public partial class frmdec : Form
    {
        SqlConnection con = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
        SqlCommand com = new SqlCommand();

        ClsData CLSDATA = new ClsData();
        public frmdec()
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
            private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Cmb_Name.Text))
            {
                MessageBox.Show("برجاء ادخال أسم التصنيف", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (String.IsNullOrEmpty(Txt_Short_Name.Text))
            {
                MessageBox.Show("برجاء كتابة الاسم المختصر  ", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            try
            {
                CLSDATA.SQLExe(@"INSERT INTO dbo.Archif_Catagory([Name],[File_Dec],[ShortCutName])
                               VALUES(N'" + Cmb_Name.Text.Trim() + "',N'"+TxtDec.Text.Trim()+"',N'"+Txt_Short_Name.Text.Trim()+"')");

                MessageBox.Show("تم الأضافة بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Cmb_Name.Text = string.Empty;
                Txt_Short_Name.Text = string.Empty;
                TxtDec.Text = string.Empty;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Cmb_Name;
            Cmb_Name.Focus();
            CLSDATA.FillCmb("Archif_Catagory", Cmb_Name);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameDec_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Cmb_Name_TextChanged(object sender, EventArgs e)
        {
            }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Cmb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Cmb_Name_Click(object sender, EventArgs e)
        {
        

        }

        private void Cmb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Txt_Short_Name.Focus();
            }

        }

        private void Txt_Short_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTNSAVE.Focus();
            }
        }
    }
    }      
