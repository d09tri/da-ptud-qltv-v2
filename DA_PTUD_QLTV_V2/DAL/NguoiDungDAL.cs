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

        public List<view_DSNguoiDung> GetDSView_DSNguoiDung()
        {
            return db.view_DSNguoiDungs.ToList();
        }

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

        #region Xử lý thêm, xóa và sửa người dùng
        public bool KiemTraTenDangNhap(string tenDangNhap)
        {
            try
            {
                db.NguoiDungs.First(t => t.TenDangNhap == tenDangNhap);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public int ThemNguoiDung(NguoiDung nd)
        {
            try
            {
                if (KiemTraTenDangNhap(nd.TenDangNhap))
                    return -1;

                db.NguoiDungs.InsertOnSubmit(nd);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public bool XoaNguoiDung(string tenDangNhap)
        {
            try
            {
                NguoiDung ndXoa = db.NguoiDungs.Where(t => t.TenDangNhap == tenDangNhap).FirstOrDefault();
                db.NguoiDungs.DeleteOnSubmit(ndXoa);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaNguoiDung(NguoiDung nd)
        {
            try
            {
                NguoiDung ndSua = db.NguoiDungs.Where(t => t.TenDangNhap == nd.TenDangNhap).FirstOrDefault();
                ndSua.MatKhau = nd.MatKhau;
                ndSua.MaNhanVien = nd.MaNhanVien;
                ndSua.MaNhom = nd.MaNhom;
                ndSua.HoatDong = nd.HoatDong;

                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
