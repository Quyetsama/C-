using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_cafe
{
    public partial class QuanLyBanHang : UserControl
    {
        public QuanLyBanHang()
        {
            InitializeComponent();
        }


        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn(
        //    int nLeftRect, // x-coordinate of upper-left corner
        //    int nTopRect, // y-coordinate of upper-left corner
        //    int nRightRect, // x-coordinate of lower-right corner
        //    int nBottomRect, // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        //);




        private void QuanLyBanHang_Load(object sender, EventArgs e)
        {
            AddSanPham();
            styleDataGrid();
        }

        void AddSanPham()
        {
            dataGridViewSanPham.Rows.Add("SP1", "Cà phê", 15000);
            dataGridViewSanPham.Rows.Add("SP2", "Trà sữa", 20000);
            dataGridViewSanPham.Rows.Add("SP3", "Sữa chua", 10000);
            dataGridViewSanPham.Rows.Add("SP2", "Trà sữa", 20000);
            dataGridViewSanPham.Rows.Add("SP1", "Cà phê", 15000);
            dataGridViewSanPham.Rows.Add("SP2", "Trà sữa", 20000);
            dataGridViewSanPham.Rows.Add("SP3", "Sữa chua", 10000);
            dataGridViewSanPham.Rows.Add("SP2", "Trà sữa", 20000);
            dataGridViewSanPham.Rows.Add("SP1", "Cà phê", 15000);
            dataGridViewSanPham.Rows.Add("SP2", "Trà sữa", 20000);
            dataGridViewSanPham.Rows.Add("SP3", "Sữa chua", 10000);
            dataGridViewSanPham.Rows.Add("SP2", "Trà sữa", 20000);
            dataGridViewSanPham.Rows.Add("SP1", "Cà phê", 15000);
            dataGridViewSanPham.Rows.Add("SP2", "Trà sữa", 20000);
            dataGridViewSanPham.Rows.Add("SP3", "Sữa chua", 10000);
            dataGridViewSanPham.Rows.Add("SP2", "Trà sữa", 20000);
        }

        void styleDataGrid()
        {
            dataGridViewSanPham.BorderStyle = BorderStyle.None;
            dataGridViewSanPham.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewSanPham.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSanPham.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewSanPham.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dataGridViewSanPham.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewSanPham.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dataGridViewSanPham.AllowUserToResizeRows = false;

            //dataGridViewSanPham.Columns[0].Resizable = DataGridViewTriState.False;
            //dataGridViewSanPham.AllowUserToResizeColumns = false
            dataGridViewSanPham.EnableHeadersVisualStyles = false;
            dataGridViewSanPham.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //dataGridViewSanPham.BorderStyle = BorderStyle.None;
            //dataGridViewSanPham.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height - 10, 20, 20));


        }
    }
}
