using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                if (progressBar1.Value <30) {
                    label1.Text = progressBar1.Value.ToString() + "%，程序载入中。。。";
                } else if (progressBar1.Value < 70)
                {
                    label1.Text = progressBar1.Value.ToString() + "%，正在载入图片。。。";
                } else if (progressBar1.Value <= 100)
                {
                    label1.Text = progressBar1.Value.ToString() + "%，即将完成。。。";
                }
            }
            else { 
                timer1.Stop();
                new Thread(() =>
                {
                    Form frm2 = new Form2();
                    frm2.ShowDialog();
                }).Start();
               Close();
            }
        }
    }
}
