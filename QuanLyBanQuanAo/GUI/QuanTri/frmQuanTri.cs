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
    public partial class frmQuanTri : Form
    {
        public frmQuanTri()
        {
            InitializeComponent();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmQuanLyLoaiSanPham().ShowDialog();
            this.Close();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new QuanTri.frmQuanLyNhanVien().ShowDialog();
            this.Close();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new QuanTri.frmThongKe().ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmDangNhap().ShowDialog();
            this.Close();
        }

        private void khuyếnMạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new QuanTri.frmQuanLyKhuyenMai().ShowDialog();
            this.Close();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new QuanTri.frmQuanLySanPham().ShowDialog();
            this.Close();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new QuanTri.frmTaoHoaDonNhap().ShowDialog();
            this.Close();
        }
    }
}
