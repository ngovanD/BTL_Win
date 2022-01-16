using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.QuanTri
{
    public partial class frmXemThongTinHoaDonBan : Form
    {
        string tenDangNhap;
        public frmXemThongTinHoaDonBan()
        {
            InitializeComponent();
        }

        public frmXemThongTinHoaDonBan(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            InitializeComponent();
        }

        private void frmXemThongTinHoaDonBan_Load(object sender, EventArgs e)
        {
            HoaDonBLL.Instance.HienThiDanhSachHoaDonBan(dgvHoaDon,lblTongHoaDon, lblTongTien, null, 0);
        }

        private void cbxLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxLoaiTK.SelectedIndex)
            {
                case 0:
                    //Hiện tất cả
                    hienHopTimKiem(false, false, false, false, false, false);
                    HoaDonBLL.Instance.HienThiDanhSachHoaDonBan(dgvHoaDon, lblTongHoaDon, lblTongTien, null, 0);
                    break;
                case 1:
                    //Mã hóa đơn
                    hienHopTimKiem(true, false, true, false, false, false);
                    lblTieuDeTK.Text = "Chọn mã hóa đơn:";
                    txtMaHD.Text = "";
                    break;
                case 2:
                    //Mã nhân viên
                    hienHopTimKiem(true, false, false, true, false, false);
                    lblTieuDeTK.Text = "Chọn mã NV:";
                    HoaDonBLL.Instance.HienThiMaNV(cbxMaNhanVien);
                    break;
                case 3:
                    //Ngày xuất
                    hienHopTimKiem(true, true, false, false, true, false);
                    lblTieuDeTK.Text = "Từ ngày:";
                    lblTieuDeTK2.Text = "Đến ngày:";
                    dtpBatDau.Value = DateTime.Now;
                    dtpKetThuc.Value = DateTime.Now;
                    break;
                case 4:
                    //Tổng số tiền
                    hienHopTimKiem(true, true, false, false, false, true);
                    lblTieuDeTK.Text = "Số tiền từ:";
                    lblTieuDeTK2.Text = "Đến:";
                    txtBatDau.Text = "";
                    txtKetThuc.Text = "";
                    break;
            }
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            List<object> tuKhoa = new List<object>();
            tuKhoa.Add(txtMaHD.Text);
            HoaDonBLL.Instance.HienThiDanhSachHoaDonBan(dgvHoaDon, lblTongHoaDon, lblTongTien, tuKhoa, 1);
        }

        private void cbxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idTK = cbxMaNhanVien.SelectedValue;
            if (idTK is DTO.NhanVien) { }
            else
            {
                List<object> tuKhoa = new List<object>();
                tuKhoa.Add(idTK);
                HoaDonBLL.Instance.HienThiDanhSachHoaDonBan(dgvHoaDon, lblTongHoaDon, lblTongTien, tuKhoa, 2);
            }
        }


        private void thoiGian_ValueChanged(object sender, EventArgs e)
        {
            DateTime bd = DateTime.Parse(dtpBatDau.Value.ToString("dd/MM/yyyy"));
            DateTime kt = DateTime.Parse(dtpKetThuc.Value.ToString("dd/MM/yyyy") + " 23:59:59");
            if (kt >= bd)
            {
                List<object> tuKhoa = new List<object>();
                tuKhoa.Add(bd);
                tuKhoa.Add(kt);
                HoaDonBLL.Instance.HienThiDanhSachHoaDonBan(dgvHoaDon, lblTongHoaDon, lblTongTien, tuKhoa, 3);
            }
        }

        private void tongTien_TextChanged(object sender, EventArgs e)
        {
            if(isNotNull(txtBatDau.Text) && isNotNull(txtKetThuc.Text))
            {
                int tienBd = Convert.ToInt32(txtBatDau.Text);
                int tienKt = Convert.ToInt32(txtKetThuc.Text);
                if (tienKt >= tienBd)
                {
                    List<object> tuKhoa = new List<object>();
                    tuKhoa.Add(tienBd);
                    tuKhoa.Add(tienKt);
                    HoaDonBLL.Instance.HienThiDanhSachHoaDonBan(dgvHoaDon, lblTongHoaDon, lblTongTien, tuKhoa, 4);
                }
            }
        }

        private void tongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            var maHD = dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();
            new NhanVien.frmInHoaDonBan(maHD, 0, false, tenDangNhap).ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Hide();
            new frmNhanVien(tenDangNhap).ShowDialog();
            Close();
        }

        private void hienHopTimKiem(bool tieuDeTk, bool tieuDeTk2, bool tuKhoa, bool cbx, bool dtp, bool txt)
        {
            lblTieuDeTK.Visible = tieuDeTk;
            lblTieuDeTK2.Visible = tieuDeTk2;
            txtMaHD.Visible = tuKhoa;
            dtpBatDau.Visible = dtp;
            dtpKetThuc.Visible = dtp;
            txtBatDau.Visible = txt;
            txtKetThuc.Visible = txt;
            cbxMaNhanVien.Visible = cbx;
        }

        private bool isNotNull(string txt)
        {
            if(txt == null || txt.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
