namespace SieuThi
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string donGia = txtDonGia.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSP) ||
                string.IsNullOrWhiteSpace(soLuong) ||
                string.IsNullOrWhiteSpace(donGia))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string dong = maSP + " | " + soLuong + " | " + donGia;

            lstKetQua.Items.Add(dong);
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            txtMaSP.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnXoaTrang.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn thoát?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
