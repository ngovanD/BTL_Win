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
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            SanPhamBLL.Instance.TaoDSLoaiSP(cbxLoaiSP, false);
            SanPhamBLL.Instance.TaoDSLoaiSP(cbxTimKiemLoaiSP, true);
            HienThiMacDinh(true);

        }

        private void txtTimKiemTenSP_TextChanged(object sender, EventArgs e)
        {
            SanPhamBLL.Instance.HienThiDanhSach(dgvSanPham, (int)cbxTimKiemLoaiSP.SelectedValue, txtTimKiemTenSP.Text);
        }

        private void cbxTimKiemLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var maLoaiSP = cbxTimKiemLoaiSP.SelectedValue;
            if (maLoaiSP is LoaiSanPham) { return; }
            else
            {
                SanPhamBLL.Instance.HienThiDanhSach(dgvSanPham, (int)maLoaiSP, txtTimKiemTenSP.Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtGiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Đơn giá bán không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtGiaNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Đơn giá bán không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SanPham sp = new SanPham()
            {
                TenSanPham = txtTenSP.Text,
                MaLoaiSanPham = Convert.ToInt32(cbxLoaiSP.SelectedValue),
                DonGiaBan = Convert.ToInt32(txtGiaBan.Text),
                DonGiaNhap = Convert.ToInt32(txtGiaNhap.Text),
                MoTa = txtMoTa.Text
            };

            try
            {
                SanPhamBLL.Instance.CapNhatSanPham(sp, 0);
                MessageBox.Show("Thêm mới thành công sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThiMacDinh(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiMacDinh(bool tt)
        {
            if (tt)
            {
                SanPhamBLL.Instance.HienThiDanhSach(dgvSanPham, 0, null);
            }

            SanPhamBLL.Instance.HienThiChiTietSP(dgvChiTietSP, -1);
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtMoTa.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThiMacDinh(false);
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Hide();
            new frmQuanTri().ShowDialog();
            Close();
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            int maSP = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString());
            SanPham sp = SanPhamBLL.Instance.LayTheoMa(maSP);

            if (sp != null)
            {
                txtMaSP.Text = sp.MaSanPham.ToString();
                txtTenSP.Text = sp.TenSanPham;
                cbxLoaiSP.Text = sp.LoaiSanPham.TenLoaiSanPham;
                txtGiaNhap.Text = sp.DonGiaNhap.ToString();
                txtGiaBan.Text = sp.DonGiaBan.ToString();
                txtMoTa.Text = sp.MoTa;

                SanPhamBLL.Instance.HienThiChiTietSP(dgvChiTietSP, maSP);
            }

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void nhapGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtGiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Đơn giá bán không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtGiaNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Đơn giá bán không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SanPham sp = SanPhamBLL.Instance.LayTheoMa(Convert.ToInt32(txtMaSP.Text));
            sp.TenSanPham = txtTenSP.Text;
            sp.MaLoaiSanPham = Convert.ToInt32(cbxLoaiSP.SelectedValue);
            sp.DonGiaBan = Convert.ToInt32(txtGiaBan.Text);
            sp.DonGiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            sp.MoTa = txtMoTa.Text;

            try
            {
                SanPhamBLL.Instance.CapNhatSanPham(sp, 2);
                MessageBox.Show("Sửa thành công sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThiMacDinh(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPham sp = SanPhamBLL.Instance.LayTheoMa(Convert.ToInt32(txtMaSP.Text));

            if (sp != null)
            {
                var d = MessageBox.Show("Bạn có muốn xóa sản phẩm này", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (d == DialogResult.OK)
                {
                    try
                    {
                        SanPhamBLL.Instance.CapNhatSanPham(sp, 1);
                        MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        HienThiMacDinh(true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
