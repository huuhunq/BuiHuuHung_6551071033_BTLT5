namespace PhongKhamMini
{
    partial class frmParent
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
            menuStrip1 = new MenuStrip();
            nghiệpVụToolStripMenuItem = new ToolStripMenuItem();
            thôngTinBệnhNhânToolStripMenuItem = new ToolStripMenuItem();
            datLichHen = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nghiệpVụToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = cửaSổToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinBệnhNhânToolStripMenuItem, datLichHen });
            nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            nghiệpVụToolStripMenuItem.Size = new Size(93, 24);
            nghiệpVụToolStripMenuItem.Text = "Nghiệp Vụ";
            // 
            // thôngTinBệnhNhânToolStripMenuItem
            // 
            thôngTinBệnhNhânToolStripMenuItem.Name = "thôngTinBệnhNhânToolStripMenuItem";
            thôngTinBệnhNhânToolStripMenuItem.Size = new Size(228, 26);
            thôngTinBệnhNhânToolStripMenuItem.Text = "Thông tin bệnh nhân";
            thôngTinBệnhNhânToolStripMenuItem.Click += thôngTinBệnhNhânToolStripMenuItem_Click;
            // 
            // datLichHen
            // 
            datLichHen.Name = "datLichHen";
            datLichHen.Size = new Size(228, 26);
            datLichHen.Text = "Đặt lịch hẹn";
            datLichHen.Click += đặtLịchHẹnToolStripMenuItem_Click;
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(68, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmParent";
            Text = "Quản lý phòng khám";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem thôngTinBệnhNhânToolStripMenuItem;
        private ToolStripMenuItem datLichHen;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
    }
}
