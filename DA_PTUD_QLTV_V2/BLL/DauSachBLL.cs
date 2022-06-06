using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DauSachBLL
    {
        DauSachDAL dsDAL = new DauSachDAL();

        public DauSachBLL() { }

        public List<DauSach> GetDSDauSach()
        {
            return dsDAL.GetDSDauSach();
        }

        public List<view_DSDauSach> GetDSView_DSDauSach()
        {
            return dsDAL.GetDSView_DSDauSach();
        }

        public List<DauSach> GetDSDauSachTheoTheLoai(int maTheLoai)
        {
            return dsDAL.GetDSDauSachTheoTheLoai(maTheLoai);
        }

        public List<DauSach> GetDSDauSachTheoNhaXuatBan(int maNXB)
        {
            return dsDAL.GetDSDauSachTheoNhaXuatBan(maNXB);
        }

        public List<DauSach> GetDSDauSachTongHop(int maTheLoai, int maNXB)
        {
            return dsDAL.GetDSDauSachTongHop(maTheLoai, maNXB);
        }

        public DauSach GetDLDauSachTheoMa(int maSach)
        {
            return dsDAL.GetDLDauSachTheoMa(maSach);
        }
    }
}
