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

namespace Demo_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EBVUMV9\MSSQLSERVER01;Initial Catalog=Demo_Login;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string getID()
        {
            string id = "";

            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from tbl_user where user_name = '" + txt_username.Text + "' and pass = '" + txt_pass.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id_user"].ToString();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public static string ID_User = "";

        private void button2_Click(object sender, EventArgs e)
        {
            ID_User = getID();
            if(ID_User != "")
            {
                frm_Main fmain = new frm_Main();
                fmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản mật khẩu không đúng!");
            }
        }
    }
}
