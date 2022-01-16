using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        private string tenDangNhap;

        public frmNhanVien(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            InitializeComponent();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmDangNhap().ShowDialog();
            Close();
        }

        private void TaoHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new NhanVien.frmTaoHoaDonBan(tenDangNhap).ShowDialog();
            Close();
        }

        private void XemThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmThongTinTaiKhoan(tenDangNhap).ShowDialog();
            Close();
        }

        private void lịchSửTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new QuanTri.frmXemThongTinHoaDonBan().ShowDialog();
            Close();
        }
    }
}
