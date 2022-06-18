namespace GUI
{
    partial class FrmChucNangMuonSach
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
            this.grbDSSachMuon = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoadDauSach = new System.Windows.Forms.Button();
            this.btnQuetDauSach = new System.Windows.Forms.Button();
            this.fpnlDSDauSachMuon = new System.Windows.Forms.FlowLayoutPanel();
            this.grbTTPhieuMuon = new System.Windows.Forms.GroupBox();
            this.grbDieuKien = new System.Windows.Forms.GroupBox();
            this.dgvDSCTPhieuMuonChuaTra = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSLDauSachChuaTra = new System.Windows.Forms.TextBox();
            this.txtSLPhieuMuonChuaTra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTheThuVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDocGia = new System.Windows.Forms.ComboBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grbDSSachMuon.SuspendLayout();
            this.grbTTPhieuMuon.SuspendLayout();
            this.grbDieuKien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPhieuMuonChuaTra)).BeginInit();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDSSachMuon
            // 
            this.grbDSSachMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDSSachMuon.Controls.Add(this.label5);
            this.grbDSSachMuon.Controls.Add(this.btnLoadDauSach);
            this.grbDSSachMuon.Controls.Add(this.btnQuetDauSach);
            this.grbDSSachMuon.Controls.Add(this.fpnlDSDauSachMuon);
            this.grbDSSachMuon.Location = new System.Drawing.Point(279, 62);
            this.grbDSSachMuon.Name = "grbDSSachMuon";
            this.grbDSSachMuon.Size = new System.Drawing.Size(698, 476);
            this.grbDSSachMuon.TabIndex = 0;
            this.grbDSSachMuon.TabStop = false;
            this.grbDSSachMuon.Text = "Danh sách đầu sách mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lưu ý: Nhấn chọn \"Load đầu sách\" sau khi đã quét xong đầu sách mượn";
            // 
            // btnLoadDauSach
            // 
            this.btnLoadDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadDauSach.ForeColor = System.Drawing.Color.Black;
            this.btnLoadDauSach.Location = new System.Drawing.Point(598, 19);
            this.btnLoadDauSach.Name = "btnLoadDauSach";
            this.btnLoadDauSach.Size = new System.Drawing.Size(94, 23);
            this.btnLoadDauSach.TabIndex = 1;
            this.btnLoadDauSach.Text = "Load đầu sách";
            this.btnLoadDauSach.UseVisualStyleBackColor = true;
            this.btnLoadDauSach.Click += new System.EventHandler(this.btnLoadDauSach_Click);
            // 
            // btnQuetDauSach
            // 
            this.btnQuetDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuetDauSach.ForeColor = System.Drawing.Color.Black;
            this.btnQuetDauSach.Location = new System.Drawing.Point(498, 19);
            this.btnQuetDauSach.Name = "btnQuetDauSach";
            this.btnQuetDauSach.Size = new System.Drawing.Size(94, 23);
            this.btnQuetDauSach.TabIndex = 0;
            this.btnQuetDauSach.Text = "Quét đầu sách";
            this.btnQuetDauSach.UseVisualStyleBackColor = true;
            this.btnQuetDauSach.Click += new System.EventHandler(this.btnQuetDauSach_Click);
            // 
            // fpnlDSDauSachMuon
            // 
            this.fpnlDSDauSachMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnlDSDauSachMuon.AutoScroll = true;
            this.fpnlDSDauSachMuon.BackColor = System.Drawing.Color.White;
            this.fpnlDSDauSachMuon.Location = new System.Drawing.Point(3, 48);
            this.fpnlDSDauSachMuon.Name = "fpnlDSDauSachMuon";
            this.fpnlDSDauSachMuon.Size = new System.Drawing.Size(692, 425);
            this.fpnlDSDauSachMuon.TabIndex = 0;
            // 
            // grbTTPhieuMuon
            // 
            this.grbTTPhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbTTPhieuMuon.Controls.Add(this.grbDieuKien);
            this.grbTTPhieuMuon.Controls.Add(this.btnLapPhieu);
            this.grbTTPhieuMuon.Controls.Add(this.dtpNgayMuon);
            this.grbTTPhieuMuon.Controls.Add(this.label4);
            this.grbTTPhieuMuon.Controls.Add(this.label3);
            this.grbTTPhieuMuon.Controls.Add(this.txtTheThuVien);
            this.grbTTPhieuMuon.Controls.Add(this.label2);
            this.grbTTPhieuMuon.Controls.Add(this.cmbDocGia);
            this.grbTTPhieuMuon.Controls.Add(this.txtNhanVien);
            this.grbTTPhieuMuon.Controls.Add(this.label1);
            this.grbTTPhieuMuon.Location = new System.Drawing.Point(12, 62);
            this.grbTTPhieuMuon.Name = "grbTTPhieuMuon";
            this.grbTTPhieuMuon.Size = new System.Drawing.Size(261, 476);
            this.grbTTPhieuMuon.TabIndex = 1;
            this.grbTTPhieuMuon.TabStop = false;
            this.grbTTPhieuMuon.Text = "Thông tin phiếu mượn";
            // 
            // grbDieuKien
            // 
            this.grbDieuKien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbDieuKien.Controls.Add(this.dgvDSCTPhieuMuonChuaTra);
            this.grbDieuKien.Controls.Add(this.label8);
            this.grbDieuKien.Controls.Add(this.label7);
            this.grbDieuKien.Controls.Add(this.txtSLDauSachChuaTra);
            this.grbDieuKien.Controls.Add(this.txtSLPhieuMuonChuaTra);
            this.grbDieuKien.Controls.Add(this.label6);
            this.grbDieuKien.Location = new System.Drawing.Point(9, 129);
            this.grbDieuKien.Name = "grbDieuKien";
            this.grbDieuKien.Size = new System.Drawing.Size(246, 312);
            this.grbDieuKien.TabIndex = 9;
            this.grbDieuKien.TabStop = false;
            // 
            // dgvDSCTPhieuMuonChuaTra
            // 
            this.dgvDSCTPhieuMuonChuaTra.AllowUserToAddRows = false;
            this.dgvDSCTPhieuMuonChuaTra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDSCTPhieuMuonChuaTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCTPhieuMuonChuaTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTPhieuMuonChuaTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvDSCTPhieuMuonChuaTra.Location = new System.Drawing.Point(6, 90);
            this.dgvDSCTPhieuMuonChuaTra.MultiSelect = false;
            this.dgvDSCTPhieuMuonChuaTra.Name = "dgvDSCTPhieuMuonChuaTra";
            this.dgvDSCTPhieuMuonChuaTra.ReadOnly = true;
            this.dgvDSCTPhieuMuonChuaTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCTPhieuMuonChuaTra.Size = new System.Drawing.Size(234, 216);
            this.dgvDSCTPhieuMuonChuaTra.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieuMuon";
            this.Column1.HeaderText = "Phiếu mượn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaBanIn";
            this.Column2.HeaderText = "Bản in";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Đủ điều kiện cho phép mượn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tổng số đầu sách chưa trả:\r\n";
            // 
            // txtSLDauSachChuaTra
            // 
            this.txtSLDauSachChuaTra.Location = new System.Drawing.Point(161, 39);
            this.txtSLDauSachChuaTra.Name = "txtSLDauSachChuaTra";
            this.txtSLDauSachChuaTra.ReadOnly = true;
            this.txtSLDauSachChuaTra.Size = new System.Drawing.Size(43, 20);
            this.txtSLDauSachChuaTra.TabIndex = 11;
            this.txtSLDauSachChuaTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSLPhieuMuonChuaTra
            // 
            this.txtSLPhieuMuonChuaTra.Location = new System.Drawing.Point(161, 13);
            this.txtSLPhieuMuonChuaTra.Name = "txtSLPhieuMuonChuaTra";
            this.txtSLPhieuMuonChuaTra.ReadOnly = true;
            this.txtSLPhieuMuonChuaTra.Size = new System.Drawing.Size(43, 20);
            this.txtSLPhieuMuonChuaTra.TabIndex = 10;
            this.txtSLPhieuMuonChuaTra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng số phiếu mượn chưa trả:\r\n";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLapPhieu.Location = new System.Drawing.Point(9, 447);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(246, 23);
            this.btnLapPhieu.TabIndex = 8;
            this.btnLapPhieu.Text = "Lập phiếu mượn";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(82, 103);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(173, 20);
            this.dtpNgayMuon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày mượn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thẻ thư viện:";
            // 
            // txtTheThuVien
            // 
            this.txtTheThuVien.Location = new System.Drawing.Point(82, 77);
            this.txtTheThuVien.Name = "txtTheThuVien";
            this.txtTheThuVien.ReadOnly = true;
            this.txtTheThuVien.Size = new System.Drawing.Size(173, 20);
            this.txtTheThuVien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Độc giả:";
            // 
            // cmbDocGia
            // 
            this.cmbDocGia.FormattingEnabled = true;
            this.cmbDocGia.Location = new System.Drawing.Point(82, 50);
            this.cmbDocGia.Name = "cmbDocGia";
            this.cmbDocGia.Size = new System.Drawing.Size(173, 21);
            this.cmbDocGia.TabIndex = 2;
            this.cmbDocGia.SelectedIndexChanged += new System.EventHandler(this.cmbDocGia_SelectedIndexChanged);
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(82, 24);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(173, 20);
            this.txtNhanVien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên:";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(989, 56);
            this.pnlTieuDe.TabIndex = 2;
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
            this.lblTieuDe.Text = "MƯỢN SÁCH";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmChucNangMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.pnlTieuDe);
            this.Controls.Add(this.grbTTPhieuMuon);
            this.Controls.Add(this.grbDSSachMuon);
            this.Name = "FrmChucNangMuonSach";
            this.Load += new System.EventHandler(this.FrmChucNangMuonSach_Load);
            this.grbDSSachMuon.ResumeLayout(false);
            this.grbDSSachMuon.PerformLayout();
            this.grbTTPhieuMuon.ResumeLayout(false);
            this.grbTTPhieuMuon.PerformLayout();
            this.grbDieuKien.ResumeLayout(false);
            this.grbDieuKien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPhieuMuonChuaTra)).EndInit();
            this.pnlTieuDe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSSachMuon;
        private System.Windows.Forms.FlowLayoutPanel fpnlDSDauSachMuon;
        private System.Windows.Forms.Button btnLoadDauSach;
        private System.Windows.Forms.Button btnQuetDauSach;
        private System.Windows.Forms.GroupBox grbTTPhieuMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.ComboBox cmbDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTheThuVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grbDieuKien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSLDauSachChuaTra;
        private System.Windows.Forms.TextBox txtSLPhieuMuonChuaTra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDSCTPhieuMuonChuaTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}