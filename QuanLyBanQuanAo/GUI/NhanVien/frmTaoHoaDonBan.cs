using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.NhanVien
{
    public partial class frmTaoHoaDonBan : Form
    {
        string tenDangNhap;
        public frmTaoHoaDonBan()
        {
            InitializeComponent();
        }
        public frmTaoHoaDonBan(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            InitializeComponent();
        }


        private void frmTaoHoaDonBan_Load(object sender, EventArgs e)
        {
            lblMaHoaDon.Text = HoaDonBLL.Instance.TaoMaHoaDon(true);
            HoaDonBLL.Instance.TaoDSLoaiSP(cbxLocLoaiSP);
            HoaDonBLL.Instance.HienThiNhanVien(lblNhanVien, tenDangNhap);
            HoaDonBLL.Instance.HienThiSanPham(dgvDanhSachSanPham, null, 0);
            HienThiMacDinh();
            CapNhatTienHang();
        }

        private void HienThiMacDinh()
        {
            lblMaSP.Text = "";
            lblTenSP.Text = "";
            lblLoaiSP.Text = "";
            lblDonGia.Text = "";
            nudSoLuong.Value = 1;
            cbxSize.DataSource = null;
            nudSoLuong.Enabled = false;
            cbxSize.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void tmrHienThiThoiGian_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void dgvDanhSachSanPham_SelectionChanged(object sender, EventArgs e)
        {
            var maSP = Convert.ToInt32(dgvDanhSachSanPham.CurrentRow.Cells["MaSanPham"].Value);

            SanPham sp = SanPhamBLL.Instance.LayTheoMa(maSP);

            if (sp != null)
            {
                lblMaSP.Text = sp.MaSanPham.ToString();
                lblTenSP.Text = sp.TenSanPham;
                lblLoaiSP.Text = sp.LoaiSanPham.TenLoaiSanPham;
                lblDonGia.Text = string.Format("{0:#,### đ}", sp.DonGiaBan);
                HoaDonBLL.Instance.HienThiKichThuc(sp.ChiTietSanPhams.ToList(), cbxSize);
            }

            nudSoLuong.Enabled = true;
            cbxSize.Enabled = true;
            btnThem.Enabled = true;
            dgvChiTietHoaDon.ClearSelection();
        }

        private void dgvChiTietSanPham_SelectionChanged(object sender, EventArgs e)
        {
            var maSP = Convert.ToInt32(dgvChiTietHoaDon.CurrentRow.Cells["MaSP"].Value);
            var idKichThuc = Convert.ToInt32(dgvChiTietHoaDon.CurrentRow.Cells["ID_KichThuoc"].Value);

            DongHoaDon ctsp = HoaDonBLL.Instance.LayChiTietHDTheoMaSPVaKichThuoc(maSP, idKichThuc);

            if (ctsp != null)
            {
                lblMaSP.Text = ctsp.MaSanPham.ToString();
                lblTenSP.Text = ctsp.SanPham.TenSanPham;
                lblLoaiSP.Text = ctsp.SanPham.LoaiSanPham.TenLoaiSanPham;
                lblDonGia.Text = string.Format("{0:#,### đ}", ctsp.SanPham.DonGiaBan);
                HoaDonBLL.Instance.HienThiKichThuc(ctsp.SanPham.ChiTietSanPhams.ToList(), cbxSize);
                cbxSize.SelectedValue = ctsp.ID_KichThuoc;
                nudSoLuong.Value = Convert.ToInt32(ctsp.SoLuong);
            }

            nudSoLuong.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvDanhSachSanPham.ClearSelection();
        }

        private void cbxLocLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

            var loaiSP = cbxLocLoaiSP.SelectedValue;
            if (loaiSP is LoaiSanPham) { }
            else
            {
                HoaDonBLL.Instance.HienThiSanPham(dgvDanhSachSanPham, txtTimTenSP.Text, (int)loaiSP);
            }
        }

        private void txtTimTenSP_TextChanged(object sender, EventArgs e)
        {
            HoaDonBLL.Instance.HienThiSanPham(dgvDanhSachSanPham, txtTimTenSP.Text, (int)cbxLocLoaiSP.SelectedValue);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDonBLL.Instance.CapNhatChiTietHoaDon(dgvChiTietHoaDon, Convert.ToInt32(lblMaSP.Text), Convert.ToInt32(cbxSize.SelectedValue), Convert.ToInt32(nudSoLuong.Value), 0);
            CapNhatTienHang();
            dgvDanhSachSanPham.ClearSelection();
            HienThiMacDinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDonBLL.Instance.CapNhatChiTietHoaDon(dgvChiTietHoaDon, Convert.ToInt32(lblMaSP.Text), Convert.ToInt32(cbxSize.SelectedValue), Convert.ToInt32(nudSoLuong.Value), 1);
            CapNhatTienHang();
            dgvDanhSachSanPham.ClearSelection();
            HienThiMacDinh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDonBLL.Instance.CapNhatChiTietHoaDon(dgvChiTietHoaDon, Convert.ToInt32(lblMaSP.Text), Convert.ToInt32(cbxSize.SelectedValue), 0, 2);
            CapNhatTienHang();
            dgvDanhSachSanPham.ClearSelection();
            HienThiMacDinh();
        }

        private void txtTienKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            string maGiamGia = txtMaGiamGia.Text;
            if (maGiamGia.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã giảm giá nếu có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int giaTri = HoaDonBLL.Instance.kiemTraKhuyenMai(maGiamGia);
                if (giaTri != 0)
                {
                    MessageBox.Show("Hóa đơn này được giảm: " + string.Format("{0:#,### đ}", giaTri), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã giảm giá này không có hoặc đã bị hết hạn", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CapNhatTienHang();
            }
        }

        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            if (txtTienKhachTra.Text == "")
            {
                HoaDonBLL.Instance.KhachTra = 0;
                txtTienKhachTra.Text = "0";
            }
            else
            {
                HoaDonBLL.Instance.KhachTra = Convert.ToDecimal(txtTienKhachTra.Text);
            }
            CapNhatTienHang();
        }

        private void btnNhapTien_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            var str = btn.Text.Split('.');
            string soTien = "";
            foreach (var st in str)
            {
                soTien += st;
            }

            HoaDonBLL.Instance.KhachTra += Convert.ToDecimal(soTien);
            txtTienKhachTra.Text = HoaDonBLL.Instance.KhachTra.ToString();
            CapNhatTienHang();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (HoaDonBLL.Instance.ThanhToanHoaDonBan(lblMaHoaDon.Text, tenDangNhap))
            {
                MessageBox.Show("Thanh toán hóa đơn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new NhanVien.frmInHoaDonBan(lblMaHoaDon.Text, Convert.ToInt32(txtTienKhachTra.Text), true, tenDangNhap).ShowDialog();
                //Hiển thị lại ban đầu
                HoaDonBLL.Instance.CapNhatChiTietHoaDon(dgvChiTietHoaDon, 0, 0, 0, 3);
                lblMaHoaDon.Text = lblMaHoaDon.Text = HoaDonBLL.Instance.TaoMaHoaDon(true);
                CapNhatTienHang();
                txtTienKhachTra.Text = HoaDonBLL.Instance.TienHang.ToString();
                HoaDonBLL.Instance.HienThiSanPham(dgvDanhSachSanPham, null, 0);
                dgvDanhSachSanPham.ClearSelection();
                HienThiMacDinh();
                txtMaGiamGia.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Hide();
            new frmNhanVien(tenDangNhap).ShowDialog();
            Close();
        }

        private void CapNhatTienHang()
        {
            var tienHang = HoaDonBLL.Instance.TienHang;
            var giamGia = 0;
            if (HoaDonBLL.Instance.KhuyenMai != null)
            {
                giamGia = (int)HoaDonBLL.Instance.KhuyenMai.GiaTri;
            }
            var tongTien = tienHang - giamGia;
            var khachTra = HoaDonBLL.Instance.KhachTra;
            var tienThua = khachTra - tongTien;

            lblTienHang.Text = (tienHang == 0) ? "0 đ" : string.Format("{0:#,### đ}", tienHang);
            lblGiamGia.Text = (giamGia == 0) ? "0 đ" : string.Format("{0:#,### đ}", giamGia);
            lblTongTien.Text = (tongTien == 0) ? "0 đ" : string.Format("{0:#,### đ}", tongTien);
            lblTienThua.Text = (tienThua == 0) ? "0 đ" : string.Format("{0:#,### đ}", tienThua);

        }
    }
}
