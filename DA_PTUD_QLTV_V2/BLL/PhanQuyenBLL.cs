using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL pqDAL = new PhanQuyenDAL();

        public PhanQuyenBLL() { }

        public List<view_DSPhanQuyen> GetDSView_DSPhanQuyenTheoMaNhom(int maNhom)
        {
            return pqDAL.GetDSView_DSPhanQuyenTheoMaNhom(maNhom);
        }
    }
}
