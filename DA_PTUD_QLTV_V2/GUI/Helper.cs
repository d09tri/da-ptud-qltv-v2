using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;
using System.Windows.Forms;

namespace GUI
{
    public class Helper
    {
        HelperBLL helperBLL = new HelperBLL();

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

        public Image LayAnhBiaDauSach(string duongDan)
        {
            return Image.FromFile(duongDan);
        }

        public string LayDuongDanAnhBia()
        {
            string curDirect = Environment.CurrentDirectory;
            string direct = curDirect.Substring(0, curDirect.Length - 9) + "Resources/AnhBia/";
            return direct;
        }

        /// <summary>
        /// Lấy mã cuối cùng vừa được thêm vào sau khi thêm một dòng dữ liệu
        /// </summary>
        /// <param name="tenBang">Tên bảng cần lấy mã cuối cùng</param>
        /// <returns>Mã cuối cùng</returns>
        public int LayThongTinMaVuaThem(string tenBang)
        {
            return helperBLL.LayThongTinMaVuaThem(tenBang);
        }

        public void LoadChildForm(Form frm, Panel pnl)
        {
            pnl.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnl.Controls.Add(frm);
            pnl.Tag = frm;

            frm.Show();
        }
    }
}
