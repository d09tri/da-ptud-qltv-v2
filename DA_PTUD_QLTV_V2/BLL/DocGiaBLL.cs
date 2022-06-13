using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DocGiaBLL
    {
        DocGiaDAL dgDAL = new DocGiaDAL();

        public DocGiaBLL() { }

        public List<DocGia> GetDSDocGia()
        {
            return dgDAL.GetDSDocGia();
        }
    }
}
