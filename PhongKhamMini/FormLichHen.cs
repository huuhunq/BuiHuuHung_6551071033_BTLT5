using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKhamMini
{
    public partial class frmLichHen : Form
    {
        private List<string> danhSachLichHen = new List<string>();
        public frmLichHen()
        {
            InitializeComponent();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            string tenBenhNhan = txtTenBenhNhan.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenBenhNhan))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên bệnh nhân.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string lichHen =
                dtpNgayGioHen.Value.ToString("dd/MM/yyyy HH:mm") +
                " - " +
                tenBenhNhan;

            danhSachLichHen.Add(lichHen);

            lstLichHen.Items.Add(lichHen);

            txtTenBenhNhan.Clear();
            txtTenBenhNhan.Focus();
        }
    }
}
