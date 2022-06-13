using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CTPhieuMuonBLL
    {
        CTPhieuMuonDAL ctpmDAL = new CTPhieuMuonDAL();

        public CTPhieuMuonBLL() { }

        public List<ChiTietPhieuMuon> GetDSCTPhieuMuon()
        {
            return ctpmDAL.GetDSCTPhieuMuon();
        }

        public bool ThemCTPhieuMuon(ChiTietPhieuMuon ctpm)
        {
            return ctpmDAL.ThemCTPhieuMuon(ctpm);
        }
    }
}
