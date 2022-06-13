using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TheThuVienDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public TheThuVienDAL() { }

        public List<TheThuVien> GetDSTheThuVien()
        {
            return db.TheThuViens.ToList();
        }

        public TheThuVien GetTheThuVienTheoMaDocGia(int maDocGia)
        {
            try
            {
                return db.TheThuViens.First(t => t.MaDocGia == maDocGia);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
