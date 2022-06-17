using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public NhanVienDAL() { }

        public NhanVien GetNhanVienTheoMaNhanVien(int maNhanVien)
        {
            return db.NhanViens.First(t => t.MaNhanVien == maNhanVien);
        }

        public List<NhanVien> GetDSNhanVien()
        {
            return db.NhanViens.Select(t => t).ToList();
        }

        public List<NhanVien> GetDSNhanVienTheoTen(string tenNhanVien)
        {
            return db.NhanViens.Where(t => t.TenNhanVien.Contains(tenNhanVien)).ToList();
        }

        #region Xử lý thêm, xóa và sửa cơ bản
        public bool ThemNhanVien(NhanVien nv)
        {
            try
            {
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool XoaNhanVien(int maNhanVien)
        {
            try
            {
                NhanVien nvXoa = db.NhanViens.Where(t => t.MaNhanVien == maNhanVien).FirstOrDefault();
                db.NhanViens.DeleteOnSubmit(nvXoa);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaNhanVien(NhanVien nv)
        {
            try
            {
                NhanVien nvSua = db.NhanViens.Where(t => t.MaNhanVien == nv.MaNhanVien).FirstOrDefault();
                nvSua.TenNhanVien = nv.TenNhanVien;
                nvSua.NgaySinh = nv.NgaySinh;
               
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
