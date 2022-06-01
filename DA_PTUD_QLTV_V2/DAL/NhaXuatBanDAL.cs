using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhaXuatBanDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public NhaXuatBanDAL() { }

        public List<NhaXuatBan> GetDSNhaXuatBan()
        {
            return db.NhaXuatBans.ToList();
        }

        public string GetTenNhaXuatBanTuMa(int maNXB)
        {
            return db.NhaXuatBans.First(t => t.MaNXB == maNXB).TenNXB;
        }
    }
}
