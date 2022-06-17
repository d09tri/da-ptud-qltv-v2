using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DocGiaDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();
        TheThuVienDAL ttvDAL = new TheThuVienDAL();

        public DocGiaDAL() { }

        public List<DocGia> GetDSDocGia()
        {
            return db.DocGias.ToList();
        }

        public List<DocGia> GetDSDocGiaTheoTen(string tenDocGia)
        {
            return db.DocGias.Where(t => t.TenDocGia.Contains(tenDocGia)).ToList();
        }

        public List<DocGia> GetDSDocGiaChuaCoTheThuVien()
        {
            List<TheThuVien> lst = ttvDAL.GetDSTheThuVien();
            return db.DocGias.Where(t => !lst.Select(y => y.MaDocGia).Contains(t.MaDocGia)).ToList();
        }

        #region Xử lý thêm, xóa và sửa cơ bản
        public bool ThemDocGia(DocGia dg)
        {
            try
            {
                db.DocGias.InsertOnSubmit(dg);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool XoaDocGia(int maDocGia)
        {
            try
            {
                DocGia dgXoa = db.DocGias.Where(t => t.MaDocGia == maDocGia).FirstOrDefault();
                db.DocGias.DeleteOnSubmit(dgXoa);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaDocGia(DocGia dg)
        {
            try
            {
                DocGia dgSua = db.DocGias.Where(t => t.MaDocGia == dg.MaDocGia).FirstOrDefault();
                dgSua.TenDocGia = dg.TenDocGia;
                dgSua.NgaySinh = dg.NgaySinh;
                dgSua.CMND = dg.CMND;
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
