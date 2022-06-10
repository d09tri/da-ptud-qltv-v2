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

        #region view_DSDauSach
        public List<view_DSDauSach> GetDSView_DSDauSach()
        {
            return dsDAL.GetDSView_DSDauSach();
        }

        public List<view_DSDauSach> GetDSView_DSDauSachTheoTheLoai(int maTheLoai)
        {
            return dsDAL.GetDSView_DSDauSachTheoTheLoai(maTheLoai);
        }

        public List<view_DSDauSach> GetDSView_DSDauSachTheoNhaXuatBan(int maNXB)
        {
            return dsDAL.GetDSView_DSDauSachTheoNhaXuatBan(maNXB);
        }

        public List<view_DSDauSach> GetDSView_DSDauSachTongHop(int maTheLoai, int maNXB)
        {
            return dsDAL.GetDSView_DSDauSachTongHop(maTheLoai, maNXB);
        }
        #endregion

        #region Xử lý thêm xóa sửa cơ bản
        public bool ThemDauSach(DauSach ds)
        {
            return dsDAL.ThemDauSach(ds);
        }

        public bool XoaDauSach(int mads)
        {
            return dsDAL.XoaDauSach(mads);
        }

        public bool SuaDauSach(DauSach ds)
        {
            return dsDAL.SuaDauSach(ds);
        }
        #endregion

        public DauSach GetThongTinDauSachTheoMaBanIn(int maBanIn)
        {
            try
            {
                return dsDAL.GetThongTinDauSachTheoMaBanIn(maBanIn);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
