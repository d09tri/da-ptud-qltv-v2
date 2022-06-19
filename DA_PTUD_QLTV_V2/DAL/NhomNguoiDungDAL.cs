using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhomNguoiDungDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public NhomNguoiDungDAL() { }

        public List<NhomNguoiDung> GetDSNhomNguoiDung()
        {
            return db.NhomNguoiDungs.ToList();
        }
    }
}
