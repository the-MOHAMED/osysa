using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace WindowsFormsApplication2
{

    public partial class FormIMG : Form
    {
        public FormIMG()
        {
            InitializeComponent();
        }
        
        SqlConnection cn = new SqlConnection(@"data source=DESKTOP-OBJDOO9\Sql2008; initial catalog= data; integrated security=true");

        string imglocation = "";
        SqlCommand Cmd;
    
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png file(*.png)|*.png|jpg files(*.png)|*.jpg|all files(*.*)|*.* ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                Img.ImageLocation = imglocation;



            }

        }

        private void FormIMG_Load(object sender, EventArgs e)
        {
            this.Text  = "فلفل";

        }


        private void BtnSave_Click_1(object sender, EventArgs e)
        {
           
                

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
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
 
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Img_Click(object sender, EventArgs e)
        {

        }

        private void pictherBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
