using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BanInBLL
    {
        BanInDAL biDAL = new BanInDAL();

        public BanInBLL() { }

        public List<BanIn> GetDSBanIn(int maSach)
        {
            return biDAL.GetDSBanIn(maSach);
        }

        public bool ThemBanIn(BanIn bi)
        {
            return biDAL.ThemBanIn(bi);
        }

        public bool ThemDSBanIn(List<BanIn> lst)
        {
            return biDAL.ThemDSBanIn(lst);
        }

        public int XoaBanIn(int maBanIn)
        {
            return biDAL.XoaBanIn(maBanIn);
        }
       
        public bool SuaBanIn(BanIn bi)
        {
            return biDAL.SuaBanIn(bi);
        }
    }
}
