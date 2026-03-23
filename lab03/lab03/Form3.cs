using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab03
{
    public partial class Form3 : Form
    {
        double so1 = 0, so2 = 0;
        double ketqua = 0;
        char pt = ' ';
        char error = 'E';
        public Form3()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtnhap.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtnhap.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtnhap.Text += "2";
        }

        private void btn3__Click(object sender, EventArgs e)
        {
            txtnhap.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtnhap.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtnhap.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtnhap.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtnhap.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtnhap.Text += "8";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtnhap.Text += "9";
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            pt = '+';
            so1 = double.Parse(txtnhap.Text);
            txtnhap.Text = "";
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            pt = '-';
            so1 = double.Parse(txtnhap.Text);
            txtnhap.Text = "";
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            pt = '*';
            so1 = double.Parse(txtnhap.Text);
            txtnhap.Text = "";
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            pt = '/';
            so1 = double.Parse(txtnhap.Text);
            txtnhap.Text = "";
        }

        public void Tinh(double n1, double n2, double n3)
        {
            switch(pt)
            {
                case '+':
                    ketqua = n1 + n2;
                    break;
                case '-':
                    ketqua = n1 - n2;
                    break;
                case '*':
                    ketqua = n1 * n2;
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        MessageBox.Show("Lỗi chia cho 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ketqua = 0;
                    }
                    else
                    {
                        ketqua = n1 / n2;
                    }
                    break;
                

            }
            txtnhap.Text = ketqua.ToString();
        }
        private void btnbang_Click(object sender, EventArgs e)
        {
            so2 = double.Parse(txtnhap.Text);
            Tinh(so1, so2, pt);
        }

        private void btncongtru_Click(object sender, EventArgs e)
        {
            so1 = double.Parse(txtnhap.Text);
            so1 *= -1;
            txtnhap.Text = so1.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtnhap.Text = "";
        }
    }
}
