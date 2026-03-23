namespace _20._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imageList1;

            TreeNode goc = treeView1.Nodes.Add("Ký tự đặc biệt");
            goc.ImageIndex = 0; //dựa trên index của imagelist bắt đầu từ 0
            goc.SelectedImageIndex = 0;

            TreeNode nodeCong = goc.Nodes.Add("+");
            TreeNode nodeTru = goc.Nodes.Add("-");
            TreeNode nodeNhan = goc.Nodes.Add("*");
            TreeNode nodeChia = goc.Nodes.Add("/");

            nodeCong.ImageIndex = 4;
            nodeTru.ImageIndex = 4;
            nodeNhan.ImageIndex = 4;
            nodeChia.ImageIndex = 4;

            nodeCong.SelectedImageIndex = 5;
            nodeTru.SelectedImageIndex = 5;
            nodeNhan.SelectedImageIndex = 5;
            nodeChia.SelectedImageIndex = 5;

            TreeNode gockytu = treeView1.Nodes.Add("Ký tự");
            gockytu.ImageIndex = 1;
            gockytu.SelectedImageIndex = 1;

            for(char i = 'a'; i<='z'; i++)
            {
                TreeNode kt = gockytu.Nodes.Add(i.ToString());
                kt.ImageIndex = 4;
                kt.SelectedImageIndex = 5;
            }

            TreeNode gocdayso = treeView1.Nodes.Add("Dãy số");
            gocdayso.ImageIndex = 2;
            gocdayso.SelectedImageIndex = 2;

            for (int i = 0; i <= 9; i++)
            {
                TreeNode kt = gocdayso.Nodes.Add(i.ToString());
                kt.ImageIndex = 4;
                kt.SelectedImageIndex = 5;
            }
        }
    }
}
