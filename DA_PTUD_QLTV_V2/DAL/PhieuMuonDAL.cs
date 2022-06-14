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

        public List<view_DSPhieuMuon> GetDSView_DSPhieuMuonTheoTinhTrang(bool tinhTrang)
        {
            return db.view_DSPhieuMuons.Where(t => t.TinhTrang == tinhTrang).ToList();
        }

        public view_DSPhieuMuon GetView_DSPhieuMuonTheoMa(int maPhieuMuon)
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
    }
}
