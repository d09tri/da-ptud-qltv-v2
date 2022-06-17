using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nvDAL = new NhanVienDAL();

        public NhanVienBLL() { }

        public List<NhanVien> GetDSNhanVien()
        {
            return nvDAL.GetDSNhanVien();
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            return nvDAL.ThemNhanVien(nv);
        }


        public bool XoaNhanVien(int maNhanVien)
        {
            return nvDAL.XoaNhanVien(maNhanVien);
        }

        public bool SuaNhanVien(NhanVien nv)
        {
            return nvDAL.SuaNhanVien(nv);
        }

        public List<NhanVien> GetDSNhanVienTheoTen(string tenNhanVien)
        {
            return nvDAL.GetDSNhanVienTheoTen(tenNhanVien);
        }
    }
}
