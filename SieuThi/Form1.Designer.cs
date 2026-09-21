namespace SieuThi
{
    partial class FormBanHang
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
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(148, 55);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(148, 115);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(148, 174);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 2;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 58);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 115);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Số Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 177);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Đơn giá";
            label3.Click += label3_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(148, 240);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(351, 240);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(94, 29);
            btnXoaTrang.TabIndex = 7;
            btnXoaTrang.Text = "Xóa trang";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.Dock = DockStyle.Bottom;
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(0, 346);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(800, 104);
            lstKetQua.TabIndex = 8;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaSP);
            KeyPreview = true;
            Name = "FormBanHang";
            Text = "FormBanHang";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
    }
}
