using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        private QLBanQuanAoContext db = new QLBanQuanAoContext();
        private static SanPhamDAL instance;

        public static SanPhamDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamDAL();
                }
                return instance;
            }
        }

        public List<SanPham> LayToanBo()
        {
            return db.SanPhams.ToList();
        }

        public SanPham LayTheoMa(int maSP)
        {
            return db.SanPhams.FirstOrDefault(sp => sp.MaSanPham == maSP);
        }

        public List<SanPham> LayTheoTuKhoa(string tenSP, int maLoaiSP)
        {
            if (tenSP == null)
            {
                return db.SanPhams.Where(sp => sp.LoaiSanPham.MaLoaiSanPham == maLoaiSP).ToList();
            }
            else if (maLoaiSP == 0)
            {
                return db.SanPhams.Where(sp => sp.TenSanPham.ToLower().Contains(tenSP.ToLower().Trim())).ToList();
            }
            else
            {
                return db.SanPhams.Where(sp => sp.TenSanPham.ToLower().Contains(tenSP.ToLower().Trim()) && sp.LoaiSanPham.MaLoaiSanPham == maLoaiSP).ToList();
            }
        }

        public List<SanPham> LayTheoTenSP(string tenSP)
        {
            return db.SanPhams.Where(sp => sp.TenSanPham.ToLower().Contains(tenSP.ToLower().Trim())).ToList();
        }

        public void CapNhatSanPham(SanPham sp, int tt)
        {
            if (tt == 0)
            {
                db.SanPhams.Add(sp);
            }
            if (tt == 1)
            {
                List<ChiTietSanPham> chiTietSanPhams = db.ChiTietSanPhams.Where(ctsp => ctsp.MaSanPham == sp.MaSanPham).ToList();
                db.SanPhams.Remove(sp);

                foreach(var ctsp in chiTietSanPhams)
                {
                    db.ChiTietSanPhams.Remove(ctsp);
                }
            }
            db.SaveChanges();
        }
    }
}
