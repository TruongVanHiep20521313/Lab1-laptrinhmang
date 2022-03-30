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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex;
            double b = double.Parse(textBox1.Text);
            double c;
            switch (a)
            {
                case 0:
                    c = b*22.772;
                    textBox2.Text = c.ToString() + "    VND";
                    label5.Text = "1 USD = 22.775 VND";
                    break;
                case 1:
                    c = b * 28.132;
                    textBox2.Text = c.ToString() + "    VND";
                    label5.Text = "1 EUR = 28.132 VND";
                    break;
                case 2:
                    c = b * 31.538;
                    textBox2.Text = c.ToString() + "    VND";
                    label5.Text = "1 GBP = 31.538 VND";
                    break;
                case 3:
                    c = b * 17.286;
                    textBox2.Text = c.ToString() + "    VND";
                    label5.Text = "1 SGD = 17.286 VND";
                    break;
                case 4:
                    c = b * 214;
                    textBox2.Text = c.ToString() + "    VND";
                    label5.Text = "1 JPY = 214 VND";
                    break;  
            }
        }
    }       
}
