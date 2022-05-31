using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Helper
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

        public Image LayAnhBiaDauSach(string duongDan, int chieuRong, int chieuCao)
        {
            Image i = Image.FromFile(duongDan);
            return (Image)(new Bitmap(i, new Size(chieuRong, chieuCao)));
        }

        public string LayDuongDanAnhBia()
        {
            string curDirect = Environment.CurrentDirectory;
            string direct = curDirect.Substring(0, curDirect.Length - 9) + "Resources/AnhBia/";
            return direct;
        }
    }
}
