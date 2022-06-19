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
    public partial class FrmTaiKhoan : Form
    {
        NguoiDungBLL ndBLL = new NguoiDungBLL();
        NhomNguoiDungBLL nndBLL = new NhomNguoiDungBLL();
        PhanQuyenBLL pqBLL = new PhanQuyenBLL();
        NhanVienBLL nvBLL = new NhanVienBLL();

        string loaiThucThi = string.Empty;

        public FrmTaiKhoan()
        {
            InitializeComponent();
            dgvDSNguoiDung.AutoGenerateColumns = false;
            dgvDSPhanQuyen.AutoGenerateColumns = false;
        }

        private void LoadControlChucNang()
        {
            btnThem.Enabled = dgvDSNguoiDung.Enabled = true;

            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHuy.Enabled = false;
            cmbNhanVien.Enabled = cmbNhom.Enabled = txtMatKhau.Enabled = txtTenDangNhap.Enabled = chkHoatDong.Enabled = false;

            txtMatKhau.Text = txtTenDangNhap.Text = string.Empty;
            cmbNhom.SelectedIndex = cmbNhanVien.SelectedIndex = 0;
            chkHoatDong.Checked = false;
        }

        private void LoadDSPhanQuyen(int maNhom)
        {
            dgvDSPhanQuyen.DataSource = pqBLL.GetDSView_DSPhanQuyenTheoMaNhom(maNhom);
        }

        private void LoadDSNguoiDung()
        {
            dgvDSNguoiDung.DataSource = ndBLL.GetDSView_DSNguoiDung();
        }

        private void FrmTaiKhoan_Load(object sender, EventArgs e)
        {

            cmbNhanVien.DataSource = nvBLL.GetDSNhanVien();
            cmbNhanVien.DisplayMember = "TenNhanVien";
            cmbNhanVien.ValueMember = "MaNhanVien";

            cmbNhom.DataSource = nndBLL.GetDSNhomNguoiDung();
            cmbNhom.DisplayMember = "TenNhom";
            cmbNhom.ValueMember = "MaNhom";

            cmbNhomNguoiDung.DataSource = nndBLL.GetDSNhomNguoiDung();
            cmbNhomNguoiDung.DisplayMember = "TenNhom";
            cmbNhomNguoiDung.ValueMember = "MaNhom";

            LoadControlChucNang();
            LoadDSNguoiDung();
            cmbNhomNguoiDung.SelectedIndex = 0;
            cmbNhomNguoiDung_SelectedIndexChanged(sender, e);
        }

        private void dgvDSNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSua.Enabled = btnXoa.Enabled = true;
                DataGridViewRow r = dgvDSNguoiDung.SelectedRows[0];

                txtTenDangNhap.Text = r.Cells[0].Value.ToString();
                txtMatKhau.Text = r.Cells[1].Value.ToString();
                cmbNhanVien.Text = r.Cells[2].Value.ToString();
                cmbNhom.Text = r.Cells[3].Value.ToString();

                try
                {
                    string b = r.Cells[4].Value.ToString();
                    chkHoatDong.Checked = bool.Parse(b);
                }
                catch (Exception)
                {
                    chkHoatDong.Checked = false;
                }
            }
        }

        public void ThemNguoiDung()
        {
            NguoiDung nd = new NguoiDung();
            nd.TenDangNhap = txtTenDangNhap.Text;
            nd.MatKhau = txtMatKhau.Text;
            nd.MaNhanVien = int.Parse(cmbNhanVien.SelectedValue.ToString());
            nd.MaNhom = int.Parse(cmbNhom.SelectedValue.ToString());

            if (chkHoatDong.Checked)
                nd.HoatDong = true;
            else
                nd.HoatDong = false;

            int kq = ndBLL.ThemNguoiDung(nd);

            if (kq == 1)
            {
                LoadDSNguoiDung();
                LoadControlChucNang();
                loaiThucThi = string.Empty;
            }
            else if (kq == 0)
            {
                MessageBox.Show("Thêm người dùng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void XoaNguoiDung(string tenDangNhap)
        {
            if (ndBLL.XoaNguoiDung(tenDangNhap))
            {
                LoadDSNguoiDung();
                LoadControlChucNang();
                loaiThucThi = string.Empty;
            }
            else
            {
                MessageBox.Show("Xóa người dùng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuaNguoiDung()
        {
            NguoiDung nd = new NguoiDung();
            nd.TenDangNhap = txtTenDangNhap.Text;
            nd.MatKhau = txtMatKhau.Text;
            nd.MaNhanVien = int.Parse(cmbNhanVien.SelectedValue.ToString());
            nd.MaNhom = int.Parse(cmbNhom.SelectedValue.ToString());

            if (ndBLL.SuaNguoiDung(nd))
            {
                LoadDSNguoiDung();
                LoadControlChucNang();
                loaiThucThi = string.Empty;
            }
            else
            {
                MessageBox.Show("Sửa người dùng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = dgvDSNguoiDung.Enabled = false;
            txtTenDangNhap.Text = txtMatKhau.Text = string.Empty;
            cmbNhanVien.SelectedIndex = cmbNhom.SelectedIndex = 0;
            cmbNhanVien.Enabled = cmbNhom.Enabled = txtTenDangNhap.Enabled = txtMatKhau.Enabled = chkHoatDong.Enabled = true;
            loaiThucThi = "Them";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Xác nhận xóa tài khỏa: {0}?", txtTenDangNhap.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                XoaNguoiDung(txtTenDangNhap.Text);
            }
            else
            {
                LoadDSNguoiDung();
                LoadControlChucNang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = dgvDSNguoiDung.Enabled = false;
            cmbNhanVien.Enabled = cmbNhom.Enabled = txtMatKhau.Enabled = chkHoatDong.Enabled = true;
            loaiThucThi = "Sua";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == string.Empty || txtMatKhau.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (loaiThucThi)
            {
                case "Them":
                    ThemNguoiDung();
                    break;
                case "Sua":
                    SuaNguoiDung();
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn hủy thao tác?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                loaiThucThi = string.Empty;
                LoadControlChucNang();
            }
        }

        private void cmbNhomNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNhom = cmbNhomNguoiDung.SelectedValue.ToString();
            if (maNhom.Equals("DTO.NhomNguoiDung"))
                return;

            LoadDSPhanQuyen(int.Parse(maNhom));
        }

        private void btnLuuChinhSua_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDSPhanQuyen.Rows)
            {
                bool coQuyen;
                try
                {
                    coQuyen = bool.Parse(row.Cells[4].Value.ToString());
                }
                catch (Exception)
                {
                    coQuyen = false;
                }

                PhanQuyen pq = new PhanQuyen()
                {
                    MaNhom = int.Parse(row.Cells[0].Value.ToString()),
                    MaChucNang = int.Parse(row.Cells[2].Value.ToString()),
                    CoQuyen = coQuyen
                };

                if (pqBLL.SuaPhanQuyen(pq))
                    continue;
                else
                {
                    MessageBox.Show("Cập nhật phân quyền thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            MessageBox.Show("Cập nhật phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbNhomNguoiDung_SelectedIndexChanged(sender, e);
        }
    }
}
