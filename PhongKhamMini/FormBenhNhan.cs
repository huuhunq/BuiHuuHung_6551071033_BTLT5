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
    public partial class frmBenhNhan : Form
    {
        private List<string> danhSachBenhNhan = new List<string>();
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string trieuChung = txtTrieuChung.Text.Trim();
            int tuoi = (int)numTuoi.Value;

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên bệnh nhân.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string thongTin =
                "Họ tên: " + hoTen +
                " | Tuổi: " + tuoi +
                " | Triệu chứng: " + trieuChung;

            danhSachBenhNhan.Add(thongTin);

            lstBenhNhan.Items.Add(thongTin);

            txtHoTen.Clear();
            txtTrieuChung.Clear();
            numTuoi.Value = 0;

            txtHoTen.Focus();
        }
    }
}
