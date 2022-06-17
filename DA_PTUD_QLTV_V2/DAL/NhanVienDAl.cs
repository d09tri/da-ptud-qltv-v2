using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public NhanVienDAL() { }

        public NhanVien GetNhanVienTheoMaNhanVien(int maNhanVien)
        {
            return db.NhanViens.First(t => t.MaNhanVien == maNhanVien);
        }
    }
}
