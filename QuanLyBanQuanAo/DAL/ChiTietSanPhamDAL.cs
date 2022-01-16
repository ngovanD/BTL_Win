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
    }
}
