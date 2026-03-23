namespace lab03
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radbtnbscnn = new RadioButton();
            radbtnuscln = new RadioButton();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtb = new TextBox();
            txta = new TextBox();
            groupBox3 = new GroupBox();
            txtketqua = new TextBox();
            btntim = new Button();
            btnboqua = new Button();
            btnthoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Firebrick;
            groupBox1.Controls.Add(radbtnbscnn);
            groupBox1.Controls.Add(radbtnuscln);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(502, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn tìm";
            // 
            // radbtnbscnn
            // 
            radbtnbscnn.AutoSize = true;
            radbtnbscnn.BackColor = Color.FromArgb(255, 128, 128);
            radbtnbscnn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnbscnn.Location = new Point(27, 67);
            radbtnbscnn.Name = "radbtnbscnn";
            radbtnbscnn.Size = new Size(101, 32);
            radbtnbscnn.TabIndex = 1;
            radbtnbscnn.TabStop = true;
            radbtnbscnn.Text = "BSCNN";
            radbtnbscnn.UseVisualStyleBackColor = false;
            // 
            // radbtnuscln
            // 
            radbtnuscln.AutoSize = true;
            radbtnuscln.BackColor = Color.FromArgb(255, 128, 128);
            radbtnuscln.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radbtnuscln.Location = new Point(27, 29);
            radbtnuscln.Name = "radbtnuscln";
            radbtnuscln.Size = new Size(96, 32);
            radbtnuscln.TabIndex = 1;
            radbtnuscln.TabStop = true;
            radbtnuscln.Text = "USCLN";
            radbtnuscln.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Red;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtb);
            groupBox2.Controls.Add(txta);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(32, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(464, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label2.Location = new Point(33, 69);
            label2.Name = "label2";
            label2.Size = new Size(30, 28);
            label2.TabIndex = 3;
            label2.Text = "B:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 3;
            label1.Text = "A:";
            // 
            // txtb
            // 
            txtb.Location = new Point(93, 73);
            txtb.Name = "txtb";
            txtb.Size = new Size(347, 27);
            txtb.TabIndex = 0;
            txtb.TextAlign = HorizontalAlignment.Right;
            // 
            // txta
            // 
            txta.Location = new Point(93, 26);
            txta.Name = "txta";
            txta.Size = new Size(347, 27);
            txta.TabIndex = 0;
            txta.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 128, 0);
            groupBox3.Controls.Add(txtketqua);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(32, 177);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(658, 125);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kết quả";
            // 
            // txtketqua
            // 
            txtketqua.BackColor = Color.FromArgb(255, 224, 192);
            txtketqua.ForeColor = Color.FromArgb(192, 0, 0);
            txtketqua.Location = new Point(84, 52);
            txtketqua.Name = "txtketqua";
            txtketqua.Size = new Size(530, 27);
            txtketqua.TabIndex = 0;
            txtketqua.TextAlign = HorizontalAlignment.Right;
            // 
            // btntim
            // 
            btntim.BackColor = Color.Yellow;
            btntim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntim.Location = new Point(142, 325);
            btntim.Name = "btntim";
            btntim.Size = new Size(94, 55);
            btntim.TabIndex = 2;
            btntim.Text = "Tìm ";
            btntim.UseVisualStyleBackColor = false;
            btntim.Click += btntim_Click;
            // 
            // btnboqua
            // 
            btnboqua.BackColor = Color.Yellow;
            btnboqua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnboqua.Location = new Point(300, 325);
            btnboqua.Name = "btnboqua";
            btnboqua.Size = new Size(94, 55);
            btnboqua.TabIndex = 2;
            btnboqua.Text = "Bỏ qua";
            btnboqua.UseVisualStyleBackColor = false;
            btnboqua.Click += btnboqua_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Yellow;
            btnthoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(463, 325);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 55);
            btnthoat.TabIndex = 2;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(724, 412);
            Controls.Add(btnthoat);
            Controls.Add(btnboqua);
            Controls.Add(btntim);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton radbtnbscnn;
        private RadioButton radbtnuscln;
        private TextBox txtb;
        private TextBox txta;
        private TextBox txtketqua;
        private Button btntim;
        private Button btnboqua;
        private Button btnthoat;
        private Label label2;
        private Label label1;
    }
}