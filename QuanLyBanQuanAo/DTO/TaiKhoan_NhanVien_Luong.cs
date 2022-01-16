using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_NhanVien_Luong
    {
        TaiKhoan taiKhoan;
        NhanVien nhanVien;
        Luong luong;

        public TaiKhoan TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }
        public Luong Luong { get => luong; set => luong = value; }
    }
}
