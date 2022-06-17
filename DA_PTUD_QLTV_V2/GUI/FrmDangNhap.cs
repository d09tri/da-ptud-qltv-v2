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
    public partial class FrmDangNhap : Form
    {
        NguoiDungBLL ndBLL = new NguoiDungBLL();       

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == string.Empty || txtTenDangNhap.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int kq = ndBLL.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);
            if (kq == 0)
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (kq == -1)
                MessageBox.Show("Tài khoản không hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                NhanVien nv = ndBLL.GetNhanVienTheoTenDangNhap(txtTenDangNhap.Text);
                FrmTrangChu frm = new FrmTrangChu(nv);
                frm.Show();
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }

            return;
        }

        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
