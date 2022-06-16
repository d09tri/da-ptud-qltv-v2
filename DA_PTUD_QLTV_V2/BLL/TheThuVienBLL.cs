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

        public List<view_DSTheThuVien> GetDSView_DSTheThuVien()
        {
            return ttvDAL.GetDSView_DSTheThuVien();
        }

        public bool ThemTheThuVien(TheThuVien ttv)
        {
            return ttvDAL.ThemTheThuVien(ttv);
        }

        public bool XoaTheThuVien(int mattv)
        {
            return ttvDAL.XoaTheThuVien(mattv);
        }

        public bool SuaTheThuVien(TheThuVien ttv)
        {
            return ttvDAL.SuaTheThuVien(ttv);
        }
    }
}
