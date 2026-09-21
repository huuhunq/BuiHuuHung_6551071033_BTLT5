namespace PhongKhamMini
{
    partial class frmLichHen
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
            dtpNgayGioHen = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtTenBenhNhan = new TextBox();
            btnDatLich = new Button();
            lstLichHen = new ListBox();
            SuspendLayout();
            // 
            // dtpNgayGioHen
            // 
            dtpNgayGioHen.Location = new Point(205, 158);
            dtpNgayGioHen.Name = "dtpNgayGioHen";
            dtpNgayGioHen.Size = new Size(250, 27);
            dtpNgayGioHen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 163);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Lịch Hẹn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 99);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Bệnh Nhân:";
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(205, 99);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(250, 27);
            txtTenBenhNhan.TabIndex = 3;
            // 
            // btnDatLich
            // 
            btnDatLich.Location = new Point(246, 290);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(94, 29);
            btnDatLich.TabIndex = 4;
            btnDatLich.Text = "Đặt lịch";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // lstLichHen
            // 
            lstLichHen.Dock = DockStyle.Bottom;
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(0, 346);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(800, 104);
            lstLichHen.TabIndex = 5;
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstLichHen);
            Controls.Add(btnDatLich);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpNgayGioHen);
            Name = "frmLichHen";
            Text = "FormLichHen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgayGioHen;
        private Label label1;
        private Label label2;
        private TextBox txtTenBenhNhan;
        private Button btnDatLich;
        private ListBox lstLichHen;
    }
}