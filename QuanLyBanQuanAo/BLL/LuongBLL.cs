using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LuongBLL
    {
        private static LuongBLL instance;

        public static LuongBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LuongBLL();
                }
                return instance;
            }
        }

        public Luong LayThongTinLuong(int maNhanVien, string thangNam)
        {
            return LuongDAL.Instance.LayThongTinLuong(maNhanVien, thangNam);
        }

        public object LayDanhSachLuong(int thang, int nam)
        {
            return LuongDAL.Instance.LayDanhSachLuong(thang, nam);
        }

        public int LayTongLuong(int thang, int nam)
        {
            return LuongDAL.Instance.LayTongLuong(thang, nam);
        }

        public void ChamCong(string tenDangNhap)
        {
            LuongDAL.Instance.ChamCong(tenDangNhap);
        }

        internal void CapNhatThuong(int id, int? tongTien)
        {
            LuongDAL.Instance.CapNhatThuong(id, (int)tongTien);
        }
    }
}
