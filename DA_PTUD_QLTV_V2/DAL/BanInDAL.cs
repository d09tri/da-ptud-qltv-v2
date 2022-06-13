using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BanInDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public BanInDAL() { }

        public List<BanIn> GetDSBanIn(int maSach)
        {
            return db.BanIns.Where(t => t.MaSach == maSach).ToList();
        }

        public bool ThemBanIn(BanIn bi)
        {
            try
            {
                db.BanIns.InsertOnSubmit(bi);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ThemDSBanIn(List<BanIn> lst)
        {
            foreach (BanIn biItem in lst)
            {
                if (ThemBanIn(biItem))
                    continue;
                else
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Nếu có bản in tồn tại (được mượn) bởi một hoặc nhiều chi tiết phiếu mượn thì return true
        /// </summary>
        /// <param name="maBanIn">Mã bản in cần được kiểm tra khóa ngoại</param>
        /// <returns></returns>
        public bool KiemTraKhoaNgoaiBanIn(int maBanIn)
        {
            int soLuong = 0;
            try
            {
                soLuong = db.ChiTietPhieuMuons.Where(t => t.MaBanIn == maBanIn).ToList().Count;
            }
            catch { }

            if (soLuong > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Thay đổi cho phù hợp với yêu cầu xóa khác
        /// </summary>
        /// <param name="maBanIn"></param>
        /// <returns>
        /// - -1: Bản in có khóa ngoại tham chiếu
        /// - 0: Xóa bản in thất bại
        /// - 1: Xóa bản in thành công
        /// </returns>
        public int XoaBanIn(int maBanIn)
        {
            if (KiemTraKhoaNgoaiBanIn(maBanIn))
                return -1;
            try
            {
                BanIn bi = db.BanIns.First(t => t.MaBanIn == maBanIn);
                db.BanIns.DeleteOnSubmit(bi);
                db.SubmitChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool SuaBanIn(BanIn bi)
        {
            try
            {
                BanIn biSua = db.BanIns.First(t => t.MaBanIn == bi.MaBanIn);
                biSua.TrangThai = bi.TrangThai;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public BanIn GetBanInTheoMa(int maBanIn)
        {
            try
            {
                return db.BanIns.First(t => t.MaBanIn == maBanIn);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
