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
    public partial class FrmTrangChu : Form
    {
        PhanQuyenBLL pqBLL = new PhanQuyenBLL();
        Helper helper = new Helper();

        NhanVien nv = new NhanVien();
        List<view_DSPhanQuyen> lstPQ = new List<view_DSPhanQuyen>();
        int maNhom = 0;

        public FrmTrangChu(NhanVien nv, int maNhom)
        {
            InitializeComponent();
            this.nv = nv;
            this.maNhom = maNhom;
            lblTaiKhoan.Text = "Xin chào " + nv.TenNhanVien;
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {
            lstPQ = pqBLL.GetDSView_DSPhanQuyenTheoMaNhom(maNhom);
            LoadPhanQuyen();
            HideSubMenu();
        }

        private void LoadPhanQuyen()
        {
            pnlQuanLySubMenu.Height = pnlChucNangSubMenu.Height = pnlHeThongSubMenu.Height = 0;
            pnlQuanLySubMenu.Controls.OfType<Button>().ToList().ForEach(t => t.Visible = false);
            pnlChucNangSubMenu.Controls.OfType<Button>().ToList().ForEach(t => t.Visible = false);
            pnlHeThongSubMenu.Controls.OfType<Button>().ToList().ForEach(t => t.Visible = false);

            foreach (view_DSPhanQuyen pq in lstPQ)
            {
                int index = pq.TenChucNang.IndexOf('-');
                string menuPanel = pq.TenChucNang.Substring(0, index);
                string subMenuButton = pq.TenChucNang.Substring(index + 1);

                if (menuPanel.Equals("QL") && pq.CoQuyen == true)
                {
                    pnlQuanLySubMenu.Height += 40;
                    Button btn = pnlQuanLySubMenu.Controls.OfType<Button>().First(t => t.Text.Equals(subMenuButton));
                    btn.Visible = true;
                }
                
                if (menuPanel.Equals("CN") && pq.CoQuyen == true)
                {
                    pnlChucNangSubMenu.Height += 40;
                    Button btn = pnlChucNangSubMenu.Controls.OfType<Button>().First(t => t.Text.Equals(subMenuButton));
                    btn.Visible = true;
                }

                if (menuPanel.Equals("HT") && pq.CoQuyen == true)
                {
                    pnlHeThongSubMenu.Height += 40;
                    Button btn = pnlHeThongSubMenu.Controls.OfType<Button>().First(t => t.Text.Equals(subMenuButton));
                    btn.Visible = true;
                }
            }
        }

        #region Sub menu functions
        void ShowSubMenu(Panel pnl)
        {
            if (pnl.Visible == false)
            {
                HideSubMenu();
                pnl.Visible = true;
            }
            else
            {
                pnl.Visible = false;
            }
        }

        private void HideSubMenu()
        {
            if (pnlQuanLySubMenu.Visible == true)
                pnlQuanLySubMenu.Visible = false;
            if (pnlChucNangSubMenu.Visible == true)
                pnlChucNangSubMenu.Visible = false;
            if (pnlHeThongSubMenu.Visible == true)
                pnlHeThongSubMenu.Visible = false;
        }
        #endregion

        #region Sub menu buttons
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlQuanLySubMenu);
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlChucNangSubMenu);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlHeThongSubMenu);
        }
        #endregion

        #region Sub menu Quản lý
        private void btnDauSach_Click(object sender, EventArgs e)
        {
            FrmQuanLyDauSach frm = new FrmQuanLyDauSach();
            helper.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnBanIn_Click(object sender, EventArgs e)
        {
            FrmQuanLyBanIn frm = new FrmQuanLyBanIn();
            helper.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            FrmQuanLyDocGia frm = new FrmQuanLyDocGia();
            helper.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnTheThuVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyTheThuVien frm = new FrmQuanLyTheThuVien();
            helper.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyNhanVien frm = new FrmQuanLyNhanVien();
            helper.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }
        #endregion

        #region Sub menu Chức năng
        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            FrmChucNangMuonSach frm = new FrmChucNangMuonSach(nv);
            helper.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            FrmChucNangTraSach frm = new FrmChucNangTraSach(nv);
            helper.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frm = new FrmThongKe();
            helper.LoadChildForm(frm, pnlMain);
            HideSubMenu();
        }
        #endregion

        #region Sub menu Hệ thống
        private void btnBackup_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn đăng xuất khỏi hệ thống?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rs == DialogResult.Yes)
            {
                this.SetVisibleCore(false);
                FrmDangNhap frm = new FrmDangNhap();
                frm.Show();
            }

            return;
        }
    }
}
