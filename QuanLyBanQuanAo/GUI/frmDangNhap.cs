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

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        private string tenDangNhap;

        public frmDangNhap()
        {
            InitializeComponent();
        }
        public frmDangNhap(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            bool check = TaiKhoanBLL.Instance.KiemTraTaiKhoan(tenDangNhap, matKhau);
            if (check)
            {
                
                if (TaiKhoanBLL.Instance.LaTaiKhoanNhanVien(tenDangNhap))
                {
                    if (!TaiKhoanBLL.Instance.DaDangNhapHomNay(tenDangNhap))
                    {
                        LuongBLL.Instance.ChamCong(tenDangNhap);
                    }
                    Hide();
                    new frmNhanVien(tenDangNhap).ShowDialog();
                        
                    Close();
                }
                else
                {
                    Hide();
                    new frmQuanTri().ShowDialog();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tài khoản và mật khẩu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
