using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiSanPhamBLL
    {
        private static LoaiSanPhamBLL instance;
        public static LoaiSanPhamBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiSanPhamBLL();
                }
                return instance;
            }
        }

        public List<LoaiSanPham> LayDanhSachLoaiSanPham()
        {
            return LoaiSanPhamDAL.Instance.LayDanhSachLoaiSanPham();
        }

        public List<LoaiSanPham_SoLuong> LayDanhSachLoaiSanPhamDayDu()
        {
            return LoaiSanPhamDAL.Instance.LayDanhSachLoaiSanPhamDayDu();
        }

        public void ThemLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            LoaiSanPhamDAL.Instance.ThemLoaiSanPham(loaiSanPham);
        }

        public void SuaLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            LoaiSanPhamDAL.Instance.SuaLoaiSanPham(loaiSanPham);
        }

        public void XoaLoaiSanPham(int maLoaiSanPham)
        {
            LoaiSanPhamDAL.Instance.XoaLoaiSanPham(maLoaiSanPham);
        }

        public List<LoaiSanPham_SoLuong> TimLoaiSanPham(string tenLoaiSanPham)
        {
            return LoaiSanPhamDAL.Instance.TimLoaiSanPham(tenLoaiSanPham);
        }
    }
}
