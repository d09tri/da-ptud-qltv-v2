﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TheLoaiDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        public TheLoaiDAL() { }

        public List<TheLoai> GetDSTheLoai()
        {
            return db.TheLoais.ToList();
        }

        public TheLoai GetTheLoaiTheoMaTheLoai(int maTheLoai)
        {
            return db.TheLoais.First(t => t.MaTheLoai == maTheLoai);
        }
    }
}
