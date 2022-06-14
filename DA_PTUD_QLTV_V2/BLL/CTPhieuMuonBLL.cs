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

        public List<ChiTietPhieuMuon> GetDSCTPhieuMuonTheoMa(int maPhieuMuon)
        {
            return ctpmDAL.GetDSCTPhieuMuonTheoMa(maPhieuMuon);
        }

        public ChiTietPhieuMuon GetCTPhieuMuonTheoMaPhieuMuonVaMaBanIn(int maPhieuMuon, int maBanIn)
        {
            return ctpmDAL.GetCTPhieuMuonTheoMaPhieuMuonVaMaBanIn(maPhieuMuon, maBanIn);
        }

        public bool ThemCTPhieuMuon(ChiTietPhieuMuon ctpm)
        {
            return ctpmDAL.ThemCTPhieuMuon(ctpm);
        }

        public bool SuaCTPhieuMuon(ChiTietPhieuMuon ctpm)
        {
            return ctpmDAL.SuaCTPhieuMuon(ctpm);
        }
    }
}
