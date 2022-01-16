using BLL;
using DTO;
using GUI.NhanVien;
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
    public partial class frmThongTinTaiKhoan : Form
    {
        private string tenDangNhap;
        public frmThongTinTaiKhoan(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            InitializeComponent();
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thay đổi thông tin này không", "Thông báo", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            TaiKhoan taiKhoan = TaiKhoanBLL.Instance.LayThongTinTaiKhoan(tenDangNhap);
            DTO.NhanVien nhanVien = NhanVienBLL.Instance.LayThongTinNhanVien(taiKhoan.ID);
            nhanVien.HoTen = txtHoTen.Text;
            nhanVien.DiaChi = txtDiaChi.Text;
            if(rbnNam.Checked)
            {
                nhanVien.GioiTinh = "Nam";
            }
            else
            {
                nhanVien.GioiTinh = "Nữ";
            }
            nhanVien.SoDienThoai = txtSoDienThoai.Text;
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            nhanVien.NgaySinh = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", null);

            if(NhanVienBLL.Instance.SuaNhanVien(nhanVien))
            {
                MessageBox.Show("Sửa thông tin thành công");
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại");
            }
            LoadThongTin();
        }

        private void LoadThongTin()
        {
            TaiKhoan taiKhoan = TaiKhoanBLL.Instance.LayThongTinTaiKhoan(tenDangNhap);
            DTO.NhanVien nhanVien = NhanVienBLL.Instance.LayThongTinNhanVien(taiKhoan.ID);
            Luong luong = LuongBLL.Instance.LayThongTinLuong(nhanVien.ID, DateTime.Now.ToString());

            txtTenDangNhap.Text = taiKhoan.TenDangNhap;
            txtLoaiTaiKhoan.Text = (bool)taiKhoan.LoaiTaiKhoan == true ? "Nhân viên" : "Quản lý";
            txtHoTen.Text = nhanVien.HoTen;
            dtpNgaySinh.Text = nhanVien.NgaySinh.ToString();
            if(nhanVien.GioiTinh == "Nam")
            {
                rbnNam.Checked = true;
            }    
            else
            {
                rbnNu.Checked = true;
            }    
            txtDiaChi.Text = nhanVien.DiaChi;
            txtSoDienThoai.Text = nhanVien.SoDienThoai;
            txtLuongThangNay.Text = (luong.SoNgayCong*luong.LuongCoBanNgay+luong.Thuong).ToString() + "VND";
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Hide();
            new frmDoiMatKhauNhanVien(tenDangNhap).ShowDialog();
            this.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Hide();
            new frmNhanVien(tenDangNhap).ShowDialog();
            this.Close();
        }
    }
}
