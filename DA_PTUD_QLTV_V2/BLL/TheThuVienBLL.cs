using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TheThuVienBLL
    {
        TheThuVienDAL ttvDAL = new TheThuVienDAL();

        public TheThuVienBLL() { }

        public List<TheThuVien> GetDSTheThuVien() 
        {
            return ttvDAL.GetDSTheThuVien();
        }

        public TheThuVien GetTheThuVienTheoMaDocGia(int maDocGia)
        {
            return ttvDAL.GetTheThuVienTheoMaDocGia(maDocGia);
        }
    }
}
