﻿using CustomControls;
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
    public partial class FrmChucNangMuonSach : Form
    {
        DauSachBLL dsBLL = new DauSachBLL();
        TheLoaiBLL tlBLL = new TheLoaiBLL();
        NhaXuatBanBLL nxbBLL = new NhaXuatBanBLL();
        Helper helper = new Helper();

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
            if (lstMaBanIn.Count <= 0)
            {
                MessageBox.Show("Chưa có đầu sách mượn, vui lòng quét đầu sách trước tiên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            fpnlDSDauSachMuon.Controls.Clear();

            foreach (int maBanIn in lstMaBanIn)
            {
                DauSach ds = dsBLL.GetDauSachTheoMaBanIn(maBanIn);

                string duongDan = helper.LayDuongDanAnhBia() + ds.BiaSach;
                Image anhBia = helper.LayAnhBiaDauSach(duongDan);

                UcThongTinDauSach uc = new UcThongTinDauSach()
                {
                    TenSach = ds.TenSach,
                    TheLoai = tlBLL.GetTheLoaiTheoMa((int)ds.MaTheLoai).TenTheLoai,
                    TacGia = ds.TacGia,
                    NhaXuatBan = nxbBLL.GetNhaXuatBanTheoMa((int)ds.MaNXB).TenNXB,
                    NamXuatBan = ds.NamXB.Value.ToShortDateString(),
                    AnhBia = anhBia,
                    MaBanIn = maBanIn.ToString()
                };

                uc.LoadAnhBia();

                uc.Width = fpnlDSDauSachMuon.Width - 10;
                uc.Left = (fpnlDSDauSachMuon.ClientSize.Width - uc.Width) / 2;
                uc.Top = (fpnlDSDauSachMuon.ClientSize.Height - uc.Height) / 2;
                fpnlDSDauSachMuon.Controls.Add(uc);
                uc.Anchor = AnchorStyles.None;
            }
        }
    }
}
