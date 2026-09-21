namespace PhongKhamMini
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void thôngTinBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBenhNhan frm = new frmBenhNhan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đặtLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichHen frm = new frmLichHen();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
