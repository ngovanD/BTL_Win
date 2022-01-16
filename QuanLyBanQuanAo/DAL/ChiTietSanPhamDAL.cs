using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietSanPhamDAL
    {
        private QLBanQuanAoContext db = new QLBanQuanAoContext();
        private static ChiTietSanPhamDAL instance;

        public static ChiTietSanPhamDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietSanPhamDAL();
                }
                return instance;
            }
        }

        public List<ChiTietSanPham> LayTheoMaSP(int maSP)
        {
            return db.ChiTietSanPhams.Where(ctsp => ctsp.MaSanPham == maSP).ToList();
        }

        public ChiTietSanPham LayTheoMaSPMaKT(int maSP, int maKT)
        {
            return db.ChiTietSanPhams.FirstOrDefault(ctsp => ctsp.MaSanPham == maSP && ctsp.ID_KichThuoc == maKT);
        }

        public void CapNhatDS(List<ChiTietSanPham> chiTietSanPhams)
        {
            foreach(var ctsp in chiTietSanPhams)
            {
                ChiTietSanPham chiTietSanPham = LayTheoMaSPMaKT(ctsp.MaSanPham, ctsp.ID_KichThuoc);
                if (chiTietSanPham != null)
                {
                    chiTietSanPham.SoLuongCon = ctsp.SoLuongCon;
                    db.SaveChanges();
                }
            }
        }

        public List<ChiTietSanPham> LayToanBo()
        {
            return db.ChiTietSanPhams.ToList();
        }
    }
}
