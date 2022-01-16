using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham_SoLuong
    {
        int maLoaiSanPham;
        string tenLoaiSanPham;
        int soLuongSanPham;

        public int MaLoaiSanPham { get => maLoaiSanPham; set => maLoaiSanPham = value; }
        public string TenLoaiSanPham { get => tenLoaiSanPham; set => tenLoaiSanPham = value; }
        public int SoLuongSanPham { get => soLuongSanPham; set => soLuongSanPham = value; }
    }
}
