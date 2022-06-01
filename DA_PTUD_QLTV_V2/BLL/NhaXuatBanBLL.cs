﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhaXuatBanBLL
    {
        NhaXuatBanDAL nxbDAL = new NhaXuatBanDAL();

        public NhaXuatBanBLL() { }

        public List<NhaXuatBan> GetDSNhaXuatBan()
        {
            return nxbDAL.GetDSNhaXuatBan();
        }

        public string GetTenNhaXuatBanTuMa(int maNXB)
        {
            return nxbDAL.GetTenNhaXuatBanTuMa(maNXB);
        }
    }
}
