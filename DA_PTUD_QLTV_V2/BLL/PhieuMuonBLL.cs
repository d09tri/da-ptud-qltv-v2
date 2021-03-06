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

        public List<PhieuMuon> GetDSPhieuMuonTheoMaTheThuVien(int maThe)
        {
            return pmDAL.GetDSPhieuMuonTheoMaTheThuVien(maThe);
        }

        public List<view_DSPhieuMuon> GetDSView_DSPhieuMuonTheoTinhTrang(bool tinhTrang)
        {
            return pmDAL.GetDSView_DSPhieuMuonTheoTinhTrang(tinhTrang);
        }

        public view_DSPhieuMuon GetView_DSPhieuMuonTheoMa(int maPhieuMuon)
        {
            return pmDAL.GetView_DSPhieuMuonTheoMaPhieuMuon(maPhieuMuon);
        }

        public List<view_DSPhieuMuon> GetDSView_DSPhieuMuon()
        {
            return pmDAL.GetDSView_DSPhieuMuon();
        }

        public bool TaoPhieuMuon(PhieuMuon pm)
        {
            return pmDAL.TaoPhieuMuon(pm);
        }

        public bool SuaTinhTrangPhieuMuon(int maPhieuMuon, bool tinhTrang)
        {
            return pmDAL.SuaTinhTrangPhieuMuon(maPhieuMuon, tinhTrang);
        }
    }
}
