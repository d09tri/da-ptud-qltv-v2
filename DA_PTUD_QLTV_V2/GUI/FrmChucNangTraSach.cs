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
        CTPhieuMuonBLL ctpmBLL = new CTPhieuMuonBLL();
        PhieuTraBLL ptBLL = new PhieuTraBLL();
        CTPhieuTraBLL ctptBLL = new CTPhieuTraBLL();

        DauSachBLL dsBLL = new DauSachBLL();
        NhaXuatBanBLL nxbBLL = new NhaXuatBanBLL();
        TheLoaiBLL tlBLL = new TheLoaiBLL();

        List<ChiTietPhieuTra> lstCTPhieuTra;
        Helper helper = new Helper();

        public FrmChucNangTraSach()
        {
            InitializeComponent();
            dgvDSCTPhieuMuon.AutoGenerateColumns = false;
            dgvDSCTPhieuTra.AutoGenerateColumns = false;
        }

        private void LoadDuLieu()
        {
            cmbPhieuMuon.DataSource = pmBLL.GetDSView_DSPhieuMuonTheoTinhTrang(false);
            cmbPhieuMuon.DisplayMember = "MaPhieuMuon";
            cmbPhieuMuon.ValueMember = "MaPhieuMuon";
        }

        private void LoadDefault(object sender, EventArgs e)
        {
            LoadDuLieu();
            
            if (cmbPhieuMuon.Items.Count > 0)
            {
                cmbPhieuMuon.SelectedIndex = 0;
                cmbPhieuMuon_SelectedIndexChanged(sender, e);
            }
            else
            {
                grbTTPhieuMuon.Text = "Không có phiếu mượn chưa trả";
                cmbPhieuMuon.DataSource = null;
            }

            lstCTPhieuTra = new List<ChiTietPhieuTra>();
            PopulateDgvDSCTPhieuTra();
            ucThongTinDauSach.TenSach = string.Empty;
            ucThongTinDauSach.TheLoai = string.Empty;
            ucThongTinDauSach.TacGia = string.Empty;
            ucThongTinDauSach.NhaXuatBan = string.Empty;
            ucThongTinDauSach.NamXuatBan = string.Empty;
            ucThongTinDauSach.MaBanIn = string.Empty;

            string duongDan = helper.LayDuongDanAnhBia() + "page-not-found.png";
            Image anhBia = helper.LayAnhBiaDauSach(duongDan);
            ucThongTinDauSach.AnhBia = anhBia;
            ucThongTinDauSach.LoadAnhBia();
        }

        private void LoadThongTinBanIn(int maBanIn)
        {
            DauSach ds = dsBLL.GetDauSachTheoMaBanIn(maBanIn);
            ucThongTinDauSach.TenSach = ds.TenSach;
            ucThongTinDauSach.TheLoai = tlBLL.GetTheLoaiTheoMa((int)ds.MaTheLoai).TenTheLoai;
            ucThongTinDauSach.TacGia = ds.TacGia;
            ucThongTinDauSach.NhaXuatBan = nxbBLL.GetNhaXuatBanTheoMa((int)ds.MaNXB).TenNXB;
            ucThongTinDauSach.NamXuatBan = ds.NamXB.Value.ToShortDateString();
            ucThongTinDauSach.MaBanIn = maBanIn.ToString();

            string duongDan = helper.LayDuongDanAnhBia() + ds.BiaSach;
            Image anhBia = helper.LayAnhBiaDauSach(duongDan);
            ucThongTinDauSach.AnhBia = anhBia;
            ucThongTinDauSach.LoadAnhBia();
        }

        private void PopulateDgvDSCTPhieuTra()
        {
            dgvDSCTPhieuTra.DataSource = null;
            dgvDSCTPhieuTra.ClearSelection();
            dgvDSCTPhieuTra.DataSource = lstCTPhieuTra;
        }

        private void FrmChucNangTraSach_Load(object sender, EventArgs e)
        {
            LoadDefault(sender, e);
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

            dgvDSCTPhieuMuon.DataSource = null;
            dgvDSCTPhieuMuon.ClearSelection();
            dgvDSCTPhieuMuon.DataSource = ctpmBLL.GetDSCTPhieuMuonTheoMa(int.Parse(maPhieuMuon));
        }

        private void btnThemCTPhieuTra_Click(object sender, EventArgs e)
        {
            if (dgvDSCTPhieuMuon.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết phiếu mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDSCTPhieuMuon.Focus();
                return;
            }

            DataGridViewRow r = dgvDSCTPhieuMuon.SelectedRows[0];
            ChiTietPhieuTra ctpt = new ChiTietPhieuTra()
            {
                MaBanIn = int.Parse(r.Cells[1].Value.ToString()),
                DaTra = true
            };

            if (lstCTPhieuTra.Any(t => t.MaBanIn == ctpt.MaBanIn))
            {
                MessageBox.Show("Đã tồn tại chi tiết phiếu trả với mã bản in " + ctpt.MaBanIn.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lstCTPhieuTra.Add(ctpt);
                PopulateDgvDSCTPhieuTra();
                r.DefaultCellStyle.BackColor = Color.Turquoise;
            }
        }

        private void btnXoaCTPhieuTra_Click(object sender, EventArgs e)
        {
            if (dgvDSCTPhieuMuon.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết phiếu mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDSCTPhieuMuon.Focus();
                return;
            }

            DataGridViewRow r = dgvDSCTPhieuMuon.SelectedRows[0];
            int maBanIn = int.Parse(r.Cells[1].Value.ToString());

            if (lstCTPhieuTra.Any(t => t.MaBanIn == maBanIn))
            {
                ChiTietPhieuTra ctpt = lstCTPhieuTra.First(t => t.MaBanIn == maBanIn);
                lstCTPhieuTra.Remove(ctpt);
                PopulateDgvDSCTPhieuTra();
                r.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Không có chi tiết phiếu trả với mã bản in " + maBanIn.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dgvDSCTPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow r = dgvDSCTPhieuMuon.SelectedRows[0];
            int maBanIn = int.Parse(r.Cells[1].Value.ToString());
            LoadThongTinBanIn(maBanIn);
        }

        private void dgvDSCTPhieuTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow r = dgvDSCTPhieuTra.SelectedRows[0];
            int maBanIn = int.Parse(r.Cells[0].Value.ToString());
            LoadThongTinBanIn(maBanIn);
        }

        private bool CapNhatCTPhieuMuon(int maPhieuMuon, int maBanIn)
        {
            string ghiChu = "";
            ChiTietPhieuMuon ctpm = ctpmBLL.GetCTPhieuMuonTheoMaPhieuMuonVaMaBanIn(maPhieuMuon, maBanIn);

            if (ctpm.NgayHenTra < DateTime.Now)
            {
                ghiChu = "Trả trễ";
            }
            else
            {
                ghiChu = "Đã trả";
            }

            ctpm.NgayTra = DateTime.Now;
            ctpm.GhiChu = ghiChu;

            return ctpmBLL.SuaCTPhieuMuon(ctpm);
        }

        private int CapNhatTinhTrangPhieuMuon(int maPhieuMuon)
        {
            List<ChiTietPhieuMuon> lstCTPhieuMuon = ctpmBLL.GetDSCTPhieuMuonTheoMa(maPhieuMuon);
            if (lstCTPhieuMuon.Any(t => t.NgayTra == null))
                return 0;
            else
            {
                if (pmBLL.SuaTinhTrangPhieuMuon(maPhieuMuon, true))
                    return 1;
                else
                    return -1;
            }
        }

        private void btnLapPhieuTra_Click(object sender, EventArgs e)
        {
            if (lstCTPhieuTra.Count <= 0)
            {
                MessageBox.Show("Chưa có chi tiết phiếu trả, vui lòng thêm vào ít nhất một chi tiết phiếu trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int maPhieuMuon = int.Parse(cmbPhieuMuon.SelectedValue.ToString());

            PhieuTra pt = new PhieuTra()
            {
                MaPhieuMuon = maPhieuMuon,
                MaNhanVien = 1,
                MaThe = int.Parse(txtMaThe.Text),
                NgayTra = DateTime.Now
            };

            if (ptBLL.TaoPhieuTra(pt))
            {
                int maPT = helper.LayThongTinMaVuaThem("PhieuTra");

                foreach (ChiTietPhieuTra ctpt in lstCTPhieuTra)
                {
                    ctpt.MaPhieuTra = maPT;

                    if (ctptBLL.ThemCTPhieuTra(ctpt))
                    {
                        if (CapNhatCTPhieuMuon(maPhieuMuon, ctpt.MaBanIn))
                        {
                            continue;
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi trong quá trình cập nhật chi tiết phiếu mượn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm chi tiết phiếu trả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                if (CapNhatTinhTrangPhieuMuon(maPhieuMuon) == -1)
                {
                    MessageBox.Show("Có lỗi trong quá trình cập nhật tình trạng phiếu mượn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Lập phiếu trả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbPhieuMuon.Items.Clear();
            LoadDefault(sender, e);
        }
    }
}
