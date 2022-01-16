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

namespace GUI.QuanTri
{
    public partial class frmQuanLyKhuyenMai : Form
    {
        int selectRow = -1;
        public frmQuanLyKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmQuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhuyenMai();
        }

        private void LoadDanhSachKhuyenMai()
        {
            List<KhuyenMai> danhSachKhuyenMai = KhuyenMaiBLL.Instance.LayDanhSachKhuyenMai();
            dtgvDanhSachKhuyenMai.DataSource = danhSachKhuyenMai;
        }

        private void dtgvDanhSachKhuyenMai_SelectionChanged(object sender, EventArgs e)
        {
            selectRow = dtgvDanhSachKhuyenMai.CurrentRow.Index;

            txtMaKhuyenMai.Text = dtgvDanhSachKhuyenMai.Rows[selectRow].Cells["MaKhuyenMai"].Value.ToString();
            txtCode.Text = dtgvDanhSachKhuyenMai.Rows[selectRow].Cells["Code"].Value.ToString();
            txtGiaTri.Text = dtgvDanhSachKhuyenMai.Rows[selectRow].Cells["GiaTri"].Value.ToString();
            txtSoLuongCon.Text = dtgvDanhSachKhuyenMai.Rows[selectRow].Cells["SoLuongCon"].Value.ToString();
            dtpHanSuDung.Text = dtgvDanhSachKhuyenMai.Rows[selectRow].Cells["HanSuDung"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhuyenMai khuyenMai = new KhuyenMai();
            khuyenMai.Code = txtCode.Text;
            khuyenMai.GiaTri = int.Parse(txtGiaTri.Text);
            khuyenMai.SoLuongCon = int.Parse(txtSoLuongCon.Text);
            khuyenMai.HanSuDung = dtpHanSuDung.Value;

            try
            {
                KhuyenMaiBLL.Instance.ThemKhuyenMai(khuyenMai);
            }
            catch (Exception)
            {
                MessageBox.Show("thất bại");
                return;
            }
            MessageBox.Show("thành công");
            LoadDanhSachKhuyenMai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            selectRow = dtgvDanhSachKhuyenMai.CurrentRow.Index;
            KhuyenMai khuyenMai = new KhuyenMai();
            khuyenMai.MaKhuyenMai = int.Parse(dtgvDanhSachKhuyenMai.Rows[selectRow].Cells["MaKhuyenMai"].Value.ToString());
            khuyenMai.Code = txtCode.Text;
            khuyenMai.GiaTri = int.Parse(txtGiaTri.Text);
            khuyenMai.SoLuongCon = int.Parse(txtSoLuongCon.Text);
            khuyenMai.HanSuDung = dtpHanSuDung.Value;

            try
            {
                KhuyenMaiBLL.Instance.SuaKhuyenMai(khuyenMai);
            }
            catch (Exception)
            {
                MessageBox.Show("thất bại");
                return;
            }
            MessageBox.Show("thành công");
            LoadDanhSachKhuyenMai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            selectRow = dtgvDanhSachKhuyenMai.CurrentRow.Index;
            int maKhuyeMai = int.Parse(dtgvDanhSachKhuyenMai.Rows[selectRow].Cells["MaKhuyenMai"].Value.ToString());
            try
            {
                KhuyenMaiBLL.Instance.XoaKhuyenMai(maKhuyeMai);
            }
            catch (Exception)
            {
                MessageBox.Show("thất bại");
                return;
            }
            MessageBox.Show("thành công");
            LoadDanhSachKhuyenMai();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Hide();
            new frmQuanTri().ShowDialog();
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                LoadDanhSachKhuyenMai();
                return;
            }


            List<KhuyenMai> danhSachKhuyenMai = KhuyenMaiBLL.Instance.TimKhuyenMaiTheoCode(txtCode.Text);
            dtgvDanhSachKhuyenMai.DataSource = danhSachKhuyenMai;
        }
    }
}
