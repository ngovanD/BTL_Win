using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham_SoLuong
    {
        int maSanPham;
        string tenSanPham;
        int soLuong;

        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
