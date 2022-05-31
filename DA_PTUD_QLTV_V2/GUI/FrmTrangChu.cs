using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
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
            HideSubMenu();
        }
        #endregion

        #region Sub menu Chức năng
        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
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
    }
}
