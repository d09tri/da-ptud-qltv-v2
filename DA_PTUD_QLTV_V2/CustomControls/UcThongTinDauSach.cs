using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class UcThongTinDauSach : UserControl
    {
        public UcThongTinDauSach()
        {
            InitializeComponent();
        }

        public void LoadThongTinDauSach(string tenSach, string theLoai, string tacGia, string nhaXuatBan, string namXuatBan, Image anhBia)
        {
            lblTenSach.Text = tenSach;
            lblTheLoai.Text = theLoai;
            lblTacGia.Text = tacGia;
            lblNhaXuatBan.Text = nhaXuatBan;
            lblNamXuatBan.Text = namXuatBan;
            pcbAnhBia.Image = anhBia;
        }
    }
}
