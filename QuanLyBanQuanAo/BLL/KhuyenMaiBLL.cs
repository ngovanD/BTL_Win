using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhuyenMaiBLL
    {
        private static KhuyenMaiBLL instance;
        public static KhuyenMaiBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhuyenMaiBLL();
                }
                return instance;
            }
        }

        public List<KhuyenMai> LayDanhSachKhuyenMai()
        {
            return KhuyenMaiDAL.Instance.LayDanhSachKhuyenMai();
        }

        public void ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            KhuyenMaiDAL.Instance.ThemKhuyenMai(khuyenMai);
        }

        public void SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            KhuyenMaiDAL.Instance.SuaKhuyenMai(khuyenMai);
        }

        public void XoaKhuyenMai(int maKhuyenMai)
        {
            KhuyenMaiDAL.Instance.XoaKhuyenMai(maKhuyenMai);
        }

        public List<KhuyenMai> TimKhuyenMaiTheoCode(string code)
        {
            return KhuyenMaiDAL.Instance.TimKhuyenMaiTheoCode(code);
        }

        public bool CheckCode(string code)
        {
            return KhuyenMaiDAL.Instance.CheckCode(code);
        }
    }
}
