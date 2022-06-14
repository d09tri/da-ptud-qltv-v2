using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CTPhieuTraDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();
        BanInDAL biDAL = new BanInDAL();
        CTPhieuMuonDAL ctpmDAL = new CTPhieuMuonDAL();
        PhieuMuonDAL pmDAL = new PhieuMuonDAL();

        public CTPhieuTraDAL() { }

        public List<ChiTietPhieuTra> GetDSCTPhieuTra()
        {
            return db.ChiTietPhieuTras.ToList();
        }

        /// <summary>
        /// Khi thêm một chi tiết phiếu trả, hệ thống sẽ làm những việc như sau:
        /// 1. Cập nhật lại trạng thái bản in từ true (đang mượn) thành false
        /// 2. Cập nhật lại chi tiết phiếu mượn của bản in đó với ngày trả là ngày hôm nay
        /// 2.1. Nếu ngày trả > ngày hẹn trả thì cập nhật ghi chú thành "Trả trễ", ngược lại
        /// thì là "Đã trả"
        /// 2.2. Nếu tất cả các chi tiết phiếu mượn đã có ngày trả thì cập nhật tình trạng của
        /// phiếu mượn đó thành true (đã trả)
        /// </summary>
        /// <param name="ctpt"></param>
        /// <returns></returns>
        public bool ThemCTPhieuTra(ChiTietPhieuTra ctpt)
        {
            try
            {
                db.ChiTietPhieuTras.InsertOnSubmit(ctpt);
                db.SubmitChanges();

                BanIn bi = new BanIn()
                {
                    MaBanIn = ctpt.MaBanIn,
                    TrangThai = false
                };

                biDAL.SuaBanIn(bi);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
