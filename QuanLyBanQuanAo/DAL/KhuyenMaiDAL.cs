using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMaiDAL
    {
        private QLBanQuanAoContext db = new QLBanQuanAoContext();

        private static KhuyenMaiDAL instance;
        public static KhuyenMaiDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhuyenMaiDAL();
                }
                return instance;
            }
        }

        public List<KhuyenMai> LayDanhSachKhuyenMai()
        {
            var list = db.KhuyenMais.Select(l => l);
            return list.ToList();
        }

        public void ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            db.KhuyenMais.Add(khuyenMai);
            db.SaveChanges();
            
        }

        public void SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            var khuyenMaiCanSua = db.KhuyenMais.Where(k => k.MaKhuyenMai == khuyenMai.MaKhuyenMai).FirstOrDefault();
            khuyenMaiCanSua.Code = khuyenMai.Code;
            khuyenMaiCanSua.GiaTri = khuyenMai.GiaTri;
            khuyenMaiCanSua.SoLuongCon = khuyenMai.SoLuongCon;
            khuyenMaiCanSua.HanSuDung = khuyenMai.HanSuDung;
            db.SaveChanges();
        }

        public bool CheckCode(string code)
        {
            var khuyenMai = db.KhuyenMais.Where(k => k.Code == code).FirstOrDefault();

            if(khuyenMai != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void XoaKhuyenMai(int maKhuyenMai)
        {
            var khuyenMaiCanXoa = db.KhuyenMais.Where(k => k.MaKhuyenMai == maKhuyenMai).FirstOrDefault();
            db.KhuyenMais.Remove(khuyenMaiCanXoa);
            db.SaveChanges();
        }

        public List<KhuyenMai> TimKhuyenMaiTheoCode(string code)
        {
            var danhSachKhuyenMai = db.KhuyenMais.Where(l => l.Code == code);
            return danhSachKhuyenMai.ToList();
        }
    }
}
