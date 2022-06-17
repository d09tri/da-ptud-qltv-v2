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
    public partial class FrmQuanLyDocGia : Form
    {
        DocGiaBLL dgBLL = new DocGiaBLL();
        string _loaithucthi = string.Empty;

        public FrmQuanLyDocGia()
        {
            InitializeComponent();
        }

        private void FrmQuanLyDocGia_Load(object sender, EventArgs e)
        {
            LoadDSDocGia();
            LoadControlChucNang();
        }

        private void LoadControlChucNang()
        {
            btnThem.Enabled = dgvDanhSachDocGia.Enabled = true;

            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
            txtCMND.Enabled = txtTenDocGia.Enabled = dtpNgaySinh.Enabled = false;

            lblMaDocGia.Text = txtTenDocGia.Text = txtCMND.Text = txtTimKiemDocGia.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void LoadDSDocGia()
        {
            dgvDanhSachDocGia.DataSource = dgBLL.GetDSDocGia();
        }

        public void ThemDocGia()
        {

            DocGia dg = new DocGia();
            dg.TenDocGia = txtTenDocGia.Text;
            dg.NgaySinh = dtpNgaySinh.Value;
            dg.CMND = txtCMND.Text;

            if (dgBLL.ThemDocGia(dg))
            {
                LoadDSDocGia();
                LoadControlChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Thêm độc giả thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaDocGia(int maDocGia)
        {
            if (dgBLL.XoaDocGia(maDocGia))
            {
                LoadDSDocGia();
                LoadControlChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Xóa độc giả thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuaDocGia()
        {
            DocGia dg = new DocGia();
            dg.MaDocGia = int.Parse(lblMaDocGia.Text);
            dg.TenDocGia = txtTenDocGia.Text;
            dg.NgaySinh = dtpNgaySinh.Value;
            dg.CMND = txtCMND.Text;

            if (dgBLL.SuaDocGia(dg))
            {
                LoadDSDocGia();
                LoadControlChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Sửa độc giả thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvDanhSachDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSua.Enabled = btnXoa.Enabled = true;
                lblMaDocGia.Text = dgvDanhSachDocGia.CurrentRow.Cells[0].Value.ToString();
                txtTenDocGia.Text = dgvDanhSachDocGia.CurrentRow.Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSachDocGia.CurrentRow.Cells[2].Value.ToString();
                txtCMND.Text = dgvDanhSachDocGia.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = dgvDanhSachDocGia.Enabled = false;
            lblMaDocGia.Text = txtCMND.Text = txtTenDocGia.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            txtCMND.Enabled = txtTenDocGia.Enabled = dtpNgaySinh.Enabled = true;
            _loaithucthi = "Them";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Xác nhận xóa độc giả: {0}?", txtTenDocGia.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                XoaDocGia(int.Parse(lblMaDocGia.Text));
            }
            else
            {
                LoadControlChucNang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = dgvDanhSachDocGia.Enabled = false;
            txtCMND.Enabled = txtTenDocGia.Enabled = dtpNgaySinh.Enabled = true;
            _loaithucthi = "Sua";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDocGia.Text == string.Empty || txtCMND.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (_loaithucthi)
            {
                case "Them":
                    ThemDocGia();
                    break;
                case "Sua":
                    SuaDocGia();
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn hủy thao tác?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                _loaithucthi = string.Empty;
                LoadControlChucNang();
            }
        }

        private void txtTimKiemDocGia_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemDocGia.Text.Length == 0)
            {
                LoadDSDocGia();
            }

            dgvDanhSachDocGia.DataSource = null;
            dgvDanhSachDocGia.ClearSelection();
            dgvDanhSachDocGia.DataSource = dgBLL.GetDSDocGiaTheoTen(txtTimKiemDocGia.Text.ToString());
        }
    }
}
