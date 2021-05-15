using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListView lv = new ListView();
            ImageList imgl = new ImageList();
            imgl.ImageSize = new Size(68, 68);

            //imgl.Images.Add(new Bitmap(Application.StartupPath + @"\Image\1.png"));

            for(int i = 0; i < 5; i++)
            {
                //ListViewItem li = new ListViewItem();
                lv.Items.Add(new ListViewItem() { ImageIndex = 0, Text = (i + 1).ToString() });
            }

            lv.LargeImageList = imgl;
            groupBox1.Controls.Add(lv);


        }
    }
}
