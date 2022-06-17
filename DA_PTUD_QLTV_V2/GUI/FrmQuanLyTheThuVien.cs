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
    public partial class FrmQuanLyTheThuVien : Form
    {
        TheThuVienBLL ttvBLL = new TheThuVienBLL();
        DocGiaBLL dgBLL = new DocGiaBLL();
        string _loaithucthi = string.Empty;

        public FrmQuanLyTheThuVien()
        {
            InitializeComponent();
        }

        private void dgvDSTheThuVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSua.Enabled = btnXoa.Enabled = true;
                lblMaThe.Text = dgvDSTheThuVien.CurrentRow.Cells[0].Value.ToString();
                cmbTenDocGia.Text = dgvDSTheThuVien.CurrentRow.Cells[1].Value.ToString();
                dtpNgayLap.Text = dgvDSTheThuVien.CurrentRow.Cells[2].Value.ToString();
                dtpNgayHetHan.Text = dgvDSTheThuVien.CurrentRow.Cells[3].Value.ToString();
                rtxtGhiChu.Text = dgvDSTheThuVien.CurrentRow.Cells[4].Value.ToString();
                if (bool.Parse(dgvDSTheThuVien.CurrentRow.Cells[5].Value.ToString()))
                    chkTinhTrang.Checked = true;
                else
                    chkTinhTrang.Checked = false;
            }
        }

        private void LoadControlChucNang()
        {
            btnThem.Enabled = dgvDSTheThuVien.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
            cmbTenDocGia.Enabled = rtxtGhiChu.Enabled = dtpNgayHetHan.Enabled = dtpNgayLap.Enabled = chkTinhTrang.Enabled = false;
        }

        private void FrmQuanLyTheThuVien_Load(object sender, EventArgs e)
        {
            LoadDSTheThuVien();
            LoadControlChucNang();
        }

        private void LoadDSDocGiaChuCoTheThuVien()
        {
            cmbTenDocGia.DataSource = null;
            cmbTenDocGia.Items.Clear();
            cmbTenDocGia.DataSource = dgBLL.GetDSDocGiaChuaCoTheThuVien();
            cmbTenDocGia.DisplayMember = "TenDocGia";
            cmbTenDocGia.ValueMember = "MaDocGia";
        }
        private void LoadDSTheThuVien()
        {
            dgvDSTheThuVien.DataSource = ttvBLL.GetDSView_DSTheThuVien();
            cmbTenDocGia.DataSource = null;
            cmbTenDocGia.Items.Clear();
            cmbTenDocGia.DataSource = dgBLL.GetDSDocGia();
            cmbTenDocGia.DisplayMember = "TenDocGia";
            cmbTenDocGia.ValueMember = "TenDocGia";
        }

        private void ThemTheThuVien()
        {
            TheThuVien ttv = new TheThuVien();
            ttv.MaDocGia = int.Parse(cmbTenDocGia.SelectedValue.ToString());
            ttv.NgayLap = dtpNgayLap.Value;
            ttv.NgayHetHan = dtpNgayHetHan.Value;
            ttv.GhiChu = rtxtGhiChu.Text;

            if (chkTinhTrang.Checked)
                ttv.TinhTrang = true;
            else
                ttv.TinhTrang = false;

            if (ttvBLL.ThemTheThuVien(ttv))
            {
                LoadDSTheThuVien();
                LoadControlChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Thêm thẻ thư viện thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaTheThuVien(int maThe)
        {
            if (ttvBLL.XoaTheThuVien(maThe))
            {
                LoadDSTheThuVien();
                LoadControlChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Xóa thẻ thư viện thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuaTheThuVien()
        {
            TheThuVien ttv = new TheThuVien();
            ttv.MaThe = int.Parse(lblMaThe.Text);
            ttv.NgayLap = dtpNgayLap.Value;
            ttv.NgayHetHan = dtpNgayHetHan.Value;
            ttv.GhiChu = rtxtGhiChu.Text;

            if (chkTinhTrang.Checked)
                ttv.TinhTrang = true;
            else
                ttv.TinhTrang = false;

            if (ttvBLL.SuaTheThuVien(ttv))
            {
                LoadDSTheThuVien();
                LoadControlChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Sửa thẻ thư viện thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoadDSDocGiaChuCoTheThuVien();
            dgvDSTheThuVien.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            cmbTenDocGia.Enabled = rtxtGhiChu.Enabled = dtpNgayHetHan.Enabled = dtpNgayLap.Enabled = chkTinhTrang.Enabled = true;
            lblMaThe.Text = rtxtGhiChu.Text = string.Empty;
            dtpNgayHetHan.Value = dtpNgayLap.Value = DateTime.Now;
            chkTinhTrang.Checked = false;
            _loaithucthi = "Them";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Xác nhận xóa thẻ thư viện: {0}?", lblMaThe.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                XoaTheThuVien(int.Parse(lblMaThe.Text));
            }
            else
            {
                LoadControlChucNang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dgvDSTheThuVien.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            rtxtGhiChu.Enabled = dtpNgayHetHan.Enabled = dtpNgayLap.Enabled = chkTinhTrang.Enabled = true;
            _loaithucthi = "Sua";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (_loaithucthi)
            {
                case "Them":
                    ThemTheThuVien();
                    break;
                case "Sua":
                    SuaTheThuVien();
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Bạn có muốn hủy thao tác?"), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                _loaithucthi = string.Empty;
                LoadControlChucNang();
                LoadDSTheThuVien();
            }
        }

        private void txtTimKiemDocGia_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemDocGia.Text.Length == 0)
            {
                LoadDSTheThuVien();
            }

            dgvDSTheThuVien.DataSource = null;
            dgvDSTheThuVien.ClearSelection();
            dgvDSTheThuVien.DataSource = ttvBLL.GetDSView_DSTheThuVienTheoTenDocGia(txtTimKiemDocGia.Text);
        }
    }
}
