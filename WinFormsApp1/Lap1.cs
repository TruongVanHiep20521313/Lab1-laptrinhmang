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
    public partial class Lap1 : Form
    {
        public Lap1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 frm = new Bai1();  
            frm.ShowDialog();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 frm = new Bai2();  
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 frm = new Bai3();  
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4 frm = new Bai4();  
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5 frm = new Bai5();  
            frm.ShowDialog();
        }
    }
}
