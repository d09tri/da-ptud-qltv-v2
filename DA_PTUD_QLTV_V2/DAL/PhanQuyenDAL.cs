using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhanQuyenDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public PhanQuyenDAL() { }

        public List<view_DSPhanQuyen> GetDSView_DSPhanQuyenTheoMaNhom(int maNhom)
        {
            return db.view_DSPhanQuyens.Where(t => t.MaNhom == maNhom).ToList();
        }
    }
}
