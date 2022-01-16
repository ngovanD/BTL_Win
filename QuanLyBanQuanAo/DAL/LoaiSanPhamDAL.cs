using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiSanPhamDAL
    {
        private QLBanQuanAoContext db = new QLBanQuanAoContext();
        private static LoaiSanPhamDAL instance;
        public static LoaiSanPhamDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiSanPhamDAL();
                }
                return instance;
            }
        }

        public List<LoaiSanPham> LayDanhSachLoaiSanPham()
        {
            var list = db.LoaiSanPhams.Select(l => l);
            return list.ToList();
        }

        public List<LoaiSanPham_SoLuong> LayDanhSachLoaiSanPhamDayDu()
        {
            var danhSachLoaiSanPham = db.LoaiSanPhams.Select(l => l);

            var sanPham = from sp in db.SanPhams
                          group sp by sp.MaLoaiSanPham into spl
                          select new
                          {
                              MaLoaiSanPham = spl.Key,
                              SoLuongSanPham = spl.Count(s => s.MaLoaiSanPham == spl.Key)
                          };
            var list = from l in danhSachLoaiSanPham
                       join sp in sanPham on l.MaLoaiSanPham equals sp.MaLoaiSanPham into s
                       from tem in s.DefaultIfEmpty()
                       select new LoaiSanPham_SoLuong
                       {
                           MaLoaiSanPham = l.MaLoaiSanPham,
                           TenLoaiSanPham = l.TenLoaiSanPham,
                           SoLuongSanPham = tem.SoLuongSanPham == null ? 0 : tem.SoLuongSanPham
                       };

            return list.ToList();
        }

        public List<LoaiSanPham_SoLuong> TimLoaiSanPham(string tenLoaiSanPham)
        {
            var danhSachLoaiSanPham = db.LoaiSanPhams.Where(l => l.TenLoaiSanPham.Contains(tenLoaiSanPham));

            var sanPham = from sp in db.SanPhams
                          group sp by sp.MaLoaiSanPham into spl
                          select new
                          {
                              MaLoaiSanPham = spl.Key,
                              SoLuongSanPham = spl.Count(s => s.MaLoaiSanPham == spl.Key)
                          };
            var list = from l in danhSachLoaiSanPham
                       join sp in sanPham on l.MaLoaiSanPham equals sp.MaLoaiSanPham into s
                       from tem in s.DefaultIfEmpty()
                       select new LoaiSanPham_SoLuong
                       {
                           MaLoaiSanPham = l.MaLoaiSanPham,
                           TenLoaiSanPham = l.TenLoaiSanPham,
                           SoLuongSanPham = tem.SoLuongSanPham == null ? 0 : tem.SoLuongSanPham
                       };

            return list.ToList();
        }

        public void XoaLoaiSanPham(int maLoaiSanPham)
        {
            var loaiSanPhamCanXoa = db.LoaiSanPhams.Where(l => l.MaLoaiSanPham == maLoaiSanPham).FirstOrDefault();
            db.LoaiSanPhams.Remove(loaiSanPhamCanXoa);
            db.SaveChanges();
        }

        public void SuaLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            var loaiSanPhamCanSua = db.LoaiSanPhams.Where(l => l.MaLoaiSanPham == loaiSanPham.MaLoaiSanPham).FirstOrDefault();
            loaiSanPhamCanSua.TenLoaiSanPham = loaiSanPham.TenLoaiSanPham;
            db.SaveChanges();
        }

        public void ThemLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            db.LoaiSanPhams.Add(loaiSanPham);
            db.SaveChanges();
        }

        public List<LoaiSanPham> LayToanBo()
        {
            return db.LoaiSanPhams.ToList();
        }
    }
}
