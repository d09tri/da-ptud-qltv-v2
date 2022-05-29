using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTL
{
    public class XuLyChuoiUTL
    {
        public string TaoMaTheLoaiChoBanIn(string tenTheLoai)
        {
            string maTheLoai = string.Empty;
            string[] arrTenTheLoai = tenTheLoai.Split(' ');

            for (int i = 0; i < 2; i++)
            {
                maTheLoai += arrTenTheLoai[i].Substring(0, 1);
            }

            return maTheLoai;
        }
    }
}
