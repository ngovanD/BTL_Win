using BLL;
using DTO;
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
    public partial class frmQuanLyLoaiSanPham : Form
    {
        int selectRow = -1;
        public frmQuanLyLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmQuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoaiSanPham();
        }

        private void LoadDanhSachLoaiSanPham()
        {
            List<LoaiSanPham_SoLuong> danhSachLoaiSanPham = LoaiSanPhamBLL.Instance.LayDanhSachLoaiSanPhamDayDu();
            dtgvDanhSachLoaiSanPham.DataSource = danhSachLoaiSanPham;
        }

        private void dtgvDanhSachLoaiSanPham_SelectionChanged(object sender, EventArgs e)
        {
            selectRow = dtgvDanhSachLoaiSanPham.CurrentRow.Index;

            txtMaLoaiSanPham.Text = dtgvDanhSachLoaiSanPham.Rows[selectRow].Cells["MaLoaiSanPham"].Value.ToString();
            txtTenLoaiSanPham.Text = dtgvDanhSachLoaiSanPham.Rows[selectRow].Cells["TenLoaiSanPham"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham();
            loaiSanPham.TenLoaiSanPham = txtTenLoaiSanPham.Text;

            try
            {
                LoaiSanPhamBLL.Instance.ThemLoaiSanPham(loaiSanPham);
            }
            catch (Exception)
            {
                MessageBox.Show("thất bại");
                return;
            }
            MessageBox.Show("thành công");
            LoadDanhSachLoaiSanPham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thay đổi thông tin này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            selectRow = dtgvDanhSachLoaiSanPham.CurrentRow.Index;
            LoaiSanPham loaiSanPham = new LoaiSanPham();
            loaiSanPham.MaLoaiSanPham = int.Parse(dtgvDanhSachLoaiSanPham.Rows[selectRow].Cells["MaLoaiSanPham"].Value.ToString());
            loaiSanPham.TenLoaiSanPham = txtTenLoaiSanPham.Text;


            try
            {
                LoaiSanPhamBLL.Instance.SuaLoaiSanPham(loaiSanPham);
            }
            catch (Exception)
            {
                MessageBox.Show("thất bại");
                return;
            }
            MessageBox.Show("thành công");
            LoadDanhSachLoaiSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa thông tin này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            selectRow = dtgvDanhSachLoaiSanPham.CurrentRow.Index;
            int maLoaiSanPham = int.Parse(dtgvDanhSachLoaiSanPham.Rows[selectRow].Cells["MaLoaiSanPham"].Value.ToString());
            try
            {
                LoaiSanPhamBLL.Instance.XoaLoaiSanPham(maLoaiSanPham);
            }
            catch (Exception)
            {
                MessageBox.Show("thất bại");
                return;
            }
            MessageBox.Show("thành công");
            LoadDanhSachLoaiSanPham();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTenLoaiSanPham.Text))
            {
                LoadDanhSachLoaiSanPham();
                return;
            }


            List<LoaiSanPham_SoLuong> danhSachLoaiSanPham = LoaiSanPhamBLL.Instance.TimLoaiSanPham(txtTenLoaiSanPham.Text);
            dtgvDanhSachLoaiSanPham.DataSource = danhSachLoaiSanPham;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Hide();
            new frmQuanTri().ShowDialog();
            this.Close();
        }
    }
}
