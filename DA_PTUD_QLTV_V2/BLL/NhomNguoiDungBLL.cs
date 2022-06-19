using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhomNguoiDungBLL
    {
        NhomNguoiDungDAL nndDAL = new NhomNguoiDungDAL();
        public NhomNguoiDungBLL() { }

        public List<NhomNguoiDung> GetDSNhomNguoiDung()
        {
            return nndDAL.GetDSNhomNguoiDung();
        }
    }
}
