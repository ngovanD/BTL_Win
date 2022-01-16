using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        private QLBanQuanAoContext db = new QLBanQuanAoContext();
        private static HoaDonDAL instance;

        public static HoaDonDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAL();
                }
                return instance;
            }
        }

        public int LaySoHoaDon(String maHD)
        {
            return db.HoaDons.Count(hd => hd.MaHoaDon.Contains(maHD)) + 1;

        }

        public void LuuHoaDon(HoaDon hoaDon, List<DongHoaDon> dongHoaDons)
        {
            db.HoaDons.Add(hoaDon);
            db.SaveChanges();

            db.DongHoaDons.AddRange(dongHoaDons);
            db.SaveChanges();
        }

        public List<HoaDon> LayTheoLoaiHD(bool loaiHD)
        {
            return db.HoaDons.Where(hd => hd.LoaiHoaDon == loaiHD).ToList();
        }

        public List<HoaDon> LayTheoDieuKien(List<object> tuKhoa,int status, bool loaiHD)
        {
            switch (status)
            {
                case 1:
                    //Mã hóa đơn
                    string maHD = Convert.ToString(tuKhoa[0]);
                    return db.HoaDons.Where(hd => hd.MaHoaDon.ToLower().Contains(maHD.ToLower().Trim()) && hd.LoaiHoaDon == loaiHD).ToList();
                case 2:
                    //Mã nhân viên
                    int idTK = Convert.ToInt32(tuKhoa[0]);
                    return db.HoaDons.Where(hd => hd.ID == idTK && hd.LoaiHoaDon == loaiHD).ToList();
                case 3:
                    //Ngày xuất
                    DateTime bd = Convert.ToDateTime(tuKhoa[0]);
                    DateTime kt = Convert.ToDateTime(tuKhoa[1]);
                    return db.HoaDons.Where(hd => hd.ThoiGian >= bd && hd.ThoiGian <= kt && hd.LoaiHoaDon == loaiHD).ToList();
                case 4:
                    //Tổng số tiền
                    int tienBd = Convert.ToInt32(tuKhoa[0]);
                    int tienKt = Convert.ToInt32(tuKhoa[1]);
                    return db.HoaDons.Where(hd => hd.TongTien >= tienBd && hd.TongTien <= tienKt && hd.LoaiHoaDon == loaiHD).ToList();
                    break;
            }
            return null;
        }

        public HoaDon LayTheoMa(string maHoaDon)
        {
            return db.HoaDons.FirstOrDefault(nv => nv.MaHoaDon == maHoaDon);
        }

        public List<SanPham_SoLuong> SanPhamBanChayNhat(int thang, int nam)
        {
            List<HoaDon> danhSachHoaDon = db.HoaDons.AsEnumerable().Where(h => h.ThoiGian.Value.Month == thang && h.ThoiGian.Value.Year == nam && h.LoaiHoaDon == true).ToList();

            var dongHoaDon_ChiTietHoaDon = from d in danhSachHoaDon
                                           join c in db.DongHoaDons on d.MaHoaDon equals c.MaHoaDon
                                           group c by c.MaSanPham into tem
                                           select new DongHoaDon {
                                               MaSanPham = tem.Key,
                                               SoLuong = tem.Sum(t => t.SoLuong)
                                           };
            List<SanPham_SoLuong> sanPhamBanChay = (from d in dongHoaDon_ChiTietHoaDon
                                              join s in db.SanPhams on d.MaSanPham equals s.MaSanPham
                                              orderby d.SoLuong descending
                                              select new SanPham_SoLuong {
                                                 MaSanPham = d.MaSanPham,
                                                 TenSanPham = s.TenSanPham,
                                                 SoLuong = (int)d.SoLuong
                                             }).Take(1).ToList();

            return sanPhamBanChay;

        }

        public object LayDanhSachHoaDonBan(int thang, int nam)
        {
            //List<HoaDon> danhSachHoaDon = db.HoaDons.Where(h => h.ThoiGian.Value.Month == thang && h.ThoiGian.Value.Year == nam && h.LoaiHoaDon == true).ToList();
            object danhSachHoaDon = (from d in db.HoaDons
                                           join t in db.TaiKhoans on d.ID equals t.ID
                                           join n in db.NhanViens on t.ID equals n.IdTK
                                           where d.ThoiGian.Value.Month == thang && d.ThoiGian.Value.Year == nam && d.LoaiHoaDon == true
                                           select new
                                           {
                                               MaHoaDon = d.MaHoaDon,
                                               ThoiGian = d.ThoiGian,
                                               TongTien = d.TongTien,
                                               TenNhanVien = n.HoTen
                                           }).ToList();

            return danhSachHoaDon;
        }

        public object LayDanhSachHoaDonNhap(int thang, int nam)
        {
            object danhSachHoaDon = db.HoaDons.AsEnumerable()
                .Where(h => h.ThoiGian.Value.Month == thang && h.ThoiGian.Value.Year == nam && h.LoaiHoaDon == false)
                .Select(d => new { MaHoaDon = d.MaHoaDon, ThoiGian = d.ThoiGian, TongTien = d.TongTien})
                .ToList();
            return danhSachHoaDon;
        }

        public int LayTongTienBan(int thang, int nam)
        {
            List<HoaDon> danhSachHoaDon = db.HoaDons.Where(h => h.ThoiGian.Value.Month == thang && h.ThoiGian.Value.Year == nam && h.LoaiHoaDon == true).ToList();
            return (int)danhSachHoaDon.Sum(d => d.TongTien);
        }

        public int LayTongTienNhap(int thang, int nam)
        {
            List<HoaDon> danhSachHoaDon = db.HoaDons.AsEnumerable().Where(h => h.ThoiGian.Value.Month == thang && h.ThoiGian.Value.Year == nam && h.LoaiHoaDon == false).ToList();
            return (int)danhSachHoaDon.Sum(d => d.TongTien);
        }
    }
}
