using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.QuanTri
{
    public partial class frmTaoHoaDonNhap : Form
    {
        public frmTaoHoaDonNhap()
        {
            InitializeComponent();
        }

        private void frmTaoHoaDonNhap_Load(object sender, EventArgs e)
        {
            lblMaHoaDon.Text = HoaDonBLL.Instance.TaoMaHoaDon(false);
            HoaDonBLL.Instance.TaoDSLoaiSP(cbxLocLoaiSP);
            HoaDonBLL.Instance.HienThiSanPham(dgvDSSanPham, null, 0);
            HoaDonBLL.Instance.HienThiKichThuc(null, cbxSize);
            HienThiMacDinh();
            CapNhatTienHang();
        }

        private void CapNhatTienHang()
        {
            var tienHang = HoaDonBLL.Instance.TienHang;

            txtTongTien.Text = (tienHang == 0) ? "0 đ" : string.Format("{0:#,### đ}", tienHang);
        }

        private void HienThiMacDinh()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtLoaiSP.Text = "";
            txtGiaNhap.Text = "";
            nudSLNhap.Value = 1;
            nudSLNhap.Enabled = false;
            cbxSize.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void cbxLocLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var loaiSP = cbxLocLoaiSP.SelectedValue;
            if (loaiSP is LoaiSanPham) { }
            else
            {
                HoaDonBLL.Instance.HienThiSanPham(dgvDSSanPham, txtTKTenSP.Text, (int)loaiSP);
            }
        }

        private void txtTKTenSP_TextChanged(object sender, EventArgs e)
        {
            HoaDonBLL.Instance.HienThiSanPham(dgvDSSanPham, txtTKTenSP.Text, (int)cbxLocLoaiSP.SelectedValue);
        }

        private void dgvDSSanPham_SelectionChanged(object sender, EventArgs e)
        {
            var maSP = Convert.ToInt32(dgvDSSanPham.CurrentRow.Cells["MaSanPham"].Value);

            SanPham sp = SanPhamBLL.Instance.LayTheoMa(maSP);

            if (sp != null)
            {
                txtMaSP.Text = sp.MaSanPham.ToString();
                txtTenSP.Text = sp.TenSanPham;
                txtLoaiSP.Text = sp.LoaiSanPham.TenLoaiSanPham;
                txtGiaNhap.Text = string.Format("{0:#,### đ}", sp.DonGiaBan);
            }

            nudSLNhap.Enabled = true;
            cbxSize.Enabled = true;
            btnThem.Enabled = true;
            dgvChiTietHoaDon.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDonBLL.Instance.CapNhatChiTietHoaDon(dgvChiTietHoaDon, Convert.ToInt32(txtMaSP.Text), Convert.ToInt32(cbxSize.SelectedValue), Convert.ToInt32(nudSLNhap.Value), 0);
            CapNhatTienHang();
            dgvDSSanPham.ClearSelection();
            HienThiMacDinh();
        }

        private void dgvChiTietHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var maSP = Convert.ToInt32(dgvChiTietHoaDon.CurrentRow.Cells["MaSP"].Value);
                var idKichThuc = Convert.ToInt32(dgvChiTietHoaDon.CurrentRow.Cells["MaKT"].Value);

                DongHoaDon ctsp = HoaDonBLL.Instance.LayChiTietHDTheoMaSPVaKichThuoc(maSP, idKichThuc);

                if (ctsp != null)
                {
                    txtMaSP.Text = ctsp.MaSanPham.ToString();
                    txtTenSP.Text = ctsp.SanPham.TenSanPham;
                    txtLoaiSP.Text = ctsp.SanPham.LoaiSanPham.TenLoaiSanPham;
                    txtGiaNhap.Text = string.Format("{0:#,### đ}", ctsp.SanPham.DonGiaNhap);
                    cbxSize.SelectedValue = ctsp.ID_KichThuoc;
                    nudSLNhap.Value = Convert.ToInt32(ctsp.SoLuong);
                }

                nudSLNhap.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                dgvDSSanPham.ClearSelection();
            }
            catch (Exception) { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDonBLL.Instance.CapNhatChiTietHoaDon(dgvChiTietHoaDon, Convert.ToInt32(txtMaSP.Text), Convert.ToInt32(cbxSize.SelectedValue), Convert.ToInt32(nudSLNhap.Value), 1);
            CapNhatTienHang();
            dgvDSSanPham.ClearSelection();
            HienThiMacDinh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDonBLL.Instance.CapNhatChiTietHoaDon(dgvChiTietHoaDon, Convert.ToInt32(txtMaSP.Text), Convert.ToInt32(cbxSize.SelectedValue), 0, 2);
            CapNhatTienHang();
            dgvDSSanPham.ClearSelection();
            HienThiMacDinh();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (HoaDonBLL.Instance.ThanhToanHoaDonBan(lblMaHoaDon.Text, "Admin"))
            {
                MessageBox.Show("Thêm sản phẩm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Hiển thị lại ban đầu
                HoaDonBLL.Instance.CapNhatChiTietHoaDon(dgvChiTietHoaDon, 0, 0, 0, 3);
                lblMaHoaDon.Text = lblMaHoaDon.Text = HoaDonBLL.Instance.TaoMaHoaDon(false);
                CapNhatTienHang();
                dgvDSSanPham.ClearSelection();
                HienThiMacDinh();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Hide();
            new frmQuanTri().ShowDialog();
            Close();
        }
    }
}
