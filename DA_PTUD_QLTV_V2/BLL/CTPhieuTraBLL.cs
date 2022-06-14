using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CTPhieuTraBLL
    {
        CTPhieuTraDAL ctptDAL = new CTPhieuTraDAL();

        public CTPhieuTraBLL() { }

        public List<ChiTietPhieuTra> GetDSCTPhieuTra()
        {
            return ctptDAL.GetDSCTPhieuTra();
        }

        public bool ThemCTPhieuTra(ChiTietPhieuTra ctpt)
        {
            return ctptDAL.ThemCTPhieuTra(ctpt);
        }
    }
}
