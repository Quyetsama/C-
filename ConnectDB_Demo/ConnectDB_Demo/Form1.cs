using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDB_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-EBVUMV9\MSSQLSERVER01;Initial Catalog=Demo1;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            string sql = "select sv.Msv, Hoten, lop.Malop, Tenlop from sv, lop where sv.Malop = lop.Malop";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            if(cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            //DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds;
            //label1.Text = ds.Tables[0].Rows.Count;
            cnn.Close();
        }
    }
}
