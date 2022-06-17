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
using DTO;
using BLL;

namespace GUI
{
    public partial class FrmChucNangMuonSach : Form
    {
        DauSachBLL dsBLL = new DauSachBLL();
        TheLoaiBLL tlBLL = new TheLoaiBLL();
        NhaXuatBanBLL nxbBLL = new NhaXuatBanBLL();
        DocGiaBLL dgBLL = new DocGiaBLL();
        TheThuVienBLL ttvBLL = new TheThuVienBLL();
        PhieuMuonBLL pmBLL = new PhieuMuonBLL();
        CTPhieuMuonBLL ctpmBLL = new CTPhieuMuonBLL();
        BanInBLL biBLL = new BanInBLL();

        Helper helper = new Helper();
        static List<int> lstMaBanIn;
        NhanVien nv = new NhanVien();
        bool dieuKienMuon;

        public FrmChucNangMuonSach(NhanVien nv)
        {
            InitializeComponent();
            lstMaBanIn = new List<int>();
            this.nv = nv;
            txtNhanVien.Text = nv.TenNhanVien;
        }

        private void FrmChucNangMuonSach_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            dtpNgayMuon.MinDate = dtpNgayMuon.MaxDate = DateTime.Now;
            dgvDSCTPhieuMuonChuaTra.AutoGenerateColumns = false;
            cmbDocGia.SelectedIndex = 0;
            cmbDocGia_SelectedIndexChanged(sender, e);
        }

        private void LoadDuLieu()
        {
            cmbDocGia.DataSource = dgBLL.GetDSDocGia();
            cmbDocGia.DisplayMember = "TenDocGia";
            cmbDocGia.ValueMember = "MaDocGia";
        }

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

        private void cmbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maDocGia = cmbDocGia.SelectedValue.ToString();
            if (maDocGia.Equals("DTO.DocGia"))
                return;

            TheThuVien ttv = ttvBLL.GetTheThuVienTheoMaDocGia(int.Parse(maDocGia));
            List<PhieuMuon> lstPM = pmBLL.GetDSPhieuMuonTheoMaTheThuVien(ttv.MaThe).Where(t => t.TinhTrang == false).Select(t => t).ToList();
            List<ChiTietPhieuMuon> lstCTPM = new List<ChiTietPhieuMuon>();
            foreach (PhieuMuon pm in lstPM)
            {
                lstCTPM.AddRange(ctpmBLL.GetDSCTPhieuMuonTheoMa(pm.MaPhieuMuon));
            }

            if (lstCTPM.Count <= 5)
            {
                chkDat.Checked = true;
                label6.ForeColor = label7.ForeColor = label8.ForeColor = Color.Green;
                dieuKienMuon = true;
            }
            else
            {
                chkDat.Checked = false;
                label6.ForeColor = label7.ForeColor = label8.ForeColor = Color.Red;
                dieuKienMuon = false;
            }

            txtTheThuVien.Text = ttv.MaThe.ToString();
            txtSLPhieuMuonChuaTra.Text = lstPM.Count.ToString();
            txtSLDauSachChuaTra.Text = lstCTPM.Count.ToString();

            dgvDSCTPhieuMuonChuaTra.DataSource = null;
            dgvDSCTPhieuMuonChuaTra.ClearSelection();
            dgvDSCTPhieuMuonChuaTra.DataSource = lstCTPM;
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (lstMaBanIn.Count <= 0)
            {
                MessageBox.Show("Chưa có đầu sách mượn, vui lòng quét đầu sách trước tiên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!dieuKienMuon)
            {
                MessageBox.Show("Độc giả không đủ điều kiện mượn tiếp, vui lòng trả sách trước khi tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PhieuMuon pm = new PhieuMuon()
            {
                MaNhanVien = nv.MaNhanVien,
                MaThe = int.Parse(txtTheThuVien.Text),
                NgayMuon = dtpNgayMuon.Value,
                TinhTrang = false
            };

            if (pmBLL.TaoPhieuMuon(pm))
            {
                int maPM = helper.LayThongTinMaVuaThem("PhieuMuon");
                foreach (int maBanIn in lstMaBanIn)
                {
                    ChiTietPhieuMuon ctpm = new ChiTietPhieuMuon()
                    {
                        MaPhieuMuon = maPM,
                        MaBanIn = maBanIn,
                        NgayHenTra = dtpNgayMuon.Value.AddDays(7),
                        NgayTra = null,
                        GhiChu = "Đang mượn"
                    };

                    if (ctpmBLL.ThemCTPhieuMuon(ctpm))
                    {
                        BanIn bi = new BanIn()
                        {
                            MaBanIn = maBanIn,
                            TrangThai = true
                        };
                        biBLL.SuaBanIn(bi);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm chi tiết phiếu mượn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                MessageBox.Show("Lập phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lập phiếu mượn thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstMaBanIn.Clear();
            cmbDocGia.SelectedIndex = 0;
            cmbDocGia_SelectedIndexChanged(sender, e);
            fpnlDSDauSachMuon.Controls.Clear();
        }
    }
}
