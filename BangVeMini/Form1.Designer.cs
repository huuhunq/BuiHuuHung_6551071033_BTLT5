namespace BangVeMini
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
            pnlCanvas = new Panel();
            lblViTri = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = Color.White;
            pnlCanvas.BackgroundImageLayout = ImageLayout.None;
            pnlCanvas.Location = new Point(-1, 70);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(645, 323);
            pnlCanvas.TabIndex = 0;
            pnlCanvas.Paint += pnlCanvas_Paint;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.BackColor = Color.White;
            lblViTri.Location = new Point(335, 21);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(21, 20);
            lblViTri.TabIndex = 1;
            lblViTri.Text = "   ";
            lblViTri.Click += lblViTri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(190, 21);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Tọa độ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblViTri);
            Controls.Add(pnlCanvas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCanvas;
        private Label lblViTri;
        private Label label1;
    }
}
