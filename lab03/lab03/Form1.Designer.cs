namespace lab03
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
            lblthuchien = new Label();
            lblson = new Label();
            lblsom = new Label();
            lblketqua = new Label();
            txtson = new TextBox();
            txtsom = new TextBox();
            txtketqua = new TextBox();
            btncong = new Button();
            btntru = new Button();
            btnnhan = new Button();
            btnchia = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // lblthuchien
            // 
            lblthuchien.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblthuchien.ForeColor = Color.Red;
            lblthuchien.Location = new Point(88, 20);
            lblthuchien.Name = "lblthuchien";
            lblthuchien.Size = new Size(662, 67);
            lblthuchien.TabIndex = 0;
            lblthuchien.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // lblson
            // 
            lblson.AutoSize = true;
            lblson.Font = new Font("Segoe UI", 16.2F);
            lblson.Location = new Point(52, 125);
            lblson.Name = "lblson";
            lblson.Size = new Size(72, 38);
            lblson.TabIndex = 1;
            lblson.Text = "Số n";
            // 
            // lblsom
            // 
            lblsom.AutoSize = true;
            lblsom.Font = new Font("Segoe UI", 16.2F);
            lblsom.Location = new Point(52, 184);
            lblsom.Name = "lblsom";
            lblsom.Size = new Size(80, 38);
            lblsom.TabIndex = 2;
            lblsom.Text = "Số m";
            // 
            // lblketqua
            // 
            lblketqua.AutoSize = true;
            lblketqua.Font = new Font("Segoe UI", 16.2F);
            lblketqua.Location = new Point(52, 246);
            lblketqua.Name = "lblketqua";
            lblketqua.Size = new Size(111, 38);
            lblketqua.TabIndex = 3;
            lblketqua.Text = "Kết quả";
            // 
            // txtson
            // 
            txtson.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtson.Location = new Point(186, 125);
            txtson.Name = "txtson";
            txtson.Size = new Size(555, 43);
            txtson.TabIndex = 4;
            txtson.TextAlign = HorizontalAlignment.Right;
            // 
            // txtsom
            // 
            txtsom.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsom.Location = new Point(186, 184);
            txtsom.Name = "txtsom";
            txtsom.Size = new Size(555, 43);
            txtsom.TabIndex = 5;
            txtsom.TextAlign = HorizontalAlignment.Right;
            // 
            // txtketqua
            // 
            txtketqua.BackColor = Color.FromArgb(255, 192, 192);
            txtketqua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtketqua.Location = new Point(186, 246);
            txtketqua.Name = "txtketqua";
            txtketqua.ReadOnly = true;
            txtketqua.Size = new Size(555, 43);
            txtketqua.TabIndex = 6;
            txtketqua.TextAlign = HorizontalAlignment.Right;
            // 
            // btncong
            // 
            btncong.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncong.Location = new Point(61, 319);
            btncong.Name = "btncong";
            btncong.Size = new Size(92, 49);
            btncong.TabIndex = 8;
            btncong.Text = "+";
            btncong.UseVisualStyleBackColor = true;
            btncong.Click += btncong_Click;
            // 
            // btntru
            // 
            btntru.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntru.Location = new Point(173, 319);
            btntru.Name = "btntru";
            btntru.Size = new Size(92, 49);
            btntru.TabIndex = 8;
            btntru.Text = "-";
            btntru.UseVisualStyleBackColor = true;
            btntru.Click += btntru_Click;
            // 
            // btnnhan
            // 
            btnnhan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnhan.Location = new Point(289, 319);
            btnnhan.Name = "btnnhan";
            btnnhan.Size = new Size(92, 49);
            btnnhan.TabIndex = 8;
            btnnhan.Text = "x";
            btnnhan.UseVisualStyleBackColor = true;
            btnnhan.Click += btnnhan_Click;
            // 
            // btnchia
            // 
            btnchia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnchia.Location = new Point(409, 319);
            btnchia.Name = "btnchia";
            btnchia.Size = new Size(92, 49);
            btnchia.TabIndex = 8;
            btnchia.Text = "/";
            btnchia.UseVisualStyleBackColor = true;
            btnchia.Click += btnchia_Click;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnxoa.Location = new Point(527, 319);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(92, 49);
            btnxoa.TabIndex = 8;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(649, 319);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(92, 49);
            btnthoat.TabIndex = 8;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 416);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnchia);
            Controls.Add(btnnhan);
            Controls.Add(btntru);
            Controls.Add(btncong);
            Controls.Add(txtketqua);
            Controls.Add(txtsom);
            Controls.Add(txtson);
            Controls.Add(lblketqua);
            Controls.Add(lblsom);
            Controls.Add(lblson);
            Controls.Add(lblthuchien);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblthuchien;
        private Label lblson;
        private Label lblsom;
        private Label lblketqua;
        private TextBox txtson;
        private TextBox txtsom;
        private TextBox txtketqua;
        private Button btncong;
        private Button btntru;
        private Button btnnhan;
        private Button btnchia;
        private Button btnxoa;
        private Button btnthoat;
    }
}
