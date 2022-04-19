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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmArchif FrmArchif = new frmArchif();
            FrmArchif.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmuploadfile FRM1 = new frmuploadfile();
                FRM1.ShowDialog();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddUser ADDUSER = new AddUser();
            ADDUSER.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل تريد الخروج من البرنامج", " 0AF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Client CLSSCLIENT = new Client();
            CLSSCLIENT.ShowDialog();
                
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Issuing_documents LD = new Issuing_documents();
                LD.ShowDialog();

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            frmdec FRMDEC = new frmdec();
            FRMDEC.ShowDialog();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Lus_Doc LUD = new Lus_Doc();
                LUD.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Frm_Password_Account fr = new Frm_Password_Account();
                fr.ShowDialog();
        }
    }

        
        
        }
   


        
    

