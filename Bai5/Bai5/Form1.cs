using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        private string[] array;

        public Form1()
        {
            InitializeComponent();
            rdtIncrease.Checked = true;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
           if(rdtIncrease.Checked == true)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    for(int j = array.Length - 1; j > i; j--)
                    {
                        if(int.Parse(array[i]) > int.Parse(array[j]))
                        {
                            string tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
                        
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = array.Length - 1; j > i; j--)
                    {
                        if (int.Parse(array[i]) < int.Parse(array[j]))
                        {
                            string tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }

                    }
                }
            }


            string s = "";
            for (int i = 0; i < array.Length; i++)
            {
                s = s + array[i] + " ";
            }
            textBoxKq.Text = s;
        }

        private void btnInputArray_Click(object sender, EventArgs e)
        {
            textBoxKq.Text = textBoxArray.Text;
            array = textBoxArray.Text.Split(' ');
        }
    }
}
