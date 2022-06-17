namespace GUI
{
    partial class FrmQuanLyTheThuVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyTheThuVien));
            this.grbTTTheThuVien = new System.Windows.Forms.GroupBox();
            this.chkTinhTrang = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.toolStripChucNang = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTenDocGia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaThe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDSTheThuVien = new System.Windows.Forms.DataGridView();
            this.MaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTimKiemDocGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grbTTTheThuVien.SuspendLayout();
            this.toolStripChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheThuVien)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTTheThuVien
            // 
            this.grbTTTheThuVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTTTheThuVien.Controls.Add(this.chkTinhTrang);
            this.grbTTTheThuVien.Controls.Add(this.label7);
            this.grbTTTheThuVien.Controls.Add(this.rtxtGhiChu);
            this.grbTTTheThuVien.Controls.Add(this.toolStripChucNang);
            this.grbTTTheThuVien.Controls.Add(this.label5);
            this.grbTTTheThuVien.Controls.Add(this.dtpNgayHetHan);
            this.grbTTTheThuVien.Controls.Add(this.label3);
            this.grbTTTheThuVien.Controls.Add(this.dtpNgayLap);
            this.grbTTTheThuVien.Controls.Add(this.label2);
            this.grbTTTheThuVien.Controls.Add(this.cmbTenDocGia);
            this.grbTTTheThuVien.Controls.Add(this.label1);
            this.grbTTTheThuVien.Controls.Add(this.lblMaThe);
            this.grbTTTheThuVien.Controls.Add(this.label4);
            this.grbTTTheThuVien.Location = new System.Drawing.Point(601, 61);
            this.grbTTTheThuVien.Margin = new System.Windows.Forms.Padding(2);
            this.grbTTTheThuVien.Name = "grbTTTheThuVien";
            this.grbTTTheThuVien.Padding = new System.Windows.Forms.Padding(2);
            this.grbTTTheThuVien.Size = new System.Drawing.Size(377, 274);
            this.grbTTTheThuVien.TabIndex = 0;
            this.grbTTTheThuVien.TabStop = false;
            this.grbTTTheThuVien.Text = "Thông tin thẻ thư viện";
            // 
            // chkTinhTrang
            // 
            this.chkTinhTrang.AutoSize = true;
            this.chkTinhTrang.Location = new System.Drawing.Point(68, 95);
            this.chkTinhTrang.Name = "chkTinhTrang";
            this.chkTinhTrang.Size = new System.Drawing.Size(104, 17);
            this.chkTinhTrang.TabIndex = 43;
            this.chkTinhTrang.Text = "Đang hoạt động";
            this.chkTinhTrang.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Tình trạng:";
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(8, 136);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(364, 133);
            this.rtxtGhiChu.TabIndex = 41;
            this.rtxtGhiChu.Text = "";
            // 
            // toolStripChucNang
            // 
            this.toolStripChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.separator,
            this.btnLuu,
            this.btnHuy});
            this.toolStripChucNang.Location = new System.Drawing.Point(2, 15);
            this.toolStripChucNang.Name = "toolStripChucNang";
            this.toolStripChucNang.Size = new System.Drawing.Size(373, 25);
            this.toolStripChucNang.TabIndex = 39;
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
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(47, 22);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(49, 22);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ghi chú:";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(269, 69);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(103, 20);
            this.dtpNgayHetHan.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ngày hết hạn:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(68, 69);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(103, 20);
            this.dtpNgayLap.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ngày lập:";
            // 
            // cmbTenDocGia
            // 
            this.cmbTenDocGia.FormattingEnabled = true;
            this.cmbTenDocGia.Location = new System.Drawing.Point(269, 43);
            this.cmbTenDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTenDocGia.Name = "cmbTenDocGia";
            this.cmbTenDocGia.Size = new System.Drawing.Size(103, 21);
            this.cmbTenDocGia.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên độc giả:";
            // 
            // lblMaThe
            // 
            this.lblMaThe.AutoSize = true;
            this.lblMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaThe.Location = new System.Drawing.Point(65, 48);
            this.lblMaThe.Name = "lblMaThe";
            this.lblMaThe.Size = new System.Drawing.Size(0, 13);
            this.lblMaThe.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã thẻ:";
            // 
            // dgvDSTheThuVien
            // 
            this.dgvDSTheThuVien.AllowUserToAddRows = false;
            this.dgvDSTheThuVien.AllowUserToDeleteRows = false;
            this.dgvDSTheThuVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSTheThuVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTheThuVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTheThuVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThe,
            this.MaDocGia,
            this.NgayLap,
            this.NgayHetHan,
            this.GhiChu,
            this.TinhTrang});
            this.dgvDSTheThuVien.Location = new System.Drawing.Point(11, 126);
            this.dgvDSTheThuVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSTheThuVien.MultiSelect = false;
            this.dgvDSTheThuVien.Name = "dgvDSTheThuVien";
            this.dgvDSTheThuVien.ReadOnly = true;
            this.dgvDSTheThuVien.RowTemplate.Height = 28;
            this.dgvDSTheThuVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSTheThuVien.Size = new System.Drawing.Size(586, 413);
            this.dgvDSTheThuVien.TabIndex = 0;
            this.dgvDSTheThuVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTheThuVien_CellClick);
            // 
            // MaThe
            // 
            this.MaThe.DataPropertyName = "MaThe";
            this.MaThe.HeaderText = "Mã thẻ";
            this.MaThe.Name = "MaThe";
            this.MaThe.ReadOnly = true;
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "TenDocGia";
            this.MaDocGia.HeaderText = "Tên đọc giả";
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTimKiem.Controls.Add(this.txtTimKiemDocGia);
            this.grbTimKiem.Controls.Add(this.label6);
            this.grbTimKiem.Location = new System.Drawing.Point(11, 61);
            this.grbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Padding = new System.Windows.Forms.Padding(2);
            this.grbTimKiem.Size = new System.Drawing.Size(586, 61);
            this.grbTimKiem.TabIndex = 4;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm độc giả";
            // 
            // txtTimKiemDocGia
            // 
            this.txtTimKiemDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemDocGia.Location = new System.Drawing.Point(80, 27);
            this.txtTimKiemDocGia.Name = "txtTimKiemDocGia";
            this.txtTimKiemDocGia.Size = new System.Drawing.Size(501, 20);
            this.txtTimKiemDocGia.TabIndex = 3;
            this.txtTimKiemDocGia.TextChanged += new System.EventHandler(this.txtTimKiemDocGia_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên độc giả:";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(989, 56);
            this.pnlTieuDe.TabIndex = 17;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(989, 56);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ THẺ THƯ VIỆN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmQuanLyTheThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.dgvDSTheThuVien);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.grbTTTheThuVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQuanLyTheThuVien";
            this.Text = "FrmQuanLyTheThuVien";
            this.Load += new System.EventHandler(this.FrmQuanLyTheThuVien_Load);
            this.grbTTTheThuVien.ResumeLayout(false);
            this.grbTTTheThuVien.PerformLayout();
            this.toolStripChucNang.ResumeLayout(false);
            this.toolStripChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheThuVien)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.pnlTieuDe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTTheThuVien;
        private System.Windows.Forms.Label lblMaThe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTenDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ToolStrip toolStripChucNang;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.DataGridView dgvDSTheThuVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TinhTrang;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemDocGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkTinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
    }
}