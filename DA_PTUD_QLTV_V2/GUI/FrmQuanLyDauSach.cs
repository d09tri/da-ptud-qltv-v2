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

        int _maNXB = 0;
        int _maTheLoai = 0;
        string loaiThucThi = string.Empty;

        public FrmQuanLyDauSach()
        {
            InitializeComponent();
            dgvDSDauSach.AutoGenerateColumns = false;
        }

        private void LoadDuLieuDauSach(List<view_DSDauSach> dl)
        {
            dgvDSDauSach.DataSource = dl;
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
        }

        private void LoadControlChucNang()
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
            txtTenSach.ReadOnly = txtTacGia.ReadOnly = true;
            btnChonAnh.Enabled = false;
            cmbNhaXuatBan.Enabled = cmbTheLoai.Enabled = false;
            dtpNamXuatBan.Enabled = false;

            lblMaSach.Text = txtTenSach.Text = txtAnhBia.Text = txtTacGia.Text = string.Empty;
            cmbNhaXuatBan.SelectedIndex = cmbTheLoai.SelectedIndex = 0;
            dtpNamXuatBan.Value = DateTime.Now;

            string duongDan = helper.LayDuongDanAnhBia() + "page-not-found.png";
            Image anhBia = helper.LayAnhBiaDauSach(duongDan, picAnhBia.Width, picAnhBia.Height);
            picAnhBia.Image = anhBia;
        }

        private void FrmQuanLyDauSach_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            LoadControlChucNang();
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

            btnXoa.Enabled = btnSua.Enabled = true;
        }

        private void ThemDauSach()
        {
            if (grbTTDauSach.Controls.OfType<TextBox>().Where(t => t != txtAnhBia).Any(t => String.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DauSach ds = new DauSach();
            {
                ds.TenSach = txtTenSach.Text;
                ds.BiaSach = "";
                ds.TacGia = txtTacGia.Text;
                ds.MaTheLoai = int.Parse(cmbTheLoai.SelectedValue.ToString());
                ds.MaNXB = int.Parse(cmbNhaXuatBan.SelectedValue.ToString());
                ds.NamXB = dtpNamXuatBan.Value;
            }

            if(dsBLL.ThemDauSach(ds))
            {
                LoadControlChucNang();
                loaiThucThi = string.Empty;              
            }
            else
            {
                MessageBox.Show("Thêm đầu sách thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaDauSach(int maDauSach)
        {
            if(dsBLL.XoaDauSach(maDauSach))
            {
                LoadControlChucNang();
            }
            else
            {
                MessageBox.Show("Xóa đầu sách thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuaDauSach()
        {
            if(grbTTDauSach.Controls.OfType<TextBox>().Where(t => t != txtAnhBia).Any(t => String.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DauSach ds = new DauSach();
            {
                ds.TenSach = txtTenSach.Text;
                ds.BiaSach = "";
                ds.TacGia = txtTacGia.Text;
                ds.MaTheLoai = int.Parse(cmbTheLoai.SelectedValue.ToString());
                ds.MaNXB = int.Parse(cmbNhaXuatBan.SelectedValue.ToString());
                ds.NamXB = dtpNamXuatBan.Value;
            }
            if(dsBLL.SuaDauSach(ds))
            {
                LoadControlChucNang();
                loaiThucThi = string.Empty;
            }
            else
            {
                MessageBox.Show("Sửa đầu sách thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _maNXB = _maTheLoai = cmbLocNhaXuatBan.SelectedIndex = cmbLocTheLoai.SelectedIndex = 0;
            LoadDuLieuDauSach(dsBLL.GetDSView_DSDauSach());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            loaiThucThi = "Them";
            grbDSDauSach.Controls.OfType<TextBox>().Where(t => t != txtAnhBia).ToList().ForEach(t => t.Enabled = true);
            txtTenSach.ReadOnly = txtTacGia.ReadOnly = false;
            cmbTheLoai.Enabled = cmbNhaXuatBan.Enabled = dtpNamXuatBan.Enabled = true;
            btnXoa.Enabled = btnSua.Enabled = dgvDSDauSach.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;

            dgvDSDauSach.ClearSelection();
            cmbNhaXuatBan.SelectedIndex = cmbTheLoai.SelectedIndex = 0;
            dtpNamXuatBan.Value = DateTime.Now;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Xác nhận xóa đầu sách: {0}?", txtTenSach.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                // Thực hiện chức năng xóa TẠI ĐÂY
                XoaDauSach(int.Parse(lblMaSach.Text));
            }
            else
            {
                LoadControlChucNang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            loaiThucThi = "Sua";
            grbDSDauSach.Controls.OfType<TextBox>().Where(t => t != txtAnhBia).ToList().ForEach(t => t.Enabled = true);
            txtTenSach.ReadOnly = txtTacGia.ReadOnly = false;
            cmbTheLoai.Enabled = cmbNhaXuatBan.Enabled = dtpNamXuatBan.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = dgvDSDauSach.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;

            dgvDSDauSach.ClearSelection();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (loaiThucThi)
            {
                case "Them":
                    ThemDauSach();
                    break;
                case "Sua":
                    SuaDauSach();
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
