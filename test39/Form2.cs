using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test39
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            switch (domainUpDown1.Text)
            {
                case "第一张":
                    pictureBox1.Image = Resource1._1;
                    break;
                case "第二张":
                    pictureBox1.Image = Resource1._2;
                    break;
                case "第三张":
                    pictureBox1.Image = Resource1._3;
                    break;
                default:
                    break;
            }
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = hScrollBar1.Value;
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Height = vScrollBar1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                numericUpDown1.Value = 0;
                if (trackBar1.Value == 0)
                {
                    hScrollBar1.Value = 0;
                    vScrollBar1.Value = vScrollBar1.Maximum;
                }
                else
                {
                    vScrollBar1.Value = 0;
                    hScrollBar1.Value = hScrollBar1.Maximum;
                }
                timer1.Start();
            }
            else
            {
               timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                if(hScrollBar1.Value< hScrollBar1.Maximum)
                { 
                    hScrollBar1.Value += 1;
                    numericUpDown1.Value = hScrollBar1.Value;
                }
                else
                {
                    timer1.Stop();
                    checkBox1.Checked = false;
                }
            }
            else {
                if (vScrollBar1.Value < vScrollBar1.Maximum)
                { 
                    vScrollBar1.Value += 1;
                    numericUpDown1.Value = vScrollBar1.Value;
                }
                else {
                    timer1.Stop();
                    checkBox1.Checked = false;
                }
            }
        }
    }
}
