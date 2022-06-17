using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhieuMuonDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();
        HelperDAL helperDAL = new HelperDAL();

        public PhieuMuonDAL() { }

        public List<PhieuMuon> GetDSPhieuMuon()
        {
            return db.PhieuMuons.ToList();
        }

        public List<PhieuMuon> GetDSPhieuMuonTheoMaTheThuVien(int maThe)
        {
            return db.PhieuMuons.Where(t => t.MaThe == maThe).ToList();
        }

        public List<view_DSPhieuMuon> GetDSView_DSPhieuMuonTheoTinhTrang(bool tinhTrang)
        {
            return db.view_DSPhieuMuons.Where(t => t.TinhTrang == tinhTrang).ToList();
        }

        public List<view_DSPhieuMuon> GetDSView_DSPhieuMuon()
        {
            return db.view_DSPhieuMuons.ToList();
        }

        public view_DSPhieuMuon GetView_DSPhieuMuonTheoMaPhieuMuon(int maPhieuMuon)
        {
            return db.view_DSPhieuMuons.First(t => t.MaPhieuMuon == maPhieuMuon);
        }

        public bool TaoPhieuMuon(PhieuMuon pm)
        {
            try
            {
                db.PhieuMuons.InsertOnSubmit(pm);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaTinhTrangPhieuMuon(int maPhieuMuon, bool tinhTrang)
        {
            try
            {
                PhieuMuon pmSua = db.PhieuMuons.First(t => t.MaPhieuMuon == maPhieuMuon);
                pmSua.TinhTrang = tinhTrang;
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
