using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmTest : Form
    {
        Helper helper = new Helper();

        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            string duongDan = helper.LayDuongDanAnhBia() + "Ban-ve-tu-do.jpg";
            Image anhBia = helper.LayAnhBiaDauSach(duongDan, 170, 178);
            ucThongTinDauSach.LoadThongTinDauSach("Tìm hiểu di tích lịch sử các nhà tù trong cuộc kháng chiến chống Pháp và Mỹ", "Chính trị - pháp luật", "John Stuart Mill", "Nhà xuất bản Tổng hợp Thành phố Hồ Chí Minh", "2012", anhBia);
        }
    }
}
