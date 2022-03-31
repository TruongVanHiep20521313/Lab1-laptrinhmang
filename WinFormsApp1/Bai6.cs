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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

       
        public void kiemtranhap(string diem)
        {
            string[] diem2 = diem.Split(',');
            double[] d = new double[diem2.Length];
            int i = 0;
            foreach (string s in diem2)
            {
                try
                {
                    d[i] = double.Parse(s);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng!", "", MessageBoxButtons.OK);
                    textBox1.Text = "";
                    return;
                }
                i++;
            }
            MessageBox.Show("Bạn đã nhập đúng định dạng!", "", MessageBoxButtons.OK);

        }
      
        double DTB()
        {
            string diem = textBox1.Text;
            string[] diem2 = diem.Split(',');
            double[] d = new double[diem2.Length];
            int i = 0;
            foreach (string s in diem2)
            {
                try
                {
                    d[i] = double.Parse(s);
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                i++;
            }
            double x = 0, p = 0;
            foreach (double a in d)
            {
                if (x > 0)
                    p = p * x;
                p = p + a;
                x++;
                p = p / x;
            }
            return p;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = label2.Text = label3.Text = label4.Text = label5.Text = label6.Text = label7.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string diem = textBox1.Text;
            kiemtranhap(diem);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label2.Text = "";
            string diem = textBox1.Text;
            string[] diem2 = diem.Split(',');
            double[] d = new double[diem2.Length];
            int i = 0, a = 1;
            foreach (string s in diem2)
            {
                try
                {
                    d[i] = double.Parse(s);
                    if (a > 7)
                    {
                        label2.Text += "Môn" + (i + 1).ToString() + ": " + d[i].ToString() + "\n";
                        a = 1;
                    }
                    else
                        label2.Text += "Môn" + (i + 1).ToString() + ": " + d[i].ToString() + "          ";
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                i++; a++;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string diem = textBox1.Text;
            string[] diem2 = diem.Split(',');
            double[] d = new double[diem2.Length];
            int i = 0;
            foreach (string s in diem2)
            {
                try
                {
                    d[i] = double.Parse(s);
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                i++;
            }
            double x = 0, p = 0;
            foreach (double a in d)
            {
                if (x > 0)
                    p = p * x;
                p = p + a;
                x++;
                p = p / x;
            }
            label3.Text = "Điểm trung bình = " + p.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string diem = textBox1.Text;
            string[] diem2 = diem.Split(',');
            double[] d = new double[diem2.Length];
            int i = 0;
            double max = 0, maxi = 0, min = 10, mini = 0;
            foreach (string s in diem2)
            {
                try
                {
                    d[i] = double.Parse(s);
                    if (max <= d[i])
                    {
                        max = d[i];
                        maxi = i;
                    }
                    if (min >= d[i])
                    {
                        min = d[i];
                        mini = i;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                i++;
            }
            label4.Text = "Môn có điểm cao nhất là: Môn" + (maxi + 1).ToString() + " (" + max.ToString() + ")";
            label5.Text = "Môn có điểm thấp nhất là: Môn" + (mini + 1).ToString() + " (" + min.ToString() + ")";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string diem = textBox1.Text;
            string[] diem2 = diem.Split(',');
            double[] d = new double[diem2.Length];
            int i = 0;
            double sodau = 0;
            foreach (string s in diem2)
            {
                try
                {
                    d[i] = double.Parse(s);

                    if (d[i] >= 5)
                    {
                        sodau++;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                i++;
            }
            label6.Text = "Số môn đậu/không đậu là: " + sodau.ToString() + "/" + (i - sodau).ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string diem = textBox1.Text;
            string[] diem2 = diem.Split(',');
            double[] d = new double[diem2.Length];
            int i = 0;
            int hocluc = 1;
            double dtb = DTB();
            foreach (string s in diem2)
            {
                try
                {
                    d[i] = double.Parse(s);

                    if (d[i] < 6.5)
                    {
                        if (hocluc < 2)
                            hocluc = 2;
                        //tien tien
                    }
                    if (d[i] < 5)
                    {
                        if (hocluc < 3)
                            hocluc = 3;
                        //tb
                    }
                    if (d[i] < 3.5)
                    {
                        if (hocluc < 4)
                            hocluc = 4;
                        //yeu
                    }
                    if (d[i] < 2)
                    {
                        if (hocluc < 5)
                            hocluc = 5;
                        //kem
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                i++;
            }
            if (dtb >= 8 && hocluc == 1)
            {
                label7.Text = "Sinh viên loại: Giỏi";
                return;
            }

            if (dtb >= 6.5 && hocluc <= 2)
            {
                label7.Text = "Sinh viên loại: Khá";
                return;
            }
            if (dtb >= 5 && hocluc < 4)
            {
                label7.Text = "Sinh viên loại: TB";
                return;
            }
            if (dtb >= 3.5 && hocluc < 5)
            {
                label7.Text = "Sinh viên loại: Yếu";
                return;
            }
            if (dtb < 3.5 || hocluc == 5)
            {
                label7.Text = "Sinh viên loại: Kém";
                return;
            }
        }

        private void Bai6_Load_1(object sender, EventArgs e)
        {
            label2.Text = label3.Text = label4.Text = label5.Text = label6.Text = label7.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
