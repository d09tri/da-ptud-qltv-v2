using CustomControls;
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
    public partial class FrmChucNangMuonSach : Form
    {
        public FrmChucNangMuonSach()
        {
            InitializeComponent();
        }

        static List<int> lstMaBanIn = new List<int>();

        public static void GanDuLieuDSMaBanIn(List<int> lst)
        {
            lstMaBanIn = lst;
        }

        private void btnQuetDauSach_Click(object sender, EventArgs e)
        {
            FrmQuetDauSach frm = new FrmQuetDauSach();
            frm.ShowDialog();
        }

        private void btnLoadDauSach_Click(object sender, EventArgs e)
        {
            foreach (int maBanIn in lstMaBanIn)
            {
                UcThongTinDauSach uc = new UcThongTinDauSach();
                uc.Width = fpnlDSDauSachMuon.Width - 20;
                uc.Left = (fpnlDSDauSachMuon.ClientSize.Width - uc.Width) / 2;
                uc.Top = (fpnlDSDauSachMuon.ClientSize.Height - uc.Height) / 2;
                uc.TenSach = maBanIn.ToString();
                fpnlDSDauSachMuon.Controls.Add(uc);
                uc.Anchor = AnchorStyles.None;
            }
        }
    }
}
