namespace GUI
{
    partial class FrmBanIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanIn));
            this.grbDSBanIn = new System.Windows.Forms.GroupBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.bthThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.dgvDSBanIn = new System.Windows.Forms.DataGridView();
            this.colMaBanIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSach_bi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbLocDauSach = new System.Windows.Forms.GroupBox();
            this.cmbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.cmbTheLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSDauSach = new System.Windows.Forms.DataGridView();
            this.colMaSach_ds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDSDauSach = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ucThongTinDauSach1 = new CustomControls.UcThongTinDauSach();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.grbDSBanIn.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBanIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDauSach)).BeginInit();
            this.grbDSDauSach.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDSBanIn
            // 
            this.grbDSBanIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDSBanIn.Controls.Add(this.toolStrip);
            this.grbDSBanIn.Controls.Add(this.dgvDSBanIn);
            this.grbDSBanIn.Location = new System.Drawing.Point(432, 185);
            this.grbDSBanIn.Name = "grbDSBanIn";
            this.grbDSBanIn.Size = new System.Drawing.Size(537, 310);
            this.grbDSBanIn.TabIndex = 2;
            this.grbDSBanIn.TabStop = false;
            this.grbDSBanIn.Text = "Bản in đầu sách";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bthThem,
            this.btnXoa,
            this.btnSua});
            this.toolStrip.Location = new System.Drawing.Point(3, 16);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(531, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // bthThem
            // 
            this.bthThem.Image = ((System.Drawing.Image)(resources.GetObject("bthThem.Image")));
            this.bthThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bthThem.Name = "bthThem";
            this.bthThem.Size = new System.Drawing.Size(57, 22);
            this.bthThem.Text = "Thêm";
            this.bthThem.ToolTipText = "Thêm";
            this.bthThem.Click += new System.EventHandler(this.bthThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.ToolTipText = "Thêm";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.ToolTipText = "Thêm";
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
            this.dgvDSBanIn.Size = new System.Drawing.Size(525, 260);
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
            this.colTrangThai.HeaderText = "Đang mượn";
            this.colTrangThai.Name = "colTrangThai";
            // 
            // grbLocDauSach
            // 
            this.grbLocDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLocDauSach.Location = new System.Drawing.Point(6, 19);
            this.grbLocDauSach.Name = "grbLocDauSach";
            this.grbLocDauSach.Size = new System.Drawing.Size(402, 100);
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
            this.cmbNhaXuatBan.Size = new System.Drawing.Size(313, 21);
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
            this.cmbTheLoai.Size = new System.Drawing.Size(313, 21);
            this.cmbTheLoai.TabIndex = 2;
            this.cmbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cmbTheLoai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thể loại";
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
            this.dgvDSDauSach.Size = new System.Drawing.Size(402, 352);
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
            // grbDSDauSach
            // 
            this.grbDSDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDSDauSach.Controls.Add(this.dgvDSDauSach);
            this.grbDSDauSach.Controls.Add(this.grbLocDauSach);
            this.grbDSDauSach.Location = new System.Drawing.Point(12, 12);
            this.grbDSDauSach.Name = "grbDSDauSach";
            this.grbDSDauSach.Size = new System.Drawing.Size(414, 483);
            this.grbDSDauSach.TabIndex = 0;
            this.grbDSDauSach.TabStop = false;
            this.grbDSDauSach.Text = "Danh sách đầu sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNhaXuatBan);
            this.groupBox1.Controls.Add(this.cmbTheLoai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 523);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đầu sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach});
            this.dataGridView1.Location = new System.Drawing.Point(6, 125);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(430, 392);
            this.dataGridView1.TabIndex = 1;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(341, 21);
            this.comboBox2.TabIndex = 2;
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
            // ucThongTinDauSach1
            // 
            this.ucThongTinDauSach1.AnhBia = null;
            this.ucThongTinDauSach1.Location = new System.Drawing.Point(460, 16);
            this.ucThongTinDauSach1.Name = "ucThongTinDauSach1";
            this.ucThongTinDauSach1.NamXuatBan = null;
            this.ucThongTinDauSach1.NhaXuatBan = null;
            this.ucThongTinDauSach1.Size = new System.Drawing.Size(537, 167);
            this.ucThongTinDauSach1.TabIndex = 2;
            this.ucThongTinDauSach1.TacGia = null;
            this.ucThongTinDauSach1.TenSach = null;
            this.ucThongTinDauSach1.TheLoai = null;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.toolStrip1);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(460, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 346);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bản in đầu sách";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(525, 296);
            this.dataGridView2.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(531, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Sửa";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton2.Text = "Xóa";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton3.Text = "Thêm";
            // 
            // FrmBanIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 547);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ucThongTinDauSach1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmBanIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bản in";
            this.Load += new System.EventHandler(this.FrmBanIn_Load);
            this.grbDSBanIn.ResumeLayout(false);
            this.grbDSBanIn.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBanIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDauSach)).EndInit();
            this.grbDSDauSach.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSBanIn;
        private CustomControls.UcThongTinDauSach ucThongTinDauSach;
        private System.Windows.Forms.DataGridView dgvDSBanIn;
        private System.Windows.Forms.GroupBox grbLocDauSach;
        private System.Windows.Forms.ComboBox cmbNhaXuatBan;
        private System.Windows.Forms.ComboBox cmbTheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSDauSach;
        private System.Windows.Forms.GroupBox grbDSDauSach;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton bthThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach_ds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBanIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach_bi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomControls.UcThongTinDauSach ucThongTinDauSach1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}