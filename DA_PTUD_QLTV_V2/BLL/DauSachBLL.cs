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

        public List<DauSach> GetDSDauSachTheoMaTheLoai(int maTheLoai)
        {
            return dsDAL.GetDSDauSachTheoMaTheLoai(maTheLoai);
        }

        public List<DauSach> GetDSDauSachTheoMaNXB(int maNXB)
        {
            return dsDAL.GetDSDauSachTheoMaNXB(maNXB);
        }

        public List<DauSach> GetDSDauSachTongHop(int maTheLoai, int maNXB)
        {
            return dsDAL.GetDSDauSachTongHop(maTheLoai, maNXB);
        }

        public DauSach GetDauSachTheoMa(int maSach)
        {
            return dsDAL.GetDauSachTheoMa(maSach);
        }

        #region view_DSDauSach
        public List<view_DSDauSach> GetDSView_DSDauSach()
        {
            return dsDAL.GetDSView_DSDauSach();
        }

        public List<view_DSDauSach> GetDSView_DSDauSachTheoMaTheLoai(int maTheLoai)
        {
            return dsDAL.GetDSView_DSDauSachTheoMaTheLoai(maTheLoai);
        }

        public List<view_DSDauSach> GetDSView_DSDauSachTheoMaNhaXuatBan(int maNXB)
        {
            return dsDAL.GetDSView_DSDauSachTheoMaNhaXuatBan(maNXB);
        }

        public List<view_DSDauSach> GetDSView_DSDauSachTongHop(int maTheLoai, int maNXB)
        {
            return dsDAL.GetDSView_DSDauSachTongHop(maTheLoai, maNXB);
        }
        #endregion

        #region Xử lý thêm, xóa và sửa cơ bản
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

        public DauSach GetDauSachTheoMaBanIn(int maBanIn)
        {
            try
            {
                return dsDAL.GetDauSachTheoMaBanIn(maBanIn);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
