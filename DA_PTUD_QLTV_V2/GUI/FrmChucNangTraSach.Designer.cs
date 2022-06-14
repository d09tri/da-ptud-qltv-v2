namespace GUI
{
    partial class FrmChucNangTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChucNangTraSach));
            this.grbTTPhieuMuon = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPhieuMuon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTinhTrang = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.btnLapPhieuTra = new System.Windows.Forms.Button();
            this.grbCTPhieuMuon = new System.Windows.Forms.GroupBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnThemCTPhieuTra = new System.Windows.Forms.ToolStripButton();
            this.btnXoaCTPhieuTra = new System.Windows.Forms.ToolStripButton();
            this.dgvDSCTPhieuMuon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCTPhieuTra = new System.Windows.Forms.GroupBox();
            this.dgvDSCTPhieuTra = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ucThongTinDauSach = new CustomControls.UcThongTinDauSach();
            this.grbTTPhieuMuon.SuspendLayout();
            this.grbCTPhieuMuon.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPhieuMuon)).BeginInit();
            this.grbCTPhieuTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPhieuTra)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTPhieuMuon
            // 
            this.grbTTPhieuMuon.Controls.Add(this.label6);
            this.grbTTPhieuMuon.Controls.Add(this.label1);
            this.grbTTPhieuMuon.Controls.Add(this.cmbPhieuMuon);
            this.grbTTPhieuMuon.Controls.Add(this.label5);
            this.grbTTPhieuMuon.Controls.Add(this.chkTinhTrang);
            this.grbTTPhieuMuon.Controls.Add(this.label4);
            this.grbTTPhieuMuon.Controls.Add(this.txtNhanVien);
            this.grbTTPhieuMuon.Controls.Add(this.label3);
            this.grbTTPhieuMuon.Controls.Add(this.txtDocGia);
            this.grbTTPhieuMuon.Controls.Add(this.label2);
            this.grbTTPhieuMuon.Controls.Add(this.txtMaThe);
            this.grbTTPhieuMuon.Controls.Add(this.dtpNgayMuon);
            this.grbTTPhieuMuon.Location = new System.Drawing.Point(12, 12);
            this.grbTTPhieuMuon.Name = "grbTTPhieuMuon";
            this.grbTTPhieuMuon.Size = new System.Drawing.Size(248, 227);
            this.grbTTPhieuMuon.TabIndex = 14;
            this.grbTTPhieuMuon.TabStop = false;
            this.grbTTPhieuMuon.Text = "Thông tin phiếu mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tình trạng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu mượn:";
            // 
            // cmbPhieuMuon
            // 
            this.cmbPhieuMuon.FormattingEnabled = true;
            this.cmbPhieuMuon.Location = new System.Drawing.Point(95, 24);
            this.cmbPhieuMuon.Name = "cmbPhieuMuon";
            this.cmbPhieuMuon.Size = new System.Drawing.Size(147, 21);
            this.cmbPhieuMuon.TabIndex = 1;
            this.cmbPhieuMuon.SelectedIndexChanged += new System.EventHandler(this.cmbPhieuMuon_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày mượn:";
            // 
            // chkTinhTrang
            // 
            this.chkTinhTrang.AutoSize = true;
            this.chkTinhTrang.Location = new System.Drawing.Point(95, 158);
            this.chkTinhTrang.Name = "chkTinhTrang";
            this.chkTinhTrang.Size = new System.Drawing.Size(55, 17);
            this.chkTinhTrang.TabIndex = 12;
            this.chkTinhTrang.Text = "Đã trả";
            this.chkTinhTrang.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã thẻ:";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(95, 51);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(147, 20);
            this.txtNhanVien.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Độc giả:";
            // 
            // txtDocGia
            // 
            this.txtDocGia.Location = new System.Drawing.Point(95, 77);
            this.txtDocGia.Name = "txtDocGia";
            this.txtDocGia.Size = new System.Drawing.Size(147, 20);
            this.txtDocGia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhân viên:";
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(95, 103);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(147, 20);
            this.txtMaThe.TabIndex = 5;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(95, 129);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(78, 20);
            this.dtpNgayMuon.TabIndex = 8;
            // 
            // btnLapPhieuTra
            // 
            this.btnLapPhieuTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapPhieuTra.Location = new System.Drawing.Point(812, 264);
            this.btnLapPhieuTra.Name = "btnLapPhieuTra";
            this.btnLapPhieuTra.Size = new System.Drawing.Size(147, 23);
            this.btnLapPhieuTra.TabIndex = 13;
            this.btnLapPhieuTra.Text = "Lập phiếu trả";
            this.btnLapPhieuTra.UseVisualStyleBackColor = true;
            this.btnLapPhieuTra.Click += new System.EventHandler(this.btnLapPhieuTra_Click);
            // 
            // grbCTPhieuMuon
            // 
            this.grbCTPhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCTPhieuMuon.Controls.Add(this.toolStrip);
            this.grbCTPhieuMuon.Controls.Add(this.dgvDSCTPhieuMuon);
            this.grbCTPhieuMuon.Location = new System.Drawing.Point(266, 12);
            this.grbCTPhieuMuon.Name = "grbCTPhieuMuon";
            this.grbCTPhieuMuon.Size = new System.Drawing.Size(711, 227);
            this.grbCTPhieuMuon.TabIndex = 13;
            this.grbCTPhieuMuon.TabStop = false;
            this.grbCTPhieuMuon.Text = "Chi tiết phiếu mượn";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCTPhieuTra,
            this.btnXoaCTPhieuTra});
            this.toolStrip.Location = new System.Drawing.Point(3, 16);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(705, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip2";
            // 
            // btnThemCTPhieuTra
            // 
            this.btnThemCTPhieuTra.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCTPhieuTra.Image")));
            this.btnThemCTPhieuTra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemCTPhieuTra.Name = "btnThemCTPhieuTra";
            this.btnThemCTPhieuTra.Size = new System.Drawing.Size(146, 22);
            this.btnThemCTPhieuTra.Text = "Thêm chi tiết phiếu trả";
            this.btnThemCTPhieuTra.Click += new System.EventHandler(this.btnThemCTPhieuTra_Click);
            // 
            // btnXoaCTPhieuTra
            // 
            this.btnXoaCTPhieuTra.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCTPhieuTra.Image")));
            this.btnXoaCTPhieuTra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaCTPhieuTra.Name = "btnXoaCTPhieuTra";
            this.btnXoaCTPhieuTra.Size = new System.Drawing.Size(136, 22);
            this.btnXoaCTPhieuTra.Text = "Xóa chi tiết phiếu trả";
            this.btnXoaCTPhieuTra.Click += new System.EventHandler(this.btnXoaCTPhieuTra_Click);
            // 
            // dgvDSCTPhieuMuon
            // 
            this.dgvDSCTPhieuMuon.AllowUserToAddRows = false;
            this.dgvDSCTPhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSCTPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCTPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDSCTPhieuMuon.Location = new System.Drawing.Point(6, 44);
            this.dgvDSCTPhieuMuon.MultiSelect = false;
            this.dgvDSCTPhieuMuon.Name = "dgvDSCTPhieuMuon";
            this.dgvDSCTPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCTPhieuMuon.Size = new System.Drawing.Size(699, 177);
            this.dgvDSCTPhieuMuon.TabIndex = 1;
            this.dgvDSCTPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCTPhieuMuon_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieuMuon";
            this.Column1.HeaderText = "Mã phiếu mượn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaBanIn";
            this.Column2.HeaderText = "Mã bản in";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayHenTra";
            this.Column3.HeaderText = "Ngày hẹn trả";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayTra";
            this.Column4.HeaderText = "Ngày trả";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GhiChu";
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // grbCTPhieuTra
            // 
            this.grbCTPhieuTra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCTPhieuTra.Controls.Add(this.btnLapPhieuTra);
            this.grbCTPhieuTra.Controls.Add(this.dgvDSCTPhieuTra);
            this.grbCTPhieuTra.Controls.Add(this.ucThongTinDauSach);
            this.grbCTPhieuTra.Location = new System.Drawing.Point(12, 245);
            this.grbCTPhieuTra.Name = "grbCTPhieuTra";
            this.grbCTPhieuTra.Size = new System.Drawing.Size(965, 293);
            this.grbCTPhieuTra.TabIndex = 1;
            this.grbCTPhieuTra.TabStop = false;
            this.grbCTPhieuTra.Text = "Chi tiết phiếu trả";
            // 
            // dgvDSCTPhieuTra
            // 
            this.dgvDSCTPhieuTra.AllowUserToAddRows = false;
            this.dgvDSCTPhieuTra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDSCTPhieuTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCTPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTPhieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
            this.dgvDSCTPhieuTra.Location = new System.Drawing.Point(9, 19);
            this.dgvDSCTPhieuTra.MultiSelect = false;
            this.dgvDSCTPhieuTra.Name = "dgvDSCTPhieuTra";
            this.dgvDSCTPhieuTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCTPhieuTra.Size = new System.Drawing.Size(233, 268);
            this.dgvDSCTPhieuTra.TabIndex = 1;
            this.dgvDSCTPhieuTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCTPhieuTra_CellClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaBanIn";
            this.Column6.HeaderText = "Mã bản in";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DaTra";
            this.Column7.HeaderText = "Đã trả";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // ucThongTinDauSach
            // 
            this.ucThongTinDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucThongTinDauSach.AnhBia = null;
            this.ucThongTinDauSach.Location = new System.Drawing.Point(260, 19);
            this.ucThongTinDauSach.MaBanIn = null;
            this.ucThongTinDauSach.Name = "ucThongTinDauSach";
            this.ucThongTinDauSach.NamXuatBan = null;
            this.ucThongTinDauSach.NhaXuatBan = null;
            this.ucThongTinDauSach.Size = new System.Drawing.Size(699, 167);
            this.ucThongTinDauSach.TabIndex = 0;
            this.ucThongTinDauSach.TacGia = null;
            this.ucThongTinDauSach.TenSach = null;
            this.ucThongTinDauSach.TheLoai = null;
            // 
            // FrmChucNangTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.grbCTPhieuMuon);
            this.Controls.Add(this.grbTTPhieuMuon);
            this.Controls.Add(this.grbCTPhieuTra);
            this.Name = "FrmChucNangTraSach";
            this.Load += new System.EventHandler(this.FrmChucNangTraSach_Load);
            this.grbTTPhieuMuon.ResumeLayout(false);
            this.grbTTPhieuMuon.PerformLayout();
            this.grbCTPhieuMuon.ResumeLayout(false);
            this.grbCTPhieuMuon.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPhieuMuon)).EndInit();
            this.grbCTPhieuTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPhieuTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPhieuMuon;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.TextBox txtDocGia;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkTinhTrang;
        private System.Windows.Forms.GroupBox grbCTPhieuMuon;
        private System.Windows.Forms.GroupBox grbTTPhieuMuon;
        private System.Windows.Forms.DataGridView dgvDSCTPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnLapPhieuTra;
        private System.Windows.Forms.GroupBox grbCTPhieuTra;
        private CustomControls.UcThongTinDauSach ucThongTinDauSach;
        private System.Windows.Forms.DataGridView dgvDSCTPhieuTra;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnThemCTPhieuTra;
        private System.Windows.Forms.ToolStripButton btnXoaCTPhieuTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.Label label6;
    }
}