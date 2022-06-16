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

        public bool ThemDocGia(DocGia dg)
        {
            return dgDAL.ThemDocGia(dg);
        }

        public bool XoaDocGia(int madg)
        {
            return dgDAL.XoaDocGia(madg);
        }

        public bool SuaDocGia(DocGia dg)
        {
            return dgDAL.SuaDocGia(dg);
        }

        public List<DocGia> GetDSDocGiaTheoTen(string tendg)
        {
            return dgDAL.GetDSDocGiaTheoTen(tendg);
        }

        public List<DocGia> GetDSDocGiaChuaCoTheThuVien()
        {
            return dgDAL.GetDSDocGiaChuaCoTheThuVien();
        }
    }
}
