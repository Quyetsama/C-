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

namespace QuanLi_SanPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-EBVUMV9\MSSQLSERVER01;Initial Catalog=QLSanPham;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            if(connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            string sql = "select * from Loai_SP, SP where Loai_SP.ma_loai_sp = SP.ma_loai";
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
}
