using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int A = 1;
            for(int i = 1; i <=a; i++)
            {
                A = A * i;
            }
            label8.Text = A.ToString();

            int B  = 1;
            for (int i = 1; i <= b; i++)
            {
                B = B * i;
            }
            label9.Text = B.ToString();

            int S1 = 0;
            for (int i = 1; i <= a; i++)
            {
                S1 = S1 + i;
            }
            label10.Text = S1.ToString();

            int S2 = 0;
            for (int i = 1; i <= b; i++)
            {
                S2 = S2 + i;
            }
            label11.Text = S2.ToString();

            int S3 = 0;
            for (int i = 1; i <= b; i++)
            {
                S3 = S3 + luythua(A, i);
            }
            label12.Text = S3.ToString();


        }
        int luythua (int a, int b)
        {
            int s = 1;
            for(int i = 1; i <= b; i++)
            {
                s = s * a;
            }
            return s;

        }

       
    }
}
