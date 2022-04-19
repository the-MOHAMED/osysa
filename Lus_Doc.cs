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
    public partial class Lus_Doc : Form
    {
        SqlConnection con = new SqlConnection(@"data source=192.168.1.200,59595;Network Library=DBMSSOCN; initial catalog= data; user id=MS;password=ms56200");
        SqlCommand com = new SqlCommand();
        bool startok = false;

        ClsData CLSDATA = new ClsData();
        public Lus_Doc()
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Lus_Doc_Load(object sender, EventArgs e)
        {
            try
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Left = Top = 0;
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                CLSDATA.FillCmb("Add_Client", CmbNAme);
                CLSDATA.FillCmb("Archif_Catagory", CmbNO);
                Add_DG_Btn(Dg10, "استعراض", "View");
                fillData("0", "0");
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

        private void fillData(string CustId, string CataID)
        {

            {
                string sql = @"Select ld.ID,ld.Date_1,ld.Date_2,cd.Name,ar.Name,sa.End_Serial,ld.Af_Doc from dbo.Lssu_Doc ld
                            inner join dbo.Add_Client cd on ld.cc = cd.Id
                            inner join dbo.Archif_Catagory ar on ld.ss = ar.ID
                            inner join dbo.Serial sa on ld.ser = sa.End_Serial
                            Where ld.cc = case  '" + CustId + "' when '' then ld.cc else '" + CustId + "' end " +
                            "And ld.ss  = case  '" + CataID + "' when '' then ld.ss else '" + CataID + "' end ";




                CLSDATA.FillDataGrid(Dg10, sql);
                try
                {

                    Dg10.Columns["ID"].HeaderText = "كود ألعميل";
                    Dg10.Columns["Name"].HeaderText = "اسم العميل";
                    Dg10.Columns["Name1"].HeaderText = "نوع المستند";
                    Dg10.Columns["Af_Doc"].HeaderText = "المستند بعد الاعتماد";
                   Dg10.Columns["Date_1"].HeaderText = "الفترة من";
                   Dg10.Columns["Date_2"].HeaderText = "الي";
                    Dg10.Columns["End_Serial"].HeaderText = "كود المستند";
                    Dg10.Columns["Af_Doc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Dg10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                IDA.Text = Dg10.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                CmbNAme.Text = Dg10.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                CmbNO.Text = Dg10.Rows[e.RowIndex].Cells["Name1"].Value.ToString();
                TxtCode.Text = Dg10.Rows[e.RowIndex].Cells["End_Serial"].Value.ToString();
                dateTimePicker1.Text = Dg10.Rows[e.RowIndex].Cells["Date_1"].Value.ToString();
                dateTimePicker2.Text = Dg10.Rows[e.RowIndex].Cells["Date_2"].Value.ToString();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           

           

        }

        private void CmbNAme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (startok == true)

                {
                    string calat = "0";
                    if (string.IsNullOrEmpty(CmbNO.SelectedValue.ToString()) == true)
                    {
                    }
                    else
                    {
                        calat = CmbNO.SelectedValue.ToString();
                    }
                    fillData(CmbNAme.SelectedValue.ToString(), calat);
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("حدد  نوع المستند ", " 0AF");
            }

        }

        private void CmbNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (startok == true)

                {
                    string calat = "0";
                    if (string.IsNullOrEmpty(CmbNO.SelectedValue.ToString()) == true)
                    {
                    }
                    else
                    {
                        calat = CmbNO.SelectedValue.ToString();
                    }
                    fillData(CmbNAme.SelectedValue.ToString(), calat);
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("حدد اسم العميل ", " 0AF");
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


        private void TxtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dg10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    MessageBox.Show(e.RowIndex.ToString());
                }
                if (Dg10.Columns[e.ColumnIndex].HeaderText == "View")
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = Dg10.Rows[index];
                    CmbNAme.Text = selectedRow.Cells[0].ToString();
                    Check_Connection_is_Open();
                    string str = "Select  Af_Doc from dbo.Lssu_Doc where ID = " + Dg10.Rows[e.RowIndex].Cells["ID"].Value.ToString() +"";
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(str, con);
                    sda.Fill(ds);
                    string FileName = Dg10.Rows[e.RowIndex].Cells["Af_Doc"].ToString();
                  
                    FileStream Fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                 
                    Fs.Close();
                    System.Diagnostics.Process.Start(FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void IDA_TextChanged(object sender, EventArgs e)
        {
            IDA.ReadOnly = true;
        }
    }
}
    

