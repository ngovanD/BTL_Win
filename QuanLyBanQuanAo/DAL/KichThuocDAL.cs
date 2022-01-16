using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class KichThuocDAL
    {
        private QLBanQuanAoContext db = new QLBanQuanAoContext();
        private static KichThuocDAL instance;

        public static KichThuocDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KichThuocDAL();
                }
                return instance;
            }
        }

        public List<KichThuoc> LayToanBo()
        {
            return db.KichThuocs.ToList();
        }

        public KichThuoc LayTheoMa(int idKichThuc)
        {
            return db.KichThuocs.FirstOrDefault(kt => kt.ID_KichThuoc == idKichThuc);
        }
    }
}
