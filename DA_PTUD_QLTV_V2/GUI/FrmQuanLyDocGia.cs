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
        DocGiaBLL docgiabll = new DocGiaBLL();
        string _loaithucthi = string.Empty;
        public FrmQuanLyDocGia()
        {
            InitializeComponent();
        }

        private void FrmQuanLyDocGia_Load(object sender, EventArgs e)
        {
            LoadDSDocGia();
            LoadChucNang();
        }

        private void LoadChucNang()
        {
            btnLuu.Enabled = btnHuy.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txtCMND.Enabled = txtTenDocGia.Enabled = dtpNgaySinh.Enabled = false;
        }
        private void LoadDSDocGia()
        {
            dgvDanhSachDocGia.DataSource = docgiabll.GetDSDocGia();
        }

        public void Them()
        {
            if(txtTenDocGia.Text == string.Empty || txtCMND.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DocGia dg = new DocGia();
                dg.TenDocGia = txtTenDocGia.Text;
                dg.NgaySinh = dtpNgaySinh.Value;
                dg.CMND = txtCMND.Text;

                if(docgiabll.ThemDocGia(dg))
                {
                    LoadDSDocGia();
                    LoadChucNang();
                    _loaithucthi = string.Empty;
                }
                else
                {
                    MessageBox.Show("Thêm độc giả thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Xoa(int madg)
        {
            if(docgiabll.XoaDocGia(madg))
            {
                LoadDSDocGia();
                LoadChucNang();
                _loaithucthi = string.Empty;
            }
            else
            {
                MessageBox.Show("Xóa độc giả thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sua()
        {
            if (txtTenDocGia.Text == string.Empty || txtCMND.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DocGia dg = new DocGia();
                dg.MaDocGia = int.Parse(lblMaDocGia.Text);
                dg.TenDocGia = txtTenDocGia.Text;
                dg.NgaySinh = dtpNgaySinh.Value;
                dg.CMND = txtCMND.Text;

                if (docgiabll.SuaDocGia(dg))
                {
                    LoadDSDocGia();
                    LoadChucNang();
                    _loaithucthi = string.Empty;
                }
                else
                {
                    MessageBox.Show("Thêm độc giả thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvDanhSachDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0)
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
            txtCMND.Enabled = txtTenDocGia.Enabled = dtpNgaySinh.Enabled = true;
            _loaithucthi = "Them";
        }
   
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(string.Format("Xác nhận xóa độc giả: {0} ?", lblMaDocGia.Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Xoa(int.Parse(lblMaDocGia.Text));
            }
            else
            {
                LoadChucNang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            txtCMND.Enabled = txtTenDocGia.Enabled = dtpNgaySinh.Enabled = true;
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

        private void txtTimKiemDocGia_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemDocGia.Text.Length == 0)
            {
                LoadDSDocGia();
            }
            else
            {
                dgvDanhSachDocGia.DataSource = null;
                dgvDanhSachDocGia.ClearSelection();
                dgvDanhSachDocGia.DataSource = docgiabll.GetDSDocGiaTheoTen(txtTimKiemDocGia.Text.ToString());
            }
        }

        
    }
}
