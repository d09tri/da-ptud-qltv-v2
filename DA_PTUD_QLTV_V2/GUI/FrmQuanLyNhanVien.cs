using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class FrmQuanLyNhanVien : Form
    {
        NhanVienBLL nvBLL = new NhanVienBLL();
        string _loaithucthi = string.Empty;
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadControlChucNang();
            LoadDSNhanVien();
        } 

        private void LoadControlChucNang()
        {
            btnThem.Enabled = dgvDanhSachNhanVien.Enabled = true;

            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
            txtTenNhanVien.Enabled = dtpNgaySinh.Enabled = false;

            lblMaNhanVien.Text = txtTenNhanVien.Text = txtTimKiemNhanVien.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void LoadDSNhanVien()
        {
            dgvDanhSachNhanVien.DataSource = nvBLL.GetDSNhanVien();
        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                btnSua.Enabled = btnXoa.Enabled = true;
                lblMaNhanVien.Text = dgvDanhSachNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvDanhSachNhanVien.CurrentRow.Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSachNhanVien.CurrentRow.Cells[2].Value.ToString();
            }
        }

        public void ThemNhanVien()
        {

            NhanVien nv = new NhanVien();
            nv.TenNhanVien = txtTenNhanVien.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
          

            if (nvBLL.ThemNhanVien(nv))
            {
                LoadDSNhanVien();
                LoadControlChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaNhanVien(int maNhanVien)
        {
            if (nvBLL.XoaNhanVien(maNhanVien))
            {
                LoadDSNhanVien();
                LoadControlChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuaNhanVien()
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = int.Parse(lblMaNhanVien.Text);
            nv.TenNhanVien = txtTenNhanVien.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            

            if (nvBLL.SuaNhanVien(nv))
            {
                LoadDSNhanVien();
                LoadControlChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = dgvDanhSachNhanVien.Enabled = false;
            lblMaNhanVien.Text =txtTenNhanVien.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Now;
            txtTenNhanVien.Enabled = dtpNgaySinh.Enabled = true;
            _loaithucthi = "Them";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Xác nhận xóa nhân viên: {0}?", txtTenNhanVien.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                XoaNhanVien(int.Parse(lblMaNhanVien.Text));
            }
            else
            {
                LoadControlChucNang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = dgvDanhSachNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = dtpNgaySinh.Enabled = true;
            _loaithucthi = "Sua";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (_loaithucthi)
            {
                case "Them":
                    ThemNhanVien();
                    break;
                case "Sua":
                    SuaNhanVien();
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

        private void txtTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemNhanVien.Text.Length == 0)
            {
                LoadDSNhanVien();
            }

            dgvDanhSachNhanVien.DataSource = null;
            dgvDanhSachNhanVien.ClearSelection();
            dgvDanhSachNhanVien.DataSource = nvBLL.GetDSNhanVienTheoTen(txtTimKiemNhanVien.Text.ToString());
        }
    }
}
