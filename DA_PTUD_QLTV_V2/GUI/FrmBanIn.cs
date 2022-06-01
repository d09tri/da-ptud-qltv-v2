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
    public partial class FrmBanIn : Form
    {
        TheLoaiBLL tlBLL = new TheLoaiBLL();
        NhaXuatBanBLL nxbBLL = new NhaXuatBanBLL();
        DauSachBLL dsBLL = new DauSachBLL();
        Helper helper = new Helper();

        List<DauSach> dsLst = new List<DauSach>();
        DauSach ds = new DauSach();
        int _maTheLoai = 0;
        int _maNXB = 0;
        int _maSach = 0;

        public FrmBanIn()
        {
            InitializeComponent();
            dgvDSDauSach.AutoGenerateColumns = false;
        }

        public void LoadDuLieuDauSach(List<DauSach> dl)
        {
            dsLst = dl;
            dgvDSDauSach.DataSource = dsLst;
            dgvDSDauSach.Columns["MaSach"].DataPropertyName = "MaSach";
            dgvDSDauSach.Columns["TenSach"].DataPropertyName = "TenSach";
        }


        private void LoadDuLieu()
        {
            cmbTheLoai.DataSource = tlBLL.GetDSTheLoai();
            cmbTheLoai.DisplayMember = "TenTheLoai";
            cmbTheLoai.ValueMember = "MaTheLoai";

            cmbNhaXuatBan.DataSource = nxbBLL.GetDSNhaXuatBan();
            cmbNhaXuatBan.DisplayMember = "TenNXB";
            cmbNhaXuatBan.ValueMember = "MaNXB";

            LoadDuLieuDauSach(dsBLL.GetDSDauSach());

            string duongDan = helper.LayDuongDanAnhBia() + "page-not-found.png";
            Image anhBia = helper.LayAnhBiaDauSach(duongDan);
            ucThongTinDauSach.AnhBia = anhBia;
            ucThongTinDauSach.LoadAnhBia();
        }

        private void FrmBanIn_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void cmbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maTheLoai = cmbTheLoai.SelectedValue.ToString();

            if (maTheLoai.Equals("DTO.TheLoai"))
                return;

            if (_maNXB == 0)
            {
                LoadDuLieuDauSach(dsBLL.GetDSDauSachTheoTheLoai(int.Parse(maTheLoai)));
            }
            else
            {
                LoadDuLieuDauSach(dsBLL.GetDSDauSachTongHop(int.Parse(maTheLoai), _maNXB));
            }

            _maTheLoai = int.Parse(maTheLoai);               

        }

        private void cmbNhaXuatBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNXB = cmbNhaXuatBan.SelectedValue.ToString();

            if (maNXB.Equals("DTO.NhaXuatBan"))
                return;

            if (_maTheLoai == 0)
            {
                LoadDuLieuDauSach(dsBLL.GetDSDauSachTheoNhaXuatBan(int.Parse(maNXB)));
            }
            else
            {
                LoadDuLieuDauSach(dsBLL.GetDSDauSachTongHop(_maTheLoai, int.Parse(maNXB)));
            }

            _maNXB = int.Parse(maNXB);
        }

        private void dgvDSDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) 
                return;

            _maSach = int.Parse(dgvDSDauSach.CurrentRow.Cells[0].Value.ToString());
            ds = dsBLL.GetDLDauSachTheoMa(_maSach);

            ucThongTinDauSach.TenSach = ds.TenSach;
            ucThongTinDauSach.TheLoai = tlBLL.GetTenTheLoaiTuMa((int)ds.MaTheLoai);
            ucThongTinDauSach.TacGia = ds.TacGia;
            ucThongTinDauSach.NhaXuatBan = nxbBLL.GetTenNhaXuatBanTuMa((int)ds.MaNXB);
            ucThongTinDauSach.NamXuatBan = ds.NamXB.Value.ToShortDateString();

            string duongDan = helper.LayDuongDanAnhBia() + ds.BiaSach;
            Image anhBia = helper.LayAnhBiaDauSach(duongDan);
            ucThongTinDauSach.AnhBia = anhBia;
            ucThongTinDauSach.LoadAnhBia();
        }
    }
}
