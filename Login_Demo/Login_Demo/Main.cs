using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Demo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void quanLyBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QlyBH fqlybh = new QlyBH();
        }
    }
}
