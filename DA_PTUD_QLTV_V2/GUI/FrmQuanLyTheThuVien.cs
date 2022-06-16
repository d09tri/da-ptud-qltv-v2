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
            if(e.RowIndex >= 0)
            {
                btnSua.Enabled = btnXoa.Enabled = true;
                lblMaThe.Text = dgvDSTheThuVien.CurrentRow.Cells[0].Value.ToString();
                cmbTenDocGia.Text = dgvDSTheThuVien.CurrentRow.Cells[1].Value.ToString();
                dtpNgayLap.Text = dgvDSTheThuVien.CurrentRow.Cells[2].Value.ToString();
                dtpNgayHetHan.Text = dgvDSTheThuVien.CurrentRow.Cells[3].Value.ToString();
                cmbGhiChu.Text = dgvDSTheThuVien.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void LoadChucNang()
        {
            btnLuu.Enabled = btnHuy.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            cmbTenDocGia.Enabled = cmbGhiChu.Enabled = dtpNgayHetHan.Enabled = dtpNgayLap.Enabled = false;
        }

        private void FrmQuanLyTheThuVien_Load(object sender, EventArgs e)
        {
            loadDSTheThuVien();
            LoadChucNang();
        }

        private void LoadDSDocGiaChuCoTheThuVien()
        {
            cmbTenDocGia.DataSource = dgBLL.GetDSDocGiaChuaCoTheThuVien();
            cmbTenDocGia.DisplayMember = "TenDocGia";
            cmbTenDocGia.ValueMember = "MaDocGia";
        }
        private void loadDSTheThuVien()
        {
            dgvDSTheThuVien.DataSource = ttvBLL.GetDSView_DSTheThuVien();
            cmbTenDocGia.DataSource = dgBLL.GetDSDocGia();
            cmbTenDocGia.DisplayMember = "TenDocGia";
            cmbTenDocGia.ValueMember = "TenDocGia";           
        }

        private void Them()
        {
            
            TheThuVien ttv = new TheThuVien();       
            ttv.MaDocGia = int.Parse(cmbTenDocGia.SelectedValue.ToString());
            ttv.NgayLap = dtpNgayLap.Value;
            ttv.NgayHetHan = dtpNgayHetHan.Value;
            ttv.GhiChu = cmbGhiChu.Text;
            if (cmbGhiChu.Text == "Đang hoạt động")
            {
                ttv.TinhTrang = true;
            }
            else
                ttv.TinhTrang = false;

            if (ttvBLL.ThemTheThuVien(ttv))
            {
                loadDSTheThuVien();
                LoadChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Thêm thẻ thư viện thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Xoa(int mattv)
        {
            if (ttvBLL.XoaTheThuVien(mattv))
            {
                loadDSTheThuVien();
                LoadChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Xóa thẻ thư viện thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sua()
        {
           
            TheThuVien ttv = new TheThuVien();
            ttv.MaThe = int.Parse(lblMaThe.Text);
            ttv.NgayLap = dtpNgayLap.Value;
            ttv.NgayHetHan = dtpNgayHetHan.Value;
            ttv.GhiChu = cmbGhiChu.Text;
            if (cmbGhiChu.Text == "Đang hoạt động")
            {
                ttv.TinhTrang = true;
            }
            else
                ttv.TinhTrang = false;

            if (ttvBLL.ThemTheThuVien(ttv))
            {
                loadDSTheThuVien();
                LoadChucNang();
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
            btnLuu.Enabled = btnHuy.Enabled = true;
            cmbTenDocGia.Enabled = cmbGhiChu.Enabled = dtpNgayHetHan.Enabled = dtpNgayLap.Enabled = true;
            _loaithucthi = "Them";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Xác nhận xóa thẻ thư viện: {0} ?", lblMaThe.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Xoa(int.Parse(lblMaThe.Text));
            }
            else
            {
                LoadChucNang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoadDSDocGiaChuCoTheThuVien();
            btnLuu.Enabled = btnHuy.Enabled = true;
            cmbGhiChu.Enabled = dtpNgayHetHan.Enabled = dtpNgayLap.Enabled = true;
            _loaithucthi = "Sua";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (_loaithucthi)
            {
                case "Them":
                    Them();
                    break;
                case "Sua":
                    Sua();
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Bạn có muốn hủy thao tác ?"), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                _loaithucthi = string.Empty;
                LoadChucNang();
            }
        }



    }
}
