﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhieuTraDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();
        HelperDAL helperDAL = new HelperDAL();

        public PhieuTraDAL() { }

        public List<PhieuTra> GetDSPhieuTra()
        {
            return db.PhieuTras.ToList();
        }

        public bool TaoPhieuTra(PhieuTra pt)
        {
            try
            {
                db.PhieuTras.InsertOnSubmit(pt);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
