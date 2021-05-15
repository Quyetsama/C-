using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_quán_cafe
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 285)
            {
                int newWidth = 80;
                panel1.MaximumSize = new Size(newWidth, panel1.Height);
                panel1.Size = new Size(newWidth, panel1.Height);

                button1.Location = new Point(16, 0);
            }
            else
            {
                int newWidth = 285;
                panel1.MaximumSize = new Size(newWidth, panel1.Height);
                panel1.Size = new Size(newWidth, panel1.Height);

                button1.Location = new Point(235, 0);
            }
        }

        private void quanLyBanHang1_Load(object sender, EventArgs e)
        {

        }
    }
}
