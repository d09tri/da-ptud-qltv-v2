using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DocGiaDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public DocGiaDAL() { }

        public List<DocGia> GetDSDocGia()
        {
            return db.DocGias.ToList();
        }
    }
}
