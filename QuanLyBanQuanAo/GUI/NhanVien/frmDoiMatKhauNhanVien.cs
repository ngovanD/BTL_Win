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

namespace GUI.NhanVien
{
    public partial class frmDoiMatKhauNhanVien : Form
    {
        private string tenDangNhap;
        public frmDoiMatKhauNhanVien(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = TaiKhoanBLL.Instance.LayThongTinTaiKhoan(tenDangNhap);
            bool matKhauCu = TaiKhoanBLL.Instance.KiemTraTaiKhoan(tenDangNhap, txtMatKhauCu.Text);

            if(!matKhauCu)
            {
                MessageBox.Show("Kiểm tra lại mật khẩu cũ");
                return;
            }

            string matKhauMoi = txtMatKhauMoi.Text;
            string matKhauXacNhan = txtMatKhauXacNhan.Text;
            
            if(!matKhauMoi.Equals(matKhauXacNhan))
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại để xác nhận không trùng nhau");
                return;
            }
            taiKhoan.MatKhau = matKhauMoi;

            if(TaiKhoanBLL.Instance.SuaTaiKhoan(taiKhoan))
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Hide();
            new frmThongTinTaiKhoan(tenDangNhap).ShowDialog();
            this.Close();
        }
    }
}
