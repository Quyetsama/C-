using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeDemo
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
            panelSide.Height = btnTrangChu.Height;
            panelSide.Top = btnTrangChu.Top;
            homeSide.BringToFront();


            this.Text = string.Empty;
            this.ControlBox = false;
        }

        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        string UID = Login.ID_User;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EBVUMV9\MSSQLSERVER01;Initial Catalog=Demo_Login;Integrated Security=True");
        List<string> listper = null;

        private void Main_Load(object sender, EventArgs e)
        {
            listper = List_per();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private Boolean CheckPer(string code)
        {
            Boolean check = false;
            foreach (string item in listper)
            {
                if (item == code)
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
                if (con.State == ConnectionState.Closed)
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
            catch (Exception e)
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
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }

            return termlist;
        }




        


        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnTrangChu.Height;
            panelSide.Top = btnTrangChu.Top;
            homeSide.BringToFront();

        }

        private void btnQlbh_Click(object sender, EventArgs e)
        {
            //panelSide.Height = btnQlbh.Height;
            //panelSide.Top = btnQlbh.Top;
            //qlbhSide.BringToFront();

            if (CheckPer("QLBH") == true)
            {
                panelSide.Height = btnQlbh.Height;
                panelSide.Top = btnQlbh.Top;
                qlbhSide.BringToFront();
            }
            else
            {
                MessageBox.Show("Không có quyền!");
            }

        }



        private void btnQlmh_Click(object sender, EventArgs e)
        {
            //panelSide.Height = btnQlmh.Height;
            //panelSide.Top = btnQlmh.Top;
            //qlmhSide.BringToFront();

            if (CheckPer("QLMH") == true)
            {
                panelSide.Height = btnQlmh.Height;
                panelSide.Top = btnQlmh.Top;
                qlmhSide.BringToFront();
            }
            else
            {
                MessageBox.Show("Không có quyền!");
            }
        }

        private void btnQltk_Click(object sender, EventArgs e)
        {
            //panelSide.Height = btnQltk.Height;
            //panelSide.Top = btnQltk.Top;
            //qltkSide.BringToFront();

            if (CheckPer("QLTK") == true)
            {
                panelSide.Height = btnQltk.Height;
                panelSide.Top = btnQltk.Top;
                qltkSide.BringToFront();
            }
            else
            {
                MessageBox.Show("Không có quyền!");
            }
        }

        private void btnKmtv_Click(object sender, EventArgs e)
        {
            //panelSide.Height = btnKmtv.Height;
            //panelSide.Top = btnKmtv.Top;
            //kmtvSide.BringToFront();

            if (CheckPer("KMTV") == true)
            {
                panelSide.Height = btnKmtv.Height;
                panelSide.Top = btnKmtv.Top;
                kmtvSide.BringToFront();
            }
            else
            {
                MessageBox.Show("Không có quyền!");
            }
        }

        private void btnTct_Click(object sender, EventArgs e)
        {
            //panelSide.Height = btnTct.Height;
            //panelSide.Top = btnTct.Top;
            //tctSide.BringToFront();

            if (CheckPer("TCT") == true)
            {
                panelSide.Height = btnTct.Height;
                panelSide.Top = btnTct.Top;
                tctSide.BringToFront();
            }
            else
            {
                MessageBox.Show("Không có quyền!");
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            //DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát !", "Thoát", MessageBoxButtons.YesNo);
            //if(dialog == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            dialogShutDown dialog = new dialogShutDown();
            dialog.ShowDialog();
        }

        private void panelToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
