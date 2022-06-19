using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NguoiDungBLL
    {
        NguoiDungDAL ndDAL = new NguoiDungDAL();

        public NguoiDungBLL() { }

        public List<view_DSNguoiDung> GetDSView_DSNguoiDung()
        {
            return ndDAL.GetDSView_DSNguoiDung();
        }

        public int DangNhap(string tenDangNhap, string matKhau)
        {
            return ndDAL.DangNhap(tenDangNhap, matKhau);
        }

        public NhanVien GetNhanVienTheoTenDangNhap(string tenDangNhap)
        {
            return ndDAL.GetNhanVienTheoTenDangNhap(tenDangNhap);
        }

        public int GetMaNhomTuTenDangNhap(string tenDangNhap)
        {
            return ndDAL.GetMaNhomTuTenDangNhap(tenDangNhap);
        }

        public int ThemNguoiDung(NguoiDung nd)
        {
            return ndDAL.ThemNguoiDung(nd);
        }


        public bool XoaNguoiDung(string tenDangNhap)
        {
            return ndDAL.XoaNguoiDung(tenDangNhap);
            
        }

        public bool SuaNguoiDung(NguoiDung nd)
        {
            return ndDAL.SuaNguoiDung(nd);
        }
    }
}
