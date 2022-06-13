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
    }
}
