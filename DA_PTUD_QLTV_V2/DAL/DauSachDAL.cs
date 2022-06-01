using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DauSachDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public DauSachDAL() { }

        public List<DauSach> GetDSDauSach()
        {
            return db.DauSaches.ToList();
        }

        public List<DauSach> GetDSDauSachTheoTheLoai(int maTheLoai)
        {
            return db.DauSaches.Where(t => t.MaTheLoai == maTheLoai).ToList();
        }

        public List<DauSach> GetDSDauSachTheoNhaXuatBan(int maNXB)
        {
            return db.DauSaches.Where(t => t.MaNXB == maNXB).ToList();
        }

        public List<DauSach> GetDSDauSachTongHop(int maTheLoai, int maNXB)
        {
            if (maTheLoai == 0)
                return GetDSDauSachTheoNhaXuatBan(maNXB);
            else if (maNXB == 0)
                return GetDSDauSachTheoTheLoai(maTheLoai);
            else
                return db.DauSaches.Where(t => t.MaTheLoai == maTheLoai && t.MaNXB == maNXB).ToList();
        }

        public DauSach GetDLDauSachTheoMa(int maSach)
        {
            return db.DauSaches.First(t => t.MaSach == maSach);
        }
    }
}
