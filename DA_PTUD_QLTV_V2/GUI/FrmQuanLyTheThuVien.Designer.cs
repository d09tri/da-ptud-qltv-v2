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
            this.cmbGhiChu = new System.Windows.Forms.ComboBox();
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
            this.grbDSTheThuVien = new System.Windows.Forms.GroupBox();
            this.dgvDSTheThuVien = new System.Windows.Forms.DataGridView();
            this.MaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbTTTheThuVien.SuspendLayout();
            this.toolStripChucNang.SuspendLayout();
            this.grbDSTheThuVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheThuVien)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTTheThuVien
            // 
            this.grbTTTheThuVien.Controls.Add(this.cmbGhiChu);
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
            this.grbTTTheThuVien.Location = new System.Drawing.Point(12, 12);
            this.grbTTTheThuVien.Name = "grbTTTheThuVien";
            this.grbTTTheThuVien.Size = new System.Drawing.Size(495, 421);
            this.grbTTTheThuVien.TabIndex = 0;
            this.grbTTTheThuVien.TabStop = false;
            this.grbTTTheThuVien.Text = "Thông tin thẻ thư viện";
            // 
            // cmbGhiChu
            // 
            this.cmbGhiChu.FormattingEnabled = true;
            this.cmbGhiChu.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Hết hạn"});
            this.cmbGhiChu.Location = new System.Drawing.Point(147, 314);
            this.cmbGhiChu.Name = "cmbGhiChu";
            this.cmbGhiChu.Size = new System.Drawing.Size(248, 28);
            this.cmbGhiChu.TabIndex = 40;
            // 
            // toolStripChucNang
            // 
            this.toolStripChucNang.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.separator,
            this.btnLuu,
            this.btnHuy});
            this.toolStripChucNang.Location = new System.Drawing.Point(3, 22);
            this.toolStripChucNang.Name = "toolStripChucNang";
            this.toolStripChucNang.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripChucNang.Size = new System.Drawing.Size(489, 32);
            this.toolStripChucNang.TabIndex = 39;
            this.toolStripChucNang.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 29);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 29);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 29);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(6, 32);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(69, 29);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(72, 29);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ghi chú";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(147, 261);
            this.dtpNgayHetHan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(248, 26);
            this.dtpNgayHetHan.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ngày hết hạn";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(147, 204);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(248, 26);
            this.dtpNgayLap.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ngày lập";
            // 
            // cmbTenDocGia
            // 
            this.cmbTenDocGia.FormattingEnabled = true;
            this.cmbTenDocGia.Location = new System.Drawing.Point(147, 148);
            this.cmbTenDocGia.Name = "cmbTenDocGia";
            this.cmbTenDocGia.Size = new System.Drawing.Size(248, 28);
            this.cmbTenDocGia.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên đọc giả";
            // 
            // lblMaThe
            // 
            this.lblMaThe.AutoSize = true;
            this.lblMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaThe.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaThe.Location = new System.Drawing.Point(143, 102);
            this.lblMaThe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaThe.Name = "lblMaThe";
            this.lblMaThe.Size = new System.Drawing.Size(77, 20);
            this.lblMaThe.TabIndex = 30;
            this.lblMaThe.Text = "lblMaThe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã thẻ";
            // 
            // grbDSTheThuVien
            // 
            this.grbDSTheThuVien.Controls.Add(this.dgvDSTheThuVien);
            this.grbDSTheThuVien.Location = new System.Drawing.Point(534, 12);
            this.grbDSTheThuVien.Name = "grbDSTheThuVien";
            this.grbDSTheThuVien.Size = new System.Drawing.Size(997, 409);
            this.grbDSTheThuVien.TabIndex = 1;
            this.grbDSTheThuVien.TabStop = false;
            this.grbDSTheThuVien.Text = "Danh sách thẻ thư viện";
            // 
            // dgvDSTheThuVien
            // 
            this.dgvDSTheThuVien.AllowUserToAddRows = false;
            this.dgvDSTheThuVien.AllowUserToDeleteRows = false;
            this.dgvDSTheThuVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTheThuVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTheThuVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThe,
            this.MaDocGia,
            this.NgayLap,
            this.NgayHetHan,
            this.GhiChu,
            this.TinhTrang});
            this.dgvDSTheThuVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTheThuVien.Location = new System.Drawing.Point(3, 22);
            this.dgvDSTheThuVien.Name = "dgvDSTheThuVien";
            this.dgvDSTheThuVien.RowTemplate.Height = 28;
            this.dgvDSTheThuVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSTheThuVien.Size = new System.Drawing.Size(991, 384);
            this.dgvDSTheThuVien.TabIndex = 0;
            this.dgvDSTheThuVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTheThuVien_CellClick);
            // 
            // MaThe
            // 
            this.MaThe.DataPropertyName = "MaThe";
            this.MaThe.HeaderText = "Mã thẻ";
            this.MaThe.Name = "MaThe";
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "TenDocGia";
            this.MaDocGia.HeaderText = "Tên đọc giả";
            this.MaDocGia.Name = "MaDocGia";
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // FrmQuanLyTheThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 558);
            this.Controls.Add(this.grbDSTheThuVien);
            this.Controls.Add(this.grbTTTheThuVien);
            this.Name = "FrmQuanLyTheThuVien";
            this.Text = "FrmQuanLyTheThuVien";
            this.Load += new System.EventHandler(this.FrmQuanLyTheThuVien_Load);
            this.grbTTTheThuVien.ResumeLayout(false);
            this.grbTTTheThuVien.PerformLayout();
            this.toolStripChucNang.ResumeLayout(false);
            this.toolStripChucNang.PerformLayout();
            this.grbDSTheThuVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheThuVien)).EndInit();
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
        private System.Windows.Forms.GroupBox grbDSTheThuVien;
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
        private System.Windows.Forms.ComboBox cmbGhiChu;
    }
}