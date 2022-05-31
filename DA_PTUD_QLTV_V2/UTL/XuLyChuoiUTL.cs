using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTL
{
    public class XuLyChuoiUTL
    {
        /// <summary>
        /// Tạo tên viết từ tên thể loại, sách và được sử dụng cho việc
        /// sinh ra mã của bản in của đầu sách đó, thuộc thể loại đó
        /// </summary>
        /// <param name="tenDayDu">Tên đầy đủ để chuyển sang tên viết tắt</param>
        /// <param name="doDai">Số lượng chữ cái viết tắt</param>
        /// <returns></returns>
        public string TaoTenVietTat(string tenDayDu, int doDai)
        {
            string tenVietTat = string.Empty;
            string[] arrTu = tenDayDu.Split(' ');

            for (int i = 0; i < doDai; i++)
            {
                tenVietTat += arrTu[i].Substring(0, 1).ToUpper();
            }

            return tenVietTat;
        }
    }
}
