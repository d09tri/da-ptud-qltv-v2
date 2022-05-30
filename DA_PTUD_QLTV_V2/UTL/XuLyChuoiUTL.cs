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
        /// 
        /// </summary>
        /// <param name="tenDayDu"></param>
        /// <param name="doDai"></param>
        /// <returns></returns>
        public string TaoTenVietTat(string tenDayDu, int doDai)
        {
            string tenVietTat = string.Empty;
            string[] arrTu = tenDayDu.Split(' ');

            for (int i = 0; i < doDai; i++)
            {
                tenVietTat += arrTu[i].Substring(0, 1);
            }

            return tenVietTat;
        }
    }
}
