namespace Gym_FitLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
        string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                string hoTen = txtHoTen.Text;
                string sdt = txtSDT.Text;
                string goiTap = cboGoiTap.Text;
                string soBuoiTuan = numSoBuoiTuan.Value.ToString();

                MessageBox.Show(
                    "THÔNG TIN ĐĂNG KÝ\n\n" +
                    "Họ tên: " + hoTen + "\n" +
                    "SĐT: " + sdt + "\n" +
                    "Gói tập: " + goiTap + "\n" +
                    "Số buổi/tuần: " + soBuoiTuan,
                    "Đăng ký thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
