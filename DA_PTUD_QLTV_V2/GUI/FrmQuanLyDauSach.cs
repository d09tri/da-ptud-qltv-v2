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

        int _maNXB = 0;
        int _maTheLoai = 0;

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

            cmbLocTheLoai.DataSource = tlBLL.GetDSTheLoai();
            cmbLocTheLoai.DisplayMember = "TenTheLoai";
            cmbLocTheLoai.ValueMember = "MaTheLoai";

            cmbNhaXuatBan.DataSource = nxbBLL.GetDSNhaXuatBan();
            cmbNhaXuatBan.DisplayMember = "TenNXB";
            cmbNhaXuatBan.ValueMember = "MaNXB";

            cmbLocNhaXuatBan.DataSource = nxbBLL.GetDSNhaXuatBan();
            cmbLocNhaXuatBan.DisplayMember = "TenNXB";
            cmbLocNhaXuatBan.ValueMember = "MaNXB";

            LoadDuLieuDauSach(dsBLL.GetDSView_DSDauSach());

            string duongDan = helper.LayDuongDanAnhBia() + "page-not-found.png";
            Image anhBia = helper.LayAnhBiaDauSach(duongDan, picAnhBia.Width, picAnhBia.Height);
            picAnhBia.Image = anhBia;
        }

        private void FrmQuanLyDauSach_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void cmbLocTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maTheLoai = cmbLocTheLoai.SelectedValue.ToString();

            if (maTheLoai.Equals("DTO.TheLoai"))
                return;

            if (_maNXB == 0)
            {
                LoadDuLieuDauSach(dsBLL.GetDSView_DSDauSachTheoTheLoai(int.Parse(maTheLoai)));
            }
            else
            {
                LoadDuLieuDauSach(dsBLL.GetDSView_DSDauSachTongHop(int.Parse(maTheLoai), _maNXB));
            }

            _maTheLoai = int.Parse(maTheLoai);
        }

        private void cmbLocNhaXuatBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNXB = cmbLocNhaXuatBan.SelectedValue.ToString();

            if (maNXB.Equals("DTO.NhaXuatBan"))
                return;

            if (_maTheLoai == 0)
            {
                LoadDuLieuDauSach(dsBLL.GetDSView_DSDauSachTheoNhaXuatBan(int.Parse(maNXB)));
            }
            else
            {
                LoadDuLieuDauSach(dsBLL.GetDSView_DSDauSachTongHop(_maTheLoai, int.Parse(maNXB)));
            }

            _maNXB = int.Parse(maNXB);
        }

        private void dgvDSDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int rowIndex = dgvDSDauSach.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvDSDauSach.Rows[rowIndex];  

            int maSach = int.Parse(selectedRow.Cells[0].Value.ToString());
            DauSach ds = dsBLL.GetDLDauSachTheoMa(maSach);

            lblMaSach.Text = ds.MaSach.ToString();
            txtTenSach.Text = ds.TenSach;
            txtAnhBia.Text = ds.BiaSach;
            txtTacGia.Text = ds.TacGia;
            cmbTheLoai.Text = selectedRow.Cells[3].Value.ToString();
            cmbNhaXuatBan.Text = selectedRow.Cells[4].Value.ToString();
            dtpNamXuatBan.Value = (DateTime)ds.NamXB;

            string duongDan = helper.LayDuongDanAnhBia() + ds.BiaSach;
            Image anhBia = helper.LayAnhBiaDauSach(duongDan, picAnhBia.Width, picAnhBia.Height);
            picAnhBia.Image = anhBia;
        }
    }
}
