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
    public partial class FrmChucNangTraSach : Form
    {
        PhieuMuonBLL pmBLL = new PhieuMuonBLL();

        public FrmChucNangTraSach()
        {
            InitializeComponent();
        }

        private void LoadDuLieu()
        {
            cmbPhieuMuon.DataSource = pmBLL.GetDSView_DSPhieuMuonTheoTinhTrang(false);
            cmbPhieuMuon.DisplayMember = "MaPhieuMuon";
            cmbPhieuMuon.ValueMember = "MaPhieuMuon";
        }

        private void FrmChucNangTraSach_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            cmbPhieuMuon.SelectedIndex = 0;
            cmbPhieuMuon_SelectedIndexChanged(sender, e);
        }

        private void cmbPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maPhieuMuon = cmbPhieuMuon.SelectedValue.ToString();
            if (maPhieuMuon.Equals("DTO.view_DSPhieuMuon"))
                return;

            view_DSPhieuMuon view = pmBLL.GetView_DSPhieuMuonTheoMa(int.Parse(maPhieuMuon));
            txtDocGia.Text = view.TenDocGia;
            txtMaThe.Text = view.MaThe.ToString();
            txtNhanVien.Text = view.TenNhanVien;
            dtpNgayMuon.Value = view.NgayMuon.Value;
            chkTinhTrang.Checked = false;
        }
    }
}
