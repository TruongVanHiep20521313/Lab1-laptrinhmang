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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "";
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = a + b;
                textBox3.Text = c.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Vui lòng nhập số nguyên"); 
            }
        }
    }
}
