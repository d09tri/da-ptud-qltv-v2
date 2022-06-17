using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CTPhieuMuonDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public CTPhieuMuonDAL() { }

        public List<ChiTietPhieuMuon> GetDSCTPhieuMuon()
        {
            return db.ChiTietPhieuMuons.ToList();
        }

        public List<ChiTietPhieuMuon> GetDSCTPhieuMuonTheoMaPhieuMuon(int maPhieuMuon)
        {
            return db.ChiTietPhieuMuons.Where(t => t.MaPhieuMuon == maPhieuMuon && t.NgayTra == null).ToList();
        }

        public ChiTietPhieuMuon GetCTPhieuMuonTheoMaPhieuMuonVaMaBanIn(int maPhieuMuon, int maBanIn)
        {
            return db.ChiTietPhieuMuons.First(t => t.MaPhieuMuon == maPhieuMuon && t.MaBanIn == maBanIn);
        }

        public bool ThemCTPhieuMuon(ChiTietPhieuMuon ctpm)
        {
            try
            {
                db.ChiTietPhieuMuons.InsertOnSubmit(ctpm);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaCTPhieuMuon(ChiTietPhieuMuon ctpm)
        {
            try
            {
                ChiTietPhieuMuon ctpmSua = db.ChiTietPhieuMuons.First(t => t.MaPhieuMuon == ctpm.MaPhieuMuon && t.MaBanIn == ctpm.MaBanIn);
                ctpmSua.NgayTra = ctpm.NgayTra;
                ctpmSua.GhiChu = ctpm.GhiChu;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
