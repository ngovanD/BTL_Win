using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private QLBanQuanAoContext db = new QLBanQuanAoContext();
        private static TaiKhoanDAL instance;

        public static TaiKhoanDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanDAL();
                }
                return instance;
            }
        }

        public bool KiemTraTaiKhoan(string tenDangNhap, string matKhau)
        {
            bool check = db.TaiKhoans.Any(tk => tk.TenDangNhap == tenDangNhap && tk.MatKhau == matKhau);
            return check;
        }
        
        //true: nhan vien, false: admin
        public bool LaTaiKhoanNhanVien(string tenDangNhap)
        {
            var taiKhoan = db.TaiKhoans.SingleOrDefault(tk => tk.TenDangNhap == tenDangNhap);
            if (taiKhoan.LoaiTaiKhoan == false)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public bool DaDangNhapHomNay(string tenDangNhap)
        {
            var taiKhoan = db.TaiKhoans.Where(t => t.TenDangNhap == tenDangNhap).FirstOrDefault();

            if(taiKhoan.ThoiGianDangNhapCuoi == null)
            {
                taiKhoan.ThoiGianDangNhapCuoi = DateTime.Now;
                db.SaveChanges();
                return false;
            }
            
            if(taiKhoan.ThoiGianDangNhapCuoi.Value.ToString("dd/MM/yyyy").Equals(DateTime.Now.ToString("dd/MM/yyyy")))
            {
                return true;
            }
            else
            {
                taiKhoan.ThoiGianDangNhapCuoi = DateTime.Now;
                db.SaveChanges();
                return false;
            }
        }

        public TaiKhoan LayThongTinTaiKhoan(string tenDangNhap)
        {
            var taiKhoan = db.TaiKhoans.SingleOrDefault(tk => tk.TenDangNhap == tenDangNhap);
            return taiKhoan;
        }
        public bool SuaTaiKhoan(TaiKhoan taiKhoan)
        {
            TaiKhoan taiKhoanCanSua = db.TaiKhoans.Where(tk => tk.ID == taiKhoan.ID).FirstOrDefault();

            try
            {
                taiKhoanCanSua = taiKhoan;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public TaiKhoan LayTaiKhoan(string tenDN)
        {
            return db.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == tenDN);
        }

    }
}
