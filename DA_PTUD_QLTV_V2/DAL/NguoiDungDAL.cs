using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NguoiDungDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();
        NhanVienDAL nvDAL = new NhanVienDAL();

        public NguoiDungDAL() { }

        public int DangNhap(string tenDangNhap, string matKhau)
        {
            NguoiDung nd;
            try
            {
                nd = db.NguoiDungs.First(t => t.TenDangNhap == tenDangNhap && t.MatKhau == matKhau);
            }
            catch (Exception)
            {
                nd = null;
            }

            if (nd == null)
                return 0;
            else if (nd.HoatDong == null || nd.HoatDong == false)
                return -1;
            else
                return 1;
        }

        public NhanVien GetNhanVienTheoTenDangNhap(string tenDangNhap)
        {
            int maNhanVien = (int)db.NguoiDungs.First(t => t.TenDangNhap == tenDangNhap).MaNhanVien;
            return nvDAL.GetNhanVienTheoMaNhanVien(maNhanVien);
        }

        public int GetMaNhomTuTenDangNhap(string tenDangNhap)
        {
            return (int)db.NguoiDungs.First(t => t.TenDangNhap == tenDangNhap).MaNhom;
        }
    }
}
