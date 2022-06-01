using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TheLoaiBLL
    {
        TheLoaiDAL tlDAL = new TheLoaiDAL();

        public TheLoaiBLL() { }

        public List<TheLoai> GetDSTheLoai()
        {
            return tlDAL.GetDSTheLoai();
        }

        public string GetTenTheLoaiTuMa(int maTheLoai)
        {
            return tlDAL.GetTenTheLoaiTuMa(maTheLoai);
        }
    }
}
