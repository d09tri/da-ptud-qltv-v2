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
        /// Một đầu sách bao gồm nhiều bản in vì vậy mỗi bản in sẽ có một mã bản in khác nhau
        /// Mã bản in có cấu trúc như sau: tên viết tắt thể loại (2 chữ cái) của đầu sách bản in đó_số thứ tự
        /// Ví dụ: 
        /// Thể loại chính trị - pháp luật, bản in số thứ tự 1 -> CT_001
        /// </summary>
        /// <param name="tenTheLoai">Tên thể loại</param>
        /// <returns>Tên viết tắt thể loại</returns>
        public string TaoTenVietTatTheLoai(string tenTheLoai)
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
