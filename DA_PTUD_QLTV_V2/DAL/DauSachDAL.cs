using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DauSachDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public DauSachDAL() { }

        public List<DauSach> GetDSDauSach()
        {
            return db.DauSaches.ToList();
        }

        public List<DauSach> GetDSDauSachTheoTheLoai(int maTheLoai)
        {
            return db.DauSaches.Where(t => t.MaTheLoai == maTheLoai).ToList();
        }

        public List<DauSach> GetDSDauSachTheoNhaXuatBan(int maNXB)
        {
            return db.DauSaches.Where(t => t.MaNXB == maNXB).ToList();
        }

        public List<DauSach> GetDSDauSachTongHop(int maTheLoai, int maNXB)
        {
            return db.DauSaches.Where(t => t.MaTheLoai == maTheLoai && t.MaNXB == maNXB).ToList();
        }

        public DauSach GetDLDauSachTheoMa(int maSach)
        {
            return db.DauSaches.First(t => t.MaSach == maSach);
        }

        #region view_DSDauSach
        public List<view_DSDauSach> GetDSView_DSDauSach()
        {
            return db.view_DSDauSaches.ToList();
        }

        /// <summary>
        /// ÁP DỤNG TƯƠNG TỰ ĐỐI VỚI NHÀ XUẤT BẢN VÀ TỔNG HỢP
        /// 
        /// Về cơ bản, trong view_DSDauSach không có chứa mã thể loại mà chỉ có tên thể loại
        /// nên bắt buộc phải tái sử dụng lại GetDSDauSachTheoTheLoai
        /// Phần return có thể hiểu như là một câu truy vấn trong SQL như sau:
        /// - select * from view_DSDauSach where MaSach in (lst)
        /// </summary>
        /// <param name="maTheLoai">Mã thể loại</param>
        /// <returns>
        /// Danh sách view_DSDauSach thuộc mã thể loại đó
        /// </returns>
        public List<view_DSDauSach> GetDSView_DSDauSachTheoTheLoai(int maTheLoai)
        {
            List<DauSach> lst = GetDSDauSachTheoTheLoai(maTheLoai);
            return db.view_DSDauSaches.Where(t => lst.Select(y => y.MaSach).Contains(t.MaSach)).ToList();
        }

        public List<view_DSDauSach> GetDSView_DSDauSachTheoNhaXuatBan(int maNXB)
        {
            List<DauSach> lst = GetDSDauSachTheoNhaXuatBan(maNXB);
            return db.view_DSDauSaches.Where(t => lst.Select(y => y.MaSach).Contains(t.MaSach)).ToList();
        }

        public List<view_DSDauSach> GetDSView_DSDauSachTongHop(int maTheLoai, int maNXB)
        {
            List<DauSach> lst = GetDSDauSachTongHop(maTheLoai, maNXB);
            return db.view_DSDauSaches.Where(t => lst.Select(y => y.MaSach).Contains(t.MaSach)).ToList();
        }
        #endregion
    }
}
