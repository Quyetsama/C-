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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        string UID = Form1.ID_User;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EBVUMV9\MSSQLSERVER01;Initial Catalog=Demo_Login;Integrated Security=True");
        List<string> listper = null;

        private void frm_Main_Load(object sender, EventArgs e)
        {
            listper = List_per();
        }

        private Boolean CheckPer(string code)
        {
            Boolean check = false;
            foreach(string item in listper){
                if(item == code)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }

        private string id_per()
        {
            string id = "";
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from tbl_per_relationship where id_user_rel = '" + UID + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["suspended"].ToString() == "False")
                        {
                            id = dr["id_per_rel"].ToString();
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        private List<string> List_per()
        {
            string idper = id_per();
            List<string> termlist = new List<string>();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from tbl_permistion_detail where id_per = '" + idper + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        termlist.Add(dr["code_action"].ToString());
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }

            return termlist;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(CheckPer("ADD") == true)
            {
                MessageBox.Show("Có quyền thêm!");
            }
            else
            {
                MessageBox.Show("Không có quyền thêm!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckPer("EDIT") == true)
            {
                MessageBox.Show("Có quyền sửa!");
            }
            else
            {
                MessageBox.Show("Không có quyền sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckPer("DELETE") == true)
            {
                MessageBox.Show("Có quyền xóa!");
            }
            else
            {
                MessageBox.Show("Không có quyền xóa!");
            }
        }
    }
}
