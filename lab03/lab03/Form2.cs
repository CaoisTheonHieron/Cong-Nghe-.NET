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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private int timUSCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }

        private int timBSCNN(int a, int b)
        {
            return (a * b) / timUSCLN(a, b);
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            if (radbtnuscln.Checked)
            {
                txtketqua.Text = timUSCLN(a, b).ToString();
            }
            else if (radbtnbscnn.Checked)
            {
                txtketqua.Text = timBSCNN(a, b).ToString();
            }
        }
        

        private void btnboqua_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txtketqua.Text = "";
            radbtnuscln.Checked = false;
            radbtnbscnn.Checked = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
