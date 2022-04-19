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
    public partial class AddUser : Form
    {
        ClsData CLSDATA = new ClsData();

        public AddUser()
        {
            InitializeComponent();


        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (Tb_Users.Pr_Delete == "False")
            {
                MessageBox.Show("هذا المستخدم لا يملك صلاحية الاضافة", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            CLSDATA.SQLExe("INSERT INTO [Table_Login]([Name],[Password],[Pr_Edit],[Pr_Delete]) VALUES('" + TxtUser.Text.Trim() + "','" + TxtPasswordd.Text + "','" + Chk_Pr_Edit.Checked + "','" + Chk_Pr_Delete.Checked + "')");
            MessageBox.Show("تم الأضافة بنجاح", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            fillData();
            TxtUser.Text = string.Empty;
            TxtPasswordd.Text = string.Empty;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            this.ActiveControl = TxtUser;
            TxtUser.Focus();
            fillData();
        }
        private void fillData()
        {

            {
                string sql = @"select Id,Name,Password from dbo.Table_Login";


                CLSDATA.FillDataGrid(Dg9, sql);
                Dg9.Columns["Name"].HeaderText = "اسم العميل";
                Dg9.Columns["Name"].Width = 250;
                Dg9.Columns["Password"].HeaderText = "كلمه السر";
                Dg9.Columns["Password"].Width = 250;
            }
        }

        private void Dg9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtUser.Text = Dg9.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            TxtPasswordd.Text = Dg9.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            tid.Text = Dg9.Rows[e.RowIndex].Cells["Id"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tb_Users.Pr_Delete == "False")
            {
                MessageBox.Show("هذا المستخدم لا يملك صلاحية الحذف", "OAF", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            DialogResult dialogResult = MessageBox.Show("هل تريد الحذف", " 0AF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(tid.Text.ToString()))
                {
                    MessageBox.Show("من فضلك حدد الصف المراد حذفه");
                }
                SqlConnection cn = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Delete from dbo.Table_Login where Id=" + tid.Text + "";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cn.Close();
                fillData();
                MessageBox.Show("تم حذف البيانات بنجاح");
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Dg9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

