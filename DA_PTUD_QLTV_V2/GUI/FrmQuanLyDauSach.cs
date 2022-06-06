using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class FrmQuanLyDauSach : Form
    {
        TheLoaiBLL tlBLL = new TheLoaiBLL();
        NhaXuatBanBLL nxbBLL = new NhaXuatBanBLL();
        DauSachBLL dsBLL = new DauSachBLL();
        Helper helper = new Helper();

        List<view_DSDauSach> dsLst = new List<view_DSDauSach>();

        public FrmQuanLyDauSach()
        {
            InitializeComponent();
            dgvDSDauSach.AutoGenerateColumns = false;
        }

        private void LoadDuLieuDauSach(List<view_DSDauSach> dl)
        {
            dsLst = dl;
            dgvDSDauSach.DataSource = dsLst;
        }

        private void LoadDuLieu()
        {
            cmbTheLoai.DataSource = tlBLL.GetDSTheLoai();
            cmbTheLoai.DisplayMember = "TenTheLoai";
            cmbTheLoai.ValueMember = "MaTheLoai";

            cmbNhaXuatBan.DataSource = nxbBLL.GetDSNhaXuatBan();
            cmbNhaXuatBan.DisplayMember = "TenNXB";
            cmbNhaXuatBan.ValueMember = "MaNXB";

            LoadDuLieuDauSach(dsBLL.GetDSView_DSDauSach());

            string duongDan = helper.LayDuongDanAnhBia() + "page-not-found.png";
            Image anhBia = helper.LayAnhBiaDauSach(duongDan, picAnhBia.Width, picAnhBia.Height);
            picAnhBia.Image = anhBia;
        }

        private void FrmQuanLyDauSach_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
    }
}
