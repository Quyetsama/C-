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

namespace MaTuTang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetData();
        }

        string connectionString = @"Data Source=DESKTOP-EBVUMV9\MSSQLSERVER01;Initial Catalog=QLSinhVien;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection conn;
        DataSet ds;



        public void GetData()
        {
            conn = new SqlConnection(connectionString);
            string query = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            string query = @"
                            declare @ma_next varchar(21)
                            declare @max int
                            select @max = COUNT(MaSV) + 1 from SinhVien where MaSV like 'SV'
                            set @ma_next = 'SV' + RIGHT('0' + CAST(@max as varchar(18)), 18)
                            while (exists(select MaSV from SinhVien where MaSV = @ma_next))

                            begin
                                set @max = @max + 1
                                set @ma_next = 'SV' + RIGHT('0' + CAST(@max as varchar(18)), 18)
                            end

                            insert into SinhVien values(@ma_next, N'" + textBox1.Text +"')";


            SqlCommand cmd = new SqlCommand(query, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Thanh cong");
            }
            else
            {
                MessageBox.Show("Loi");
            }
            GetData();
        }
    }
}
