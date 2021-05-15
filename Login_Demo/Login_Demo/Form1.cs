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

namespace Login_Demo
{
    public partial class Form1 : Form
    {

        string connectionString = @"Data Source=DESKTOP-EBVUMV9\MSSQLSERVER01;Initial Catalog=Login_Demo;Integrated Security=True";
        SqlDataAdapter da;
        SqlConnection conn;
        DataSet ds;
        public static string State = "";

        public Form1()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionString);
                string query = "select * from tb_taikhoan where userName = '" + txtTaiKhoan.Text.Trim() + "' and passWord = '" + txtMatKhau.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);

                if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DateTime ngayHetHan = Convert.ToDateTime(ds.Tables[0].Rows[0]["ngayHetHan"]);
                    DateTime ngayHieuLuc = Convert.ToDateTime(ds.Tables[0].Rows[0]["ngayHieuLuc"]);

                    if(ngayHieuLuc > DateTime.Now)
                    {
                        lblError.Text = "Tai khoan chua co hieu luc";
                    }
                    else if(ngayHetHan < DateTime.Now)
                    {
                        lblError.Text = "Tai khoan het han su dung";
                    }
                    else
                    {
                        Main fMain = new Main();
                        fMain.Show();
                        this.Hide();
                    }
                }
                else
                {
                    lblError.Text = "Tai khoan hoac mat khau chua chinh xac";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
