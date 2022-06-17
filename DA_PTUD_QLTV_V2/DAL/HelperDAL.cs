using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HelperDAL
    {
        DB_PTUD_QLTV_V2DataContext db = new DB_PTUD_QLTV_V2DataContext();

        /// <summary>
        /// Lấy thông tin mã cuối cùng vừa được thêm của bảng
        /// </summary>
        /// <param name="tenBang">Tên bảng cần lấy thông tin mã cuối cùng</param>
        /// <returns>Mã cuối cùng</returns>
        public int LayThongTinMaVuaThem(string tenBang)
        {
            string query = string.Format("Select IDENT_CURRENT ('{0}')", tenBang);
            return Convert.ToInt32(db.ExecuteQuery<decimal>(query, new object[0]).FirstOrDefault());
        }


    }
}
