using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HelperBLL
    {
        HelperDAL helperDAL = new HelperDAL();

        public int LayThongTinMaVuaThem(string tenBang)
        {
            return helperDAL.LayThongTinMaVuaThem(tenBang);
        }
    }
}
