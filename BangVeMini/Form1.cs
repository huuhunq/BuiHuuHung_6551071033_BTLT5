using System;

namespace BangVeMini
{
    public partial class Form1 : Form
    {
        private bool dangVe = false;
        private Point diemCuoi;
        private Bitmap bitmapVe;
        private Graphics graphicsVe;
        public Form1()
        {
            InitializeComponent();
            bitmapVe = new Bitmap(pnlCanvas.Width, pnlCanvas.Height);

            // Tạo Graphics để vẽ lên Bitmap
            graphicsVe = Graphics.FromImage(bitmapVe);

            // Nền trắng
            graphicsVe.Clear(Color.White);

            // Đưa Bitmap lên Panel
            pnlCanvas.BackgroundImage = bitmapVe;

            // Hiển thị trạng thái ban đầu
            lblViTri.Text = "X: 0, Y: 0 - Sẵn sàng";
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = true;

              
                diemCuoi = e.Location;

                lblViTri.Text =
                    $"X: {e.X}, Y: {e.Y} - Đang vẽ...";
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblViTri.Text =
        $"X: {e.X}, Y: {e.Y}" +
        (dangVe ? " - Đang vẽ..." : " - Sẵn sàng");

            // Nếu đang giữ chuột trái thì vẽ
            if (dangVe && e.Button == MouseButtons.Left)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                    graphicsVe.DrawLine(
                        pen,
                        diemCuoi,
                        e.Location
                    );
                }

                
                diemCuoi = e.Location;

                
                pnlCanvas.Invalidate();
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = false;

                lblViTri.Text =
                    $"X: {e.X}, Y: {e.Y} - Sẵn sàng";
            }
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               
                graphicsVe.Clear(Color.White);

                
                pnlCanvas.Invalidate();

          
                lblViTri.Text =
                    $"X: {e.X}, Y: {e.Y} - Sẵn sàng";
            }
        }

        private void lblViTri_Click(object sender, EventArgs e)
        {

        }
    }
}
