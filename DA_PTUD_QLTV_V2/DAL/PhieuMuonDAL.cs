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
