namespace GUI
{
    partial class FrmQuanLyDauSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyDauSach));
            this.pnlHinhAnh = new System.Windows.Forms.Panel();
            this.picAnhBia = new System.Windows.Forms.PictureBox();
            this.grbDSDauSach = new System.Windows.Forms.GroupBox();
            this.grbLocDauSach = new System.Windows.Forms.GroupBox();
            this.cmbLocNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.cmbLocTheLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDSDauSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTTDauSach = new System.Windows.Forms.GroupBox();
            this.dtpNamXuatBan = new System.Windows.Forms.DateTimePicker();
            this.lblNamXB = new System.Windows.Forms.Label();
            this.lblNhaXB = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.cmbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.cmbTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtAnhBia = new System.Windows.Forms.TextBox();
            this.lblAnhBia = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblMaSach_z = new System.Windows.Forms.Label();
            this.toolStripChucNang = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.grbTimKiemDauSach = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtTimKiemDauSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlHinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).BeginInit();
            this.grbDSDauSach.SuspendLayout();
            this.grbLocDauSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDauSach)).BeginInit();
            this.grbTTDauSach.SuspendLayout();
            this.toolStripChucNang.SuspendLayout();
            this.grbTimKiemDauSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHinhAnh
            // 
            this.pnlHinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.pnlHinhAnh.Controls.Add(this.picAnhBia);
            this.pnlHinhAnh.Location = new System.Drawing.Point(6, 44);
            this.pnlHinhAnh.Name = "pnlHinhAnh";
            this.pnlHinhAnh.Size = new System.Drawing.Size(142, 179);
            this.pnlHinhAnh.TabIndex = 0;
            // 
            // picAnhBia
            // 
            this.picAnhBia.BackColor = System.Drawing.Color.White;
            this.picAnhBia.Location = new System.Drawing.Point(7, 7);
            this.picAnhBia.Name = "picAnhBia";
            this.picAnhBia.Size = new System.Drawing.Size(128, 165);
            this.picAnhBia.TabIndex = 1;
            this.picAnhBia.TabStop = false;
            // 
            // grbDSDauSach
            // 
            this.grbDSDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDSDauSach.Controls.Add(this.grbLocDauSach);
            this.grbDSDauSach.Controls.Add(this.dgvDSDauSach);
            this.grbDSDauSach.Location = new System.Drawing.Point(12, 12);
            this.grbDSDauSach.Name = "grbDSDauSach";
            this.grbDSDauSach.Size = new System.Drawing.Size(519, 526);
            this.grbDSDauSach.TabIndex = 1;
            this.grbDSDauSach.TabStop = false;
            this.grbDSDauSach.Text = "Danh sách đầu sách";
            // 
            // grbLocDauSach
            // 
            this.grbLocDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLocDauSach.Controls.Add(this.cmbLocNhaXuatBan);
            this.grbLocDauSach.Controls.Add(this.cmbLocTheLoai);
            this.grbLocDauSach.Controls.Add(this.label3);
            this.grbLocDauSach.Controls.Add(this.label4);
            this.grbLocDauSach.Location = new System.Drawing.Point(6, 19);
            this.grbLocDauSach.Name = "grbLocDauSach";
            this.grbLocDauSach.Size = new System.Drawing.Size(507, 100);
            this.grbLocDauSach.TabIndex = 3;
            this.grbLocDauSach.TabStop = false;
            // 
            // cmbLocNhaXuatBan
            // 
            this.cmbLocNhaXuatBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLocNhaXuatBan.FormattingEnabled = true;
            this.cmbLocNhaXuatBan.Location = new System.Drawing.Point(83, 58);
            this.cmbLocNhaXuatBan.Name = "cmbLocNhaXuatBan";
            this.cmbLocNhaXuatBan.Size = new System.Drawing.Size(418, 21);
            this.cmbLocNhaXuatBan.TabIndex = 3;
            this.cmbLocNhaXuatBan.SelectedIndexChanged += new System.EventHandler(this.cmbLocNhaXuatBan_SelectedIndexChanged);
            // 
            // cmbLocTheLoai
            // 
            this.cmbLocTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLocTheLoai.FormattingEnabled = true;
            this.cmbLocTheLoai.Location = new System.Drawing.Point(83, 31);
            this.cmbLocTheLoai.Name = "cmbLocTheLoai";
            this.cmbLocTheLoai.Size = new System.Drawing.Size(418, 21);
            this.cmbLocTheLoai.TabIndex = 2;
            this.cmbLocTheLoai.SelectedIndexChanged += new System.EventHandler(this.cmbLocTheLoai_SelectedIndexChanged);
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
            // dgvDSDauSach
            // 
            this.dgvDSDauSach.AllowUserToAddRows = false;
            this.dgvDSDauSach.AllowUserToDeleteRows = false;
            this.dgvDSDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colTacGia,
            this.colTheLoai,
            this.colNhaXB,
            this.colNamXB});
            this.dgvDSDauSach.Location = new System.Drawing.Point(6, 125);
            this.dgvDSDauSach.MultiSelect = false;
            this.dgvDSDauSach.Name = "dgvDSDauSach";
            this.dgvDSDauSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDauSach.Size = new System.Drawing.Size(507, 395);
            this.dgvDSDauSach.TabIndex = 2;
            this.dgvDSDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDauSach_CellClick);
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            // 
            // colTacGia
            // 
            this.colTacGia.DataPropertyName = "TacGia";
            this.colTacGia.HeaderText = "Tác giả";
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.ReadOnly = true;
            // 
            // colTheLoai
            // 
            this.colTheLoai.DataPropertyName = "TenTheLoai";
            this.colTheLoai.HeaderText = "Thể loại";
            this.colTheLoai.Name = "colTheLoai";
            this.colTheLoai.ReadOnly = true;
            // 
            // colNhaXB
            // 
            this.colNhaXB.DataPropertyName = "TenNXB";
            this.colNhaXB.HeaderText = "Nhà xuất bản";
            this.colNhaXB.Name = "colNhaXB";
            this.colNhaXB.ReadOnly = true;
            // 
            // colNamXB
            // 
            this.colNamXB.DataPropertyName = "NamXB";
            this.colNamXB.HeaderText = "Năm xuất bản";
            this.colNamXB.Name = "colNamXB";
            this.colNamXB.ReadOnly = true;
            // 
            // grbTTDauSach
            // 
            this.grbTTDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTTDauSach.Controls.Add(this.dtpNamXuatBan);
            this.grbTTDauSach.Controls.Add(this.lblNamXB);
            this.grbTTDauSach.Controls.Add(this.lblNhaXB);
            this.grbTTDauSach.Controls.Add(this.lblTheLoai);
            this.grbTTDauSach.Controls.Add(this.cmbNhaXuatBan);
            this.grbTTDauSach.Controls.Add(this.cmbTheLoai);
            this.grbTTDauSach.Controls.Add(this.txtTacGia);
            this.grbTTDauSach.Controls.Add(this.lblTacGia);
            this.grbTTDauSach.Controls.Add(this.btnChonAnh);
            this.grbTTDauSach.Controls.Add(this.txtAnhBia);
            this.grbTTDauSach.Controls.Add(this.lblAnhBia);
            this.grbTTDauSach.Controls.Add(this.txtTenSach);
            this.grbTTDauSach.Controls.Add(this.lblTenSach);
            this.grbTTDauSach.Controls.Add(this.lblMaSach);
            this.grbTTDauSach.Controls.Add(this.lblMaSach_z);
            this.grbTTDauSach.Controls.Add(this.toolStripChucNang);
            this.grbTTDauSach.Controls.Add(this.pnlHinhAnh);
            this.grbTTDauSach.Location = new System.Drawing.Point(537, 137);
            this.grbTTDauSach.Name = "grbTTDauSach";
            this.grbTTDauSach.Size = new System.Drawing.Size(440, 231);
            this.grbTTDauSach.TabIndex = 2;
            this.grbTTDauSach.TabStop = false;
            this.grbTTDauSach.Text = "Thông tin đầu sách";
            // 
            // dtpNamXuatBan
            // 
            this.dtpNamXuatBan.CustomFormat = "dd/MM/yyyy";
            this.dtpNamXuatBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamXuatBan.Location = new System.Drawing.Point(224, 203);
            this.dtpNamXuatBan.Name = "dtpNamXuatBan";
            this.dtpNamXuatBan.Size = new System.Drawing.Size(210, 20);
            this.dtpNamXuatBan.TabIndex = 41;
            // 
            // lblNamXB
            // 
            this.lblNamXB.AutoSize = true;
            this.lblNamXB.Location = new System.Drawing.Point(164, 206);
            this.lblNamXB.Name = "lblNamXB";
            this.lblNamXB.Size = new System.Drawing.Size(49, 13);
            this.lblNamXB.TabIndex = 40;
            this.lblNamXB.Text = "Năm XB:";
            // 
            // lblNhaXB
            // 
            this.lblNhaXB.AutoSize = true;
            this.lblNhaXB.Location = new System.Drawing.Point(164, 179);
            this.lblNhaXB.Name = "lblNhaXB";
            this.lblNhaXB.Size = new System.Drawing.Size(47, 13);
            this.lblNhaXB.TabIndex = 39;
            this.lblNhaXB.Text = "Nhà XB:";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(164, 152);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(48, 13);
            this.lblTheLoai.TabIndex = 38;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // cmbNhaXuatBan
            // 
            this.cmbNhaXuatBan.FormattingEnabled = true;
            this.cmbNhaXuatBan.Location = new System.Drawing.Point(224, 176);
            this.cmbNhaXuatBan.Name = "cmbNhaXuatBan";
            this.cmbNhaXuatBan.Size = new System.Drawing.Size(210, 21);
            this.cmbNhaXuatBan.TabIndex = 36;
            // 
            // cmbTheLoai
            // 
            this.cmbTheLoai.FormattingEnabled = true;
            this.cmbTheLoai.Location = new System.Drawing.Point(224, 149);
            this.cmbTheLoai.Name = "cmbTheLoai";
            this.cmbTheLoai.Size = new System.Drawing.Size(210, 21);
            this.cmbTheLoai.TabIndex = 35;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(224, 123);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(210, 20);
            this.txtTacGia.TabIndex = 34;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(164, 126);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(46, 13);
            this.lblTacGia.TabIndex = 33;
            this.lblTacGia.Text = "Tác giả:";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(398, 96);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(36, 23);
            this.btnChonAnh.TabIndex = 32;
            this.btnChonAnh.Text = "...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtAnhBia
            // 
            this.txtAnhBia.Location = new System.Drawing.Point(224, 97);
            this.txtAnhBia.Name = "txtAnhBia";
            this.txtAnhBia.ReadOnly = true;
            this.txtAnhBia.Size = new System.Drawing.Size(168, 20);
            this.txtAnhBia.TabIndex = 31;
            // 
            // lblAnhBia
            // 
            this.lblAnhBia.AutoSize = true;
            this.lblAnhBia.Location = new System.Drawing.Point(164, 100);
            this.lblAnhBia.Name = "lblAnhBia";
            this.lblAnhBia.Size = new System.Drawing.Size(46, 13);
            this.lblAnhBia.TabIndex = 30;
            this.lblAnhBia.Text = "Ảnh bìa:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(224, 71);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(210, 20);
            this.txtTenSach.TabIndex = 29;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(163, 74);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(55, 13);
            this.lblTenSach.TabIndex = 27;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaSach.Location = new System.Drawing.Point(221, 48);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(57, 13);
            this.lblMaSach.TabIndex = 26;
            this.lblMaSach.Text = "lblMaSach";
            // 
            // lblMaSach_z
            // 
            this.lblMaSach_z.AutoSize = true;
            this.lblMaSach_z.Location = new System.Drawing.Point(164, 48);
            this.lblMaSach_z.Name = "lblMaSach_z";
            this.lblMaSach_z.Size = new System.Drawing.Size(51, 13);
            this.lblMaSach_z.TabIndex = 2;
            this.lblMaSach_z.Text = "Mã sách:";
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
            this.toolStripChucNang.Location = new System.Drawing.Point(3, 16);
            this.toolStripChucNang.Name = "toolStripChucNang";
            this.toolStripChucNang.Size = new System.Drawing.Size(434, 25);
            this.toolStripChucNang.TabIndex = 1;
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
            // grbTimKiemDauSach
            // 
            this.grbTimKiemDauSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTimKiemDauSach.Controls.Add(this.btnRefresh);
            this.grbTimKiemDauSach.Controls.Add(this.txtTimKiemDauSach);
            this.grbTimKiemDauSach.Controls.Add(this.label2);
            this.grbTimKiemDauSach.Location = new System.Drawing.Point(537, 12);
            this.grbTimKiemDauSach.Name = "grbTimKiemDauSach";
            this.grbTimKiemDauSach.Size = new System.Drawing.Size(440, 119);
            this.grbTimKiemDauSach.TabIndex = 4;
            this.grbTimKiemDauSach.TabStop = false;
            this.grbTimKiemDauSach.Text = "Tìm kiếm đầu sách";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(64, 57);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtTimKiemDauSach
            // 
            this.txtTimKiemDauSach.Location = new System.Drawing.Point(64, 31);
            this.txtTimKiemDauSach.Name = "txtTimKiemDauSach";
            this.txtTimKiemDauSach.Size = new System.Drawing.Size(370, 20);
            this.txtTimKiemDauSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sách";
            // 
            // FrmQuanLyDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.grbTimKiemDauSach);
            this.Controls.Add(this.grbTTDauSach);
            this.Controls.Add(this.grbDSDauSach);
            this.Name = "FrmQuanLyDauSach";
            this.Text = "Quản lý đầu sách";
            this.Load += new System.EventHandler(this.FrmQuanLyDauSach_Load);
            this.pnlHinhAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).EndInit();
            this.grbDSDauSach.ResumeLayout(false);
            this.grbLocDauSach.ResumeLayout(false);
            this.grbLocDauSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDauSach)).EndInit();
            this.grbTTDauSach.ResumeLayout(false);
            this.grbTTDauSach.PerformLayout();
            this.toolStripChucNang.ResumeLayout(false);
            this.toolStripChucNang.PerformLayout();
            this.grbTimKiemDauSach.ResumeLayout(false);
            this.grbTimKiemDauSach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHinhAnh;
        private System.Windows.Forms.PictureBox picAnhBia;
        private System.Windows.Forms.GroupBox grbDSDauSach;
        private System.Windows.Forms.GroupBox grbTTDauSach;
        private System.Windows.Forms.ToolStrip toolStripChucNang;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.Label lblMaSach_z;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblAnhBia;
        private System.Windows.Forms.TextBox txtAnhBia;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.ComboBox cmbTheLoai;
        private System.Windows.Forms.ComboBox cmbNhaXuatBan;
        private System.Windows.Forms.Label lblNamXB;
        private System.Windows.Forms.Label lblNhaXB;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.DataGridView dgvDSDauSach;
        private System.Windows.Forms.GroupBox grbLocDauSach;
        private System.Windows.Forms.ComboBox cmbLocNhaXuatBan;
        private System.Windows.Forms.ComboBox cmbLocTheLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbTimKiemDauSach;
        private System.Windows.Forms.TextBox txtTimKiemDauSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DateTimePicker dtpNamXuatBan;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}