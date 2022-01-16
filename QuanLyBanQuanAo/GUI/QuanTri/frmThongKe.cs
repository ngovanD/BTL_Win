using BLL;
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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();

            cmbHoaDonThang.Text = DateTime.Now.Month.ToString();
            cmbHoaDonNam.Text = DateTime.Now.Year.ToString();
            cmbLuongThang.Text = DateTime.Now.Month.ToString();
            cmbLuongNam.Text = DateTime.Now.Year.ToString();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadThangNam();
            LoadSanPhamBanChayNhat();
            LoadDanhSachHoaDonNhap();
            LoadDanhSachHoaDonBan();
            LoadBangLuong();
        }

        private void LoadBangLuong()
        {
            int thang = int.Parse(cmbLuongThang.Text);
            int nam = int.Parse(cmbLuongNam.Text);
            var danhSachLuong = LuongBLL.Instance.LayDanhSachLuong(thang, nam);
 
            dtgvDanhSachLuong.DataSource = danhSachLuong;

            lblTongLuong.Text = LuongBLL.Instance.LayTongLuong(thang, nam).ToString("#,### đ");
        }

        private void LoadDanhSachHoaDonBan()
        {
            int thang = int.Parse(cmbHoaDonThang.Text);
            int nam = int.Parse(cmbHoaDonNam.Text);
            var danhSachHoaDonBan = HoaDonBLL.Instance.LayDanhSachHoaDonBan(thang, nam);

            dtgvDanhSachHoaDonBan.DataSource = danhSachHoaDonBan;
            lblTongTienBan.Text = HoaDonBLL.Instance.LayTongTienBan(thang, nam).ToString("#,### đ");
        }

        private void LoadDanhSachHoaDonNhap()
        {
            int thang = int.Parse(cmbHoaDonThang.Text);
            int nam = int.Parse(cmbHoaDonNam.Text);
            var danhSachHoaDonNhap = HoaDonBLL.Instance.LayDanhSachHoaDonNhap(thang, nam);

            dtgvDanhSachHoaDonNhap.DataSource = danhSachHoaDonNhap;
            lblTongTienNhap.Text = HoaDonBLL.Instance.LayTongTienNhap(thang, nam).ToString("#,### đ");
        }

        private void LoadSanPhamBanChayNhat()
        {
            int thang = int.Parse(cmbHoaDonThang.Text);
            int nam = int.Parse(cmbHoaDonNam.Text);
            var sanPhamBanChay = HoaDonBLL.Instance.SanPhamBanChayNhat(thang, nam);

            dtgvSanPhamBanChay.DataSource = sanPhamBanChay;
        }

        private void LoadThangNam()
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbHoaDonThang.Items.Add(i);
                cmbLuongThang.Items.Add(i);
            }

            for (int i = 2019; i <= DateTime.Now.Year; i++)
            {
                cmbHoaDonNam.Items.Add(i);
                cmbLuongNam.Items.Add(i);
            }
        }

        private void ReLoad()
        {
            LoadSanPhamBanChayNhat();
            LoadDanhSachHoaDonNhap();
            LoadDanhSachHoaDonBan();
            LoadBangLuong();
        }

        private void cmbHoaDonThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void cmbHoaDonNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void cmbLuongThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void cmbLuongNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Hide();
            new frmQuanTri().ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
