using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PhieuTraBLL
    {
        PhieuTraDAL ptDAL = new PhieuTraDAL();

        public PhieuTraBLL() { }

        public List<PhieuTra> GetDSPhieuTra()
        {
            return ptDAL.GetDSPhieuTra();
        }

        public List<view_DSPhieuTra> GetDSView_DSPhieuTra()
        {
            return ptDAL.GetDSView_DSPhieuTra();
        }

        public bool TaoPhieuTra(PhieuTra pt)
        {
            return ptDAL.TaoPhieuTra(pt);
        }
    }
}
