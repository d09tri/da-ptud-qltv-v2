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
    public partial class FrmQuanLyBanIn : Form
    {
        TheLoaiBLL tlBLL = new TheLoaiBLL();
        NhaXuatBanBLL nxbBLL = new NhaXuatBanBLL();
        DauSachBLL dsBLL = new DauSachBLL();
        BanInBLL biBLL = new BanInBLL();
        Helper helper = new Helper();

        List<DauSach> dsLst = new List<DauSach>();
        List<BanIn> biLst = new List<BanIn>();
        DauSach ds = new DauSach();
        BanIn bi = new BanIn();

        int _maTheLoai = 0;
        int _maNXB = 0;
        int _maSach = 0;
        int _maBanIn = 0;

        public FrmQuanLyBanIn()
        {
            InitializeComponent();
            dgvDSDauSach.AutoGenerateColumns = false;
            dgvDSBanIn.AutoGenerateColumns = false;
        }

        private void LoadDuLieuDauSach(List<DauSach> dl)
        {
            dsLst = dl;
            dgvDSDauSach.DataSource = dsLst;
        }

        private void LoadDuLieuBanIn(List<BanIn> dl)
        {
            biLst = dl;
            dgvDSBanIn.DataSource = biLst;
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

        private void FrmBanIn_v2_Load(object sender, EventArgs e)
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
            LoadDuLieuBanIn(biBLL.GetDSBanIn(_maSach));

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

        private void dgvDSBanIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            btnSua.Enabled = btnXoa.Enabled = true;
            _maBanIn = int.Parse(dgvDSBanIn.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (_maSach == 0)
            {
                MessageBox.Show("Hãy chọn sách để thêm bản in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bi = new BanIn();
            bi.MaSach = _maSach;
            bi.TrangThai = false;
            if (biBLL.ThemBanIn(bi))
            {
                LoadDuLieuBanIn(biBLL.GetDSBanIn(_maSach));
            }
            else
            {
                MessageBox.Show("Thêm bản in thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maBanIn == 0)
            {
                MessageBox.Show("Hãy chọn bản in cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult rs = MessageBox.Show("Xác nhận xóa bản in này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs != DialogResult.Yes)
                return;

            int kq = biBLL.XoaBanIn(_maBanIn);
            if (kq == -1)
            {
                MessageBox.Show("Bản in đã và đang được mượn bởi nhiều phiếu mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kq == 0)
            {
                MessageBox.Show("Xóa bản in thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoadDuLieuBanIn(biBLL.GetDSBanIn(_maSach));
            }

            _maBanIn = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maBanIn == 0)
            {
                MessageBox.Show("Hãy chọn bản in cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bi = new BanIn();
            bi.MaBanIn = _maBanIn;
            bi.TrangThai = !bool.Parse(dgvDSBanIn.CurrentRow.Cells[2].Value.ToString());

            if (biBLL.SuaBanIn(bi))
            {
                LoadDuLieuBanIn(biBLL.GetDSBanIn(_maSach));
            }
            else
            {
                MessageBox.Show("Sửa bản in thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _maBanIn = 0;
        }
    }
}
