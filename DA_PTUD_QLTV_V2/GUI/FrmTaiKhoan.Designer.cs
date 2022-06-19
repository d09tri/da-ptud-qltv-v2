namespace GUI
{
    partial class FrmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaiKhoan));
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.dgvDSNguoiDung = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.chkHoatDong = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNhom = new System.Windows.Forms.ComboBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripChucNang = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTTPhanQuyen = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNhomNguoiDung = new System.Windows.Forms.ComboBox();
            this.toolStripPhanQuyen = new System.Windows.Forms.ToolStrip();
            this.btnLuuChinhSua = new System.Windows.Forms.ToolStripButton();
            this.dgvDSPhanQuyen = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNguoiDung)).BeginInit();
            this.grbTaiKhoan.SuspendLayout();
            this.toolStripChucNang.SuspendLayout();
            this.grbTTPhanQuyen.SuspendLayout();
            this.toolStripPhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhanQuyen)).BeginInit();
            this.SuspendLayout();
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
            this.lblTieuDe.Text = "TÀI KHOẢN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDSNguoiDung
            // 
            this.dgvDSNguoiDung.AllowUserToAddRows = false;
            this.dgvDSNguoiDung.AllowUserToDeleteRows = false;
            this.dgvDSNguoiDung.AllowUserToResizeColumns = false;
            this.dgvDSNguoiDung.AllowUserToResizeRows = false;
            this.dgvDSNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDSNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDSNguoiDung.Location = new System.Drawing.Point(7, 126);
            this.dgvDSNguoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSNguoiDung.MultiSelect = false;
            this.dgvDSNguoiDung.Name = "dgvDSNguoiDung";
            this.dgvDSNguoiDung.ReadOnly = true;
            this.dgvDSNguoiDung.RowTemplate.Height = 28;
            this.dgvDSNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNguoiDung.Size = new System.Drawing.Size(452, 346);
            this.dgvDSNguoiDung.TabIndex = 18;
            this.dgvDSNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNguoiDung_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenDangNhap";
            this.Column1.FillWeight = 120F;
            this.Column1.HeaderText = "Tên đăng nhập";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MatKhau";
            this.Column2.FillWeight = 86.92893F;
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenNhanVien";
            this.Column3.FillWeight = 86.92893F;
            this.Column3.HeaderText = "Nhân viên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenNhom";
            this.Column4.FillWeight = 86.92893F;
            this.Column4.HeaderText = "Nhóm";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HoatDong";
            this.Column5.FillWeight = 86.92893F;
            this.Column5.HeaderText = "Hoạt động";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // grbTaiKhoan
            // 
            this.grbTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbTaiKhoan.Controls.Add(this.txtTenDangNhap);
            this.grbTaiKhoan.Controls.Add(this.dgvDSNguoiDung);
            this.grbTaiKhoan.Controls.Add(this.chkHoatDong);
            this.grbTaiKhoan.Controls.Add(this.label5);
            this.grbTaiKhoan.Controls.Add(this.cmbNhom);
            this.grbTaiKhoan.Controls.Add(this.cmbNhanVien);
            this.grbTaiKhoan.Controls.Add(this.label3);
            this.grbTaiKhoan.Controls.Add(this.label2);
            this.grbTaiKhoan.Controls.Add(this.txtMatKhau);
            this.grbTaiKhoan.Controls.Add(this.label4);
            this.grbTaiKhoan.Controls.Add(this.toolStripChucNang);
            this.grbTaiKhoan.Controls.Add(this.label1);
            this.grbTaiKhoan.Location = new System.Drawing.Point(11, 61);
            this.grbTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.grbTaiKhoan.Name = "grbTaiKhoan";
            this.grbTaiKhoan.Padding = new System.Windows.Forms.Padding(2);
            this.grbTaiKhoan.Size = new System.Drawing.Size(464, 477);
            this.grbTaiKhoan.TabIndex = 19;
            this.grbTaiKhoan.TabStop = false;
            this.grbTaiKhoan.Text = "Tài khoản";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(96, 48);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(119, 20);
            this.txtTenDangNhap.TabIndex = 36;
            // 
            // chkHoatDong
            // 
            this.chkHoatDong.AutoSize = true;
            this.chkHoatDong.Location = new System.Drawing.Point(96, 104);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Size = new System.Drawing.Size(104, 17);
            this.chkHoatDong.TabIndex = 35;
            this.chkHoatDong.Text = "Đang hoạt động";
            this.chkHoatDong.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tình trạng:";
            // 
            // cmbNhom
            // 
            this.cmbNhom.FormattingEnabled = true;
            this.cmbNhom.Location = new System.Drawing.Point(294, 75);
            this.cmbNhom.Name = "cmbNhom";
            this.cmbNhom.Size = new System.Drawing.Size(165, 21);
            this.cmbNhom.TabIndex = 33;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(294, 48);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(165, 21);
            this.cmbNhanVien.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(96, 75);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(119, 20);
            this.txtMatKhau.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên đăng nhập:";
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
            this.toolStripChucNang.Size = new System.Drawing.Size(460, 25);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm:";
            // 
            // grbTTPhanQuyen
            // 
            this.grbTTPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTTPhanQuyen.Controls.Add(this.dgvDSPhanQuyen);
            this.grbTTPhanQuyen.Controls.Add(this.toolStripPhanQuyen);
            this.grbTTPhanQuyen.Controls.Add(this.cmbNhomNguoiDung);
            this.grbTTPhanQuyen.Controls.Add(this.label6);
            this.grbTTPhanQuyen.Location = new System.Drawing.Point(480, 62);
            this.grbTTPhanQuyen.Name = "grbTTPhanQuyen";
            this.grbTTPhanQuyen.Size = new System.Drawing.Size(497, 476);
            this.grbTTPhanQuyen.TabIndex = 20;
            this.grbTTPhanQuyen.TabStop = false;
            this.grbTTPhanQuyen.Text = "Phân quyền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nhóm người dùng:";
            // 
            // cmbNhomNguoiDung
            // 
            this.cmbNhomNguoiDung.FormattingEnabled = true;
            this.cmbNhomNguoiDung.Location = new System.Drawing.Point(104, 47);
            this.cmbNhomNguoiDung.Name = "cmbNhomNguoiDung";
            this.cmbNhomNguoiDung.Size = new System.Drawing.Size(165, 21);
            this.cmbNhomNguoiDung.TabIndex = 37;
            this.cmbNhomNguoiDung.SelectedIndexChanged += new System.EventHandler(this.cmbNhomNguoiDung_SelectedIndexChanged);
            // 
            // toolStripPhanQuyen
            // 
            this.toolStripPhanQuyen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLuuChinhSua});
            this.toolStripPhanQuyen.Location = new System.Drawing.Point(3, 16);
            this.toolStripPhanQuyen.Name = "toolStripPhanQuyen";
            this.toolStripPhanQuyen.Size = new System.Drawing.Size(491, 25);
            this.toolStripPhanQuyen.TabIndex = 38;
            // 
            // btnLuuChinhSua
            // 
            this.btnLuuChinhSua.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuChinhSua.Image")));
            this.btnLuuChinhSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuuChinhSua.Name = "btnLuuChinhSua";
            this.btnLuuChinhSua.Size = new System.Drawing.Size(47, 22);
            this.btnLuuChinhSua.Text = "Lưu";
            this.btnLuuChinhSua.Click += new System.EventHandler(this.btnLuuChinhSua_Click);
            // 
            // dgvDSPhanQuyen
            // 
            this.dgvDSPhanQuyen.AllowUserToAddRows = false;
            this.dgvDSPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSPhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvDSPhanQuyen.Location = new System.Drawing.Point(6, 74);
            this.dgvDSPhanQuyen.MultiSelect = false;
            this.dgvDSPhanQuyen.Name = "dgvDSPhanQuyen";
            this.dgvDSPhanQuyen.RowTemplate.Height = 28;
            this.dgvDSPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhanQuyen.Size = new System.Drawing.Size(485, 396);
            this.dgvDSPhanQuyen.TabIndex = 39;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaNhom";
            this.Column6.HeaderText = "Mã nhóm";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenNhom";
            this.Column7.HeaderText = "Nhóm người dùng";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaChucNang";
            this.Column8.HeaderText = "Mã chức năng";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TenChucNang";
            this.Column9.HeaderText = "Chức năng";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "CoQuyen";
            this.Column10.HeaderText = "Có quyền";
            this.Column10.Name = "Column10";
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.grbTTPhanQuyen);
            this.Controls.Add(this.grbTaiKhoan);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "FrmTaiKhoan";
            this.Text = "FrmTaiKhoan";
            this.Load += new System.EventHandler(this.FrmTaiKhoan_Load);
            this.pnlTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNguoiDung)).EndInit();
            this.grbTaiKhoan.ResumeLayout(false);
            this.grbTaiKhoan.PerformLayout();
            this.toolStripChucNang.ResumeLayout(false);
            this.toolStripChucNang.PerformLayout();
            this.grbTTPhanQuyen.ResumeLayout(false);
            this.grbTTPhanQuyen.PerformLayout();
            this.toolStripPhanQuyen.ResumeLayout(false);
            this.toolStripPhanQuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvDSNguoiDung;
        private System.Windows.Forms.GroupBox grbTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStripChucNang;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNhom;
        private System.Windows.Forms.CheckBox chkHoatDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.GroupBox grbTTPhanQuyen;
        private System.Windows.Forms.ComboBox cmbNhomNguoiDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStripPhanQuyen;
        private System.Windows.Forms.ToolStripButton btnLuuChinhSua;
        private System.Windows.Forms.DataGridView dgvDSPhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column10;
    }
}