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

        public List<view_DSTheThuVien> GetDSView_DSTheThuVien()
        {
            return db.view_DSTheThuViens.Select(t => t).ToList<view_DSTheThuVien>();
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

       

        #region Xử lý thêm, xóa và sửa cơ bản
        public bool ThemTheThuVien(TheThuVien ttv)
        {
            try
            {
                db.TheThuViens.InsertOnSubmit(ttv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool XoaTheThuVien(int mattv)
        {
            try
            {
                TheThuVien ttvXoa = db.TheThuViens.Where(t => t.MaThe == mattv).FirstOrDefault();
                db.TheThuViens.DeleteOnSubmit(ttvXoa);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Sửa ngày lập, ngày hết hạn, ghi chú và tình trạng//
        public bool SuaTheThuVien(TheThuVien ttv)
        {
            try
            {
                TheThuVien ttvSua = db.TheThuViens.Where(t => t.MaThe == ttv.MaThe).FirstOrDefault();               
                ttvSua.NgayLap = ttv.NgayLap;
                ttvSua.NgayHetHan = ttv.NgayHetHan;
                ttvSua.GhiChu = ttv.GhiChu;
                ttvSua.TinhTrang = ttv.TinhTrang;
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
