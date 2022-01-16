using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LuongDAL
    {
        private QLBanQuanAoContext db = new QLBanQuanAoContext();
        private static LuongDAL instance;

        public static LuongDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LuongDAL();
                }
                return instance;
            }
        }
        public Luong LayThongTinLuong(int ID, string thangNam)
        {
            var luong = db.Luongs.AsEnumerable()
                                .Where(l => l.MaNhanVien == ID && String.Format("MM/yyyy", l.ThangNam) == String.Format("MM/yyyy", thangNam))
                                .FirstOrDefault();
            return luong;
        }

        public object LayDanhSachLuong(int thang, int nam)
        {
            var list = (from l in db.Luongs
                        join n in db.NhanViens on l.MaNhanVien equals n.ID
                        where l.ThangNam.Value.Month == thang && l.ThangNam.Value.Year == nam
                        select new
                        {
                            MaNhanVien = l.MaNhanVien,
                            HoTen = n.HoTen,
                            SoNgayCong = l.SoNgayCong,
                            Luong = l.SoNgayCong*l.LuongCoBanNgay + l.Thuong
                        }).ToList();
            return list;

        }

        public void ChamCong(string tenDangNhap)
        {
            var nhanVien = (from t in db.TaiKhoans
                           join n in db.NhanViens on t.ID equals n.IdTK
                           where t.TenDangNhap == tenDangNhap
                           select n).FirstOrDefault();

            var luong = (from l in db.Luongs
                        where l.MaNhanVien == nhanVien.ID && l.ThangNam.Value.Month == DateTime.Now.Month && l.ThangNam.Value.Year == DateTime.Now.Year
                        select l).FirstOrDefault();
            if(luong == null)
            {
                Luong luongMoi= new Luong();
                luongMoi.MaNhanVien = nhanVien.ID;
                luongMoi.ThangNam = DateTime.Now;
                luongMoi.SoNgayCong = 1;
                luongMoi.Thuong = 0;
                luongMoi.LuongCoBanNgay = nhanVien.LuongCoBanNgay;
                db.Luongs.Add(luongMoi);
                db.SaveChanges();
                return;
            }    

            luong.SoNgayCong++;
            db.SaveChanges();

        }

        public int LayTongLuong(int thang, int nam)
        {
            var list = (from l in db.Luongs
                        join n in db.NhanViens on l.MaNhanVien equals n.ID
                        where l.ThangNam.Value.Month == thang && l.ThangNam.Value.Year == nam
                        select new
                        {
                            MaNhanVien = l.MaNhanVien,
                            HoTen = n.HoTen,
                            SoNgayCong = l.SoNgayCong,
                            Luong = l.SoNgayCong * l.LuongCoBanNgay + l.Thuong
                        }).ToList();
            return (int)list.Sum(l => l.Luong);
        }
    }
}
