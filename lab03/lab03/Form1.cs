namespace lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtson.Text);
            int m = int.Parse(txtsom.Text);
            int Tong = n + m;
            txtketqua.Text = Tong.ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtson.Text);
            int m = int.Parse(txtsom.Text);
            int Hieu = n - m;
            txtketqua.Text = Hieu.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtson.Text);
            int m = int.Parse(txtsom.Text);
            int Tich = n * m;
            txtketqua.Text = Tich.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtson.Text);
            double m = double.Parse(txtsom.Text);
            if (m == 0)
            {
                txtketqua.Text = "Loi chia cho 0";
            }
            else
            {
                double Thuong = n / m;
                txtketqua.Text = Thuong.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtketqua.Clear();
            txtson.Clear();
            txtsom.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
