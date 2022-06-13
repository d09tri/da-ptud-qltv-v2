using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PhieuMuonBLL
    {
        PhieuMuonDAL pmDAL = new PhieuMuonDAL();

        public PhieuMuonBLL() { }

        public List<PhieuMuon> GetDSPhieuMuon()
        {
            return pmDAL.GetDSPhieuMuon();
        }

        public bool TaoPhieuMuon(PhieuMuon pm)
        {
            return pmDAL.TaoPhieuMuon(pm);
        }
    }
}
