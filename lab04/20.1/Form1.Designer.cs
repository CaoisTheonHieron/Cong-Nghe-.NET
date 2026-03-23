namespace _20._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            toolStrip1 = new ToolStrip();
            tsbtn1 = new ToolStripButton();
            tsbtn2 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(31, 54);
            treeView1.Name = "treeView1";
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(197, 355);
            treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "0");
            imageList1.Images.SetKeyName(1, "1");
            imageList1.Images.SetKeyName(2, "2");
            imageList1.Images.SetKeyName(3, "3");
            imageList1.Images.SetKeyName(4, "5");
            imageList1.Images.SetKeyName(5, "4");
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtn1, tsbtn2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn1
            // 
            tsbtn1.Image = (Image)resources.GetObject("tsbtn1.Image");
            tsbtn1.ImageTransparentColor = Color.Magenta;
            tsbtn1.Name = "tsbtn1";
            tsbtn1.Size = new Size(90, 24);
            tsbtn1.Text = "Mở rộng";
            // 
            // tsbtn2
            // 
            tsbtn2.Image = (Image)resources.GetObject("tsbtn2.Image");
            tsbtn2.ImageTransparentColor = Color.Magenta;
            tsbtn2.Name = "tsbtn2";
            tsbtn2.Size = new Size(87, 24);
            tsbtn2.Text = "Thu gọn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtn1;
        private ToolStripButton tsbtn2;
        private ImageList imageList1;
    }
}
