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

        public List<view_DSTheThuVien> GetDSView_DSTheThuVien()
        {
            return db.view_DSTheThuViens.Select(t => t).ToList<view_DSTheThuVien>();
        }

        public List<view_DSTheThuVien> GetDSView_DSTheThuVienTheoTenDocGia(string tenDocGia)
        {
            return db.view_DSTheThuViens.Where(t => t.TenDocGia.Contains(tenDocGia)).Select(t => t).ToList<view_DSTheThuVien>();
        }
        
        #region Xử lý thêm, xóa và sửa thẻ thư viện
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


        public bool XoaTheThuVien(int maThe)
        {
            try
            {
                TheThuVien ttvXoa = db.TheThuViens.Where(t => t.MaThe == maThe).FirstOrDefault();
                db.TheThuViens.DeleteOnSubmit(ttvXoa);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Chỉ sửa ngày lập, ngày hết hạn, ghi chú và tình trạng
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
