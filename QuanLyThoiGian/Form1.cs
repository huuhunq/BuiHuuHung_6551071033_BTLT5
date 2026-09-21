namespace QuanLyThoiGian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text);
                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
        }

        private void đánhDấuHoànThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                string congViec = lstCongViec.SelectedItem.ToString();

                if (!congViec.StartsWith("[Hoàn thành] "))
                {
                    int viTri = lstCongViec.SelectedIndex;

                    lstCongViec.Items[viTri] = "[Hoàn thành] " + congViec;

                    lstCongViec.SelectedIndex = viTri;
                }
            }
        }

        private void xóaCôngViệcNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn một công việc trước khi xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void xóaTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa tất cả công việc không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}
