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

        private string _tenSach;
        private string _theLoai;
        private string _tacGia;
        private string _nhaXuatBan;
        private string _namXuatBan;
        private Image _anhBia;

        #region Properties
        [Category("Custom Props")]
        public string TenSach
        {
            get { return _tenSach; }
            set { _tenSach = value; lblTenSach.Text = value; }
        }

        [Category("Custom Props")]
        public string TheLoai
        {
            get { return _theLoai; }
            set { _theLoai = value; lblTheLoai.Text = value; }
        }

        [Category("Custom Props")]
        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; lblTacGia.Text = value; }
        }

        [Category("Custom Props")]
        public string NhaXuatBan
        {
            get { return _nhaXuatBan; }
            set { _nhaXuatBan = value; lblNhaXuatBan.Text = value; }
        }

        [Category("Custom Props")]
        public string NamXuatBan
        {
            get { return _namXuatBan; }
            set { _namXuatBan = value; lblNamXuatBan.Text = value; }
        }

        [Category("Custom Props")]
        public Image AnhBia
        {
            get { return _anhBia; }
            set { _anhBia = value; }
        }
        #endregion

        public void LoadAnhBia()
        {
            pcbAnhBia.Image = DoiKichThuocAnh(_anhBia, pcbAnhBia.Width, pcbAnhBia.Height);
        }

        private Image DoiKichThuocAnh(Image hinhAnh, int chieuRong, int chieuCao)
        {
            return (Image)(new Bitmap(hinhAnh, new Size(chieuRong, chieuCao)));
        }
    }
}
