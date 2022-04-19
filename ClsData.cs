using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication2
{

    class ClsData
    {
        public static SqlConnection con = new SqlConnection();

        void OpenConnction()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CONN()
        {
            SqlConnection cn = new SqlConnection(@"data source=DESKTOP-OBJDOO9\Sql2008; initial catalog= data; integrated security=true");

        }
        /// <summary>
        /// مل
        /// </summary>
        /// <param name="TBName"></param>
        /// <param name="Cmb"></param>
        public void FillCmb(string TBName, ComboBox Cmb)
        {
            try
            {
            SqlCommand com = new SqlCommand();

              OpenConnction();

            com.Connection = con;
            string query = "select ID,Name from " + TBName + "";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, TBName);
            Cmb.DisplayMember = "Name";
            Cmb.ValueMember = "ID";
            Cmb.DataSource = ds.Tables[TBName];
            Cmb.SelectedIndex = -1;
            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
        public void SQLExe(string str)
        {
            try
            {
                OpenConnction();
                SqlCommand com = new SqlCommand(str, con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public DataSet SQLruturn(string query)

        {
           
            
                SqlCommand com = new SqlCommand();

                OpenConnction();
                com.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

        }
      public void FillDataGrid(DataGridView  Dg, string sql)
        { 
                try
                {
                    ///SqlConnection connection = new SqlConnection(ClsData.con);
                    SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
                    BindingSource BS = new BindingSource();

                    DataSet ds = new DataSet();

                  OpenConnction();

                    dataadapter.Fill(ds, "Archif_Data");
                    Dg.DataSource = ds.Tables[0];
                    // dataGridView1.DataSource = BS;
                    con.Close();
                  

                }
                catch (Exception ex)
                {

                MessageBox.Show(ex.Message);
                }
        }
        public void FillDataGrid1(DataGridView Dg, string sql)
        {

            try
            {
                ///SqlConnection connection = new SqlConnection(ClsData.con);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
                BindingSource BS = new BindingSource();

                DataSet ds = new DataSet();

                OpenConnction();

                dataadapter.Fill(ds, "dbo.Lssu_Doc");
                Dg.DataSource = ds.Tables[0];
                // dataGridView1.DataSource = BS;
                con.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        public void insertImg(string imglocation)
        {
            try
            {
                SqlCommand Cmd;
                byte[] images = null;
                FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                OpenConnction();
                string sqlQuery = "insert into Archif_Data(Img)values(@images) ";
                Cmd = new SqlCommand(sqlQuery, con);
                Cmd.Parameters.Add(new SqlParameter("@images", images));
                Cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم حفظ البيانات ");
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
         
            
        }
     public void EnterTextbox()
        { }

    }
 
}
