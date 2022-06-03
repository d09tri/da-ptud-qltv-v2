namespace GUI
{
    partial class FrmBanIn_v2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanIn_v2));
            this.grbDSBanIn = new System.Windows.Forms.GroupBox();
            this.toolStripChucNang = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.dgvDSBanIn = new System.Windows.Forms.DataGridView();
            this.colMaBanIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSach_bi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ucThongTinDauSach = new CustomControls.UcThongTinDauSach();
            this.grbDSDauSach = new System.Windows.Forms.GroupBox();
            this.dgvDSDauSach = new System.Windows.Forms.DataGridView();
            this.colMaSach_ds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbLocDauSach = new System.Windows.Forms.GroupBox();
            this.cmbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.cmbTheLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDSBanIn.SuspendLayout();
            this.toolStripChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBanIn)).BeginInit();
            this.grbDSDauSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDauSach)).BeginInit();
            this.grbLocDauSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDSBanIn
            // 
            this.grbDSBanIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDSBanIn.Controls.Add(this.toolStripChucNang);
            this.grbDSBanIn.Controls.Add(this.dgvDSBanIn);
            this.grbDSBanIn.Location = new System.Drawing.Point(440, 185);
            this.grbDSBanIn.Name = "grbDSBanIn";
            this.grbDSBanIn.Size = new System.Drawing.Size(537, 353);
            this.grbDSBanIn.TabIndex = 6;
            this.grbDSBanIn.TabStop = false;
            this.grbDSBanIn.Text = "Bản in đầu sách";
            // 
            // toolStripChucNang
            // 
            this.toolStripChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua});
            this.toolStripChucNang.Location = new System.Drawing.Point(3, 16);
            this.toolStripChucNang.Name = "toolStripChucNang";
            this.toolStripChucNang.Size = new System.Drawing.Size(531, 25);
            this.toolStripChucNang.TabIndex = 3;
            this.toolStripChucNang.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvDSBanIn
            // 
            this.dgvDSBanIn.AllowUserToAddRows = false;
            this.dgvDSBanIn.AllowUserToDeleteRows = false;
            this.dgvDSBanIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBanIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBanIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBanIn,
            this.colMaSach_bi,
            this.colTrangThai});
            this.dgvDSBanIn.Location = new System.Drawing.Point(6, 44);
            this.dgvDSBanIn.Name = "dgvDSBanIn";
            this.dgvDSBanIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSBanIn.Size = new System.Drawing.Size(525, 303);
            this.dgvDSBanIn.TabIndex = 2;
            this.dgvDSBanIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBanIn_CellClick);
            // 
            // colMaBanIn
            // 
            this.colMaBanIn.DataPropertyName = "MaBanIn";
            this.colMaBanIn.HeaderText = "Mã bản in";
            this.colMaBanIn.Name = "colMaBanIn";
            this.colMaBanIn.ReadOnly = true;
            // 
            // colMaSach_bi
            // 
            this.colMaSach_bi.DataPropertyName = "MaSach";
            this.colMaSach_bi.HeaderText = "Mã sách";
            this.colMaSach_bi.Name = "colMaSach_bi";
            this.colMaSach_bi.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Đã mượn";
            this.colTrangThai.Name = "colTrangThai";
            // 
            // ucThongTinDauSach
            // 
            this.ucThongTinDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucThongTinDauSach.AnhBia = null;
            this.ucThongTinDauSach.Location = new System.Drawing.Point(440, 12);
            this.ucThongTinDauSach.Name = "ucThongTinDauSach";
            this.ucThongTinDauSach.NamXuatBan = null;
            this.ucThongTinDauSach.NhaXuatBan = null;
            this.ucThongTinDauSach.Size = new System.Drawing.Size(537, 167);
            this.ucThongTinDauSach.TabIndex = 5;
            this.ucThongTinDauSach.TacGia = null;
            this.ucThongTinDauSach.TenSach = null;
            this.ucThongTinDauSach.TheLoai = null;
            // 
            // grbDSDauSach
            // 
            this.grbDSDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDSDauSach.Controls.Add(this.dgvDSDauSach);
            this.grbDSDauSach.Controls.Add(this.grbLocDauSach);
            this.grbDSDauSach.Location = new System.Drawing.Point(12, 12);
            this.grbDSDauSach.Name = "grbDSDauSach";
            this.grbDSDauSach.Size = new System.Drawing.Size(422, 526);
            this.grbDSDauSach.TabIndex = 4;
            this.grbDSDauSach.TabStop = false;
            this.grbDSDauSach.Text = "Danh sách đầu sách";
            // 
            // dgvDSDauSach
            // 
            this.dgvDSDauSach.AllowUserToAddRows = false;
            this.dgvDSDauSach.AllowUserToDeleteRows = false;
            this.dgvDSDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach_ds,
            this.colTenSach});
            this.dgvDSDauSach.Location = new System.Drawing.Point(6, 125);
            this.dgvDSDauSach.MultiSelect = false;
            this.dgvDSDauSach.Name = "dgvDSDauSach";
            this.dgvDSDauSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDauSach.Size = new System.Drawing.Size(410, 395);
            this.dgvDSDauSach.TabIndex = 1;
            this.dgvDSDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDauSach_CellClick);
            // 
            // colMaSach_ds
            // 
            this.colMaSach_ds.DataPropertyName = "MaSach";
            this.colMaSach_ds.HeaderText = "Mã sách";
            this.colMaSach_ds.Name = "colMaSach_ds";
            this.colMaSach_ds.ReadOnly = true;
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            // 
            // grbLocDauSach
            // 
            this.grbLocDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLocDauSach.Controls.Add(this.cmbNhaXuatBan);
            this.grbLocDauSach.Controls.Add(this.cmbTheLoai);
            this.grbLocDauSach.Controls.Add(this.label3);
            this.grbLocDauSach.Controls.Add(this.label4);
            this.grbLocDauSach.Location = new System.Drawing.Point(6, 19);
            this.grbLocDauSach.Name = "grbLocDauSach";
            this.grbLocDauSach.Size = new System.Drawing.Size(410, 100);
            this.grbLocDauSach.TabIndex = 0;
            this.grbLocDauSach.TabStop = false;
            // 
            // cmbNhaXuatBan
            // 
            this.cmbNhaXuatBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNhaXuatBan.FormattingEnabled = true;
            this.cmbNhaXuatBan.Location = new System.Drawing.Point(83, 58);
            this.cmbNhaXuatBan.Name = "cmbNhaXuatBan";
            this.cmbNhaXuatBan.Size = new System.Drawing.Size(321, 21);
            this.cmbNhaXuatBan.TabIndex = 3;
            this.cmbNhaXuatBan.SelectedIndexChanged += new System.EventHandler(this.cmbNhaXuatBan_SelectedIndexChanged);
            // 
            // cmbTheLoai
            // 
            this.cmbTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTheLoai.FormattingEnabled = true;
            this.cmbTheLoai.Location = new System.Drawing.Point(83, 31);
            this.cmbTheLoai.Name = "cmbTheLoai";
            this.cmbTheLoai.Size = new System.Drawing.Size(321, 21);
            this.cmbTheLoai.TabIndex = 2;
            this.cmbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cmbTheLoai_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhà xuất bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thể loại";
            // 
            // FrmBanIn_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.grbDSBanIn);
            this.Controls.Add(this.ucThongTinDauSach);
            this.Controls.Add(this.grbDSDauSach);
            this.Name = "FrmBanIn_v2";
            this.Text = "FrmBanIn_v2";
            this.Load += new System.EventHandler(this.FrmBanIn_v2_Load);
            this.grbDSBanIn.ResumeLayout(false);
            this.grbDSBanIn.PerformLayout();
            this.toolStripChucNang.ResumeLayout(false);
            this.toolStripChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBanIn)).EndInit();
            this.grbDSDauSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDauSach)).EndInit();
            this.grbLocDauSach.ResumeLayout(false);
            this.grbLocDauSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSBanIn;
        private System.Windows.Forms.ToolStrip toolStripChucNang;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.DataGridView dgvDSBanIn;
        private CustomControls.UcThongTinDauSach ucThongTinDauSach;
        private System.Windows.Forms.GroupBox grbDSDauSach;
        private System.Windows.Forms.DataGridView dgvDSDauSach;
        private System.Windows.Forms.GroupBox grbLocDauSach;
        private System.Windows.Forms.ComboBox cmbNhaXuatBan;
        private System.Windows.Forms.ComboBox cmbTheLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBanIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach_bi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach_ds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
    }
}