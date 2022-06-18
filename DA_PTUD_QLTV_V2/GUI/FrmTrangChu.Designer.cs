namespace GUI
{
    partial class FrmTrangChu
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlHeThongSubMenu = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.pnlChucNangSubMenu = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnMuonSach = new System.Windows.Forms.Button();
            this.btnChucNang = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlQuanLySubMenu = new System.Windows.Forms.Panel();
            this.btnTheThuVien = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnBanIn = new System.Windows.Forms.Button();
            this.btnDauSach = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.pnlSideMenu.SuspendLayout();
            this.pnlHeThongSubMenu.SuspendLayout();
            this.pnlChucNangSubMenu.SuspendLayout();
            this.pnlQuanLySubMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.pnlSideMenu.Controls.Add(this.pnlHeThongSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnHeThong);
            this.pnlSideMenu.Controls.Add(this.pnlChucNangSubMenu);
            this.pnlSideMenu.Controls.Add(this.btnChucNang);
            this.pnlSideMenu.Controls.Add(this.btnDangXuat);
            this.pnlSideMenu.Controls.Add(this.pnlQuanLySubMenu);
            this.pnlSideMenu.Controls.Add(this.btnQuanLy);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(214, 681);
            this.pnlSideMenu.TabIndex = 4;
            // 
            // pnlHeThongSubMenu
            // 
            this.pnlHeThongSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.pnlHeThongSubMenu.Controls.Add(this.btnTaiKhoan);
            this.pnlHeThongSubMenu.Controls.Add(this.btnRestore);
            this.pnlHeThongSubMenu.Controls.Add(this.btnBackup);
            this.pnlHeThongSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeThongSubMenu.Location = new System.Drawing.Point(0, 555);
            this.pnlHeThongSubMenu.Name = "pnlHeThongSubMenu";
            this.pnlHeThongSubMenu.Size = new System.Drawing.Size(197, 120);
            this.pnlHeThongSubMenu.TabIndex = 11;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 80);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(30, 0, 23, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(197, 40);
            this.btnTaiKhoan.TabIndex = 2;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestore.Location = new System.Drawing.Point(0, 40);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Padding = new System.Windows.Forms.Padding(30, 0, 23, 0);
            this.btnRestore.Size = new System.Drawing.Size(197, 40);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.Location = new System.Drawing.Point(0, 0);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(30, 0, 23, 0);
            this.btnBackup.Size = new System.Drawing.Size(197, 40);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHeThong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHeThong.Location = new System.Drawing.Point(0, 510);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Padding = new System.Windows.Forms.Padding(9, 0, 21, 0);
            this.btnHeThong.Size = new System.Drawing.Size(197, 45);
            this.btnHeThong.TabIndex = 10;
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHeThong.UseVisualStyleBackColor = true;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // pnlChucNangSubMenu
            // 
            this.pnlChucNangSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.pnlChucNangSubMenu.Controls.Add(this.btnThongKe);
            this.pnlChucNangSubMenu.Controls.Add(this.btnTraSach);
            this.pnlChucNangSubMenu.Controls.Add(this.btnMuonSach);
            this.pnlChucNangSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChucNangSubMenu.Location = new System.Drawing.Point(0, 390);
            this.pnlChucNangSubMenu.Name = "pnlChucNangSubMenu";
            this.pnlChucNangSubMenu.Size = new System.Drawing.Size(197, 120);
            this.pnlChucNangSubMenu.TabIndex = 9;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.Location = new System.Drawing.Point(0, 80);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.btnThongKe.Size = new System.Drawing.Size(197, 40);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraSach.FlatAppearance.BorderSize = 0;
            this.btnTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSach.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraSach.Location = new System.Drawing.Point(0, 40);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.btnTraSach.Size = new System.Drawing.Size(197, 40);
            this.btnTraSach.TabIndex = 1;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraSach.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMuonSach.FlatAppearance.BorderSize = 0;
            this.btnMuonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonSach.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMuonSach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMuonSach.Location = new System.Drawing.Point(0, 0);
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Padding = new System.Windows.Forms.Padding(30, 0, 23, 0);
            this.btnMuonSach.Size = new System.Drawing.Size(197, 40);
            this.btnMuonSach.TabIndex = 0;
            this.btnMuonSach.Text = "Mượn sách";
            this.btnMuonSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuonSach.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMuonSach.UseVisualStyleBackColor = true;
            this.btnMuonSach.Click += new System.EventHandler(this.btnMuonSach_Click);
            // 
            // btnChucNang
            // 
            this.btnChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChucNang.FlatAppearance.BorderSize = 0;
            this.btnChucNang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChucNang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChucNang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChucNang.Location = new System.Drawing.Point(0, 345);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.Padding = new System.Windows.Forms.Padding(9, 0, 21, 0);
            this.btnChucNang.Size = new System.Drawing.Size(197, 45);
            this.btnChucNang.TabIndex = 8;
            this.btnChucNang.Text = "Chức năng";
            this.btnChucNang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChucNang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChucNang.UseVisualStyleBackColor = true;
            this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 675);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(197, 45);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pnlQuanLySubMenu
            // 
            this.pnlQuanLySubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(76)))), ((int)(((byte)(80)))));
            this.pnlQuanLySubMenu.Controls.Add(this.btnNhanVien);
            this.pnlQuanLySubMenu.Controls.Add(this.btnTheThuVien);
            this.pnlQuanLySubMenu.Controls.Add(this.btnDocGia);
            this.pnlQuanLySubMenu.Controls.Add(this.btnBanIn);
            this.pnlQuanLySubMenu.Controls.Add(this.btnDauSach);
            this.pnlQuanLySubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuanLySubMenu.Location = new System.Drawing.Point(0, 145);
            this.pnlQuanLySubMenu.Name = "pnlQuanLySubMenu";
            this.pnlQuanLySubMenu.Size = new System.Drawing.Size(197, 200);
            this.pnlQuanLySubMenu.TabIndex = 5;
            // 
            // btnTheThuVien
            // 
            this.btnTheThuVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheThuVien.FlatAppearance.BorderSize = 0;
            this.btnTheThuVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheThuVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTheThuVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTheThuVien.Location = new System.Drawing.Point(0, 120);
            this.btnTheThuVien.Name = "btnTheThuVien";
            this.btnTheThuVien.Padding = new System.Windows.Forms.Padding(30, 0, 23, 0);
            this.btnTheThuVien.Size = new System.Drawing.Size(197, 40);
            this.btnTheThuVien.TabIndex = 5;
            this.btnTheThuVien.Text = "Thẻ thư viện";
            this.btnTheThuVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheThuVien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTheThuVien.UseVisualStyleBackColor = true;
            this.btnTheThuVien.Click += new System.EventHandler(this.btnTheThuVien_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocGia.FlatAppearance.BorderSize = 0;
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocGia.Location = new System.Drawing.Point(0, 80);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Padding = new System.Windows.Forms.Padding(30, 0, 23, 0);
            this.btnDocGia.Size = new System.Drawing.Size(197, 40);
            this.btnDocGia.TabIndex = 4;
            this.btnDocGia.Text = "Độc giả";
            this.btnDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocGia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDocGia.UseVisualStyleBackColor = true;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnBanIn
            // 
            this.btnBanIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanIn.FlatAppearance.BorderSize = 0;
            this.btnBanIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBanIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanIn.Location = new System.Drawing.Point(0, 40);
            this.btnBanIn.Name = "btnBanIn";
            this.btnBanIn.Padding = new System.Windows.Forms.Padding(30, 0, 23, 0);
            this.btnBanIn.Size = new System.Drawing.Size(197, 40);
            this.btnBanIn.TabIndex = 3;
            this.btnBanIn.Text = "Bản in";
            this.btnBanIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanIn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBanIn.UseVisualStyleBackColor = true;
            this.btnBanIn.Click += new System.EventHandler(this.btnBanIn_Click);
            // 
            // btnDauSach
            // 
            this.btnDauSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDauSach.FlatAppearance.BorderSize = 0;
            this.btnDauSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDauSach.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDauSach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDauSach.Location = new System.Drawing.Point(0, 0);
            this.btnDauSach.Name = "btnDauSach";
            this.btnDauSach.Padding = new System.Windows.Forms.Padding(30, 0, 23, 0);
            this.btnDauSach.Size = new System.Drawing.Size(197, 40);
            this.btnDauSach.TabIndex = 2;
            this.btnDauSach.Text = "Đầu sách";
            this.btnDauSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDauSach.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDauSach.UseVisualStyleBackColor = true;
            this.btnDauSach.Click += new System.EventHandler(this.btnDauSach_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLy.Location = new System.Drawing.Point(0, 100);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Padding = new System.Windows.Forms.Padding(9, 0, 21, 0);
            this.btnQuanLy.Size = new System.Drawing.Size(197, 45);
            this.btnQuanLy.TabIndex = 4;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Controls.Add(this.lblTaiKhoan);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(197, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(0, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(214, 51);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lblTaiKhoan.Location = new System.Drawing.Point(10, 70);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(199, 20);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Tài khoản";
            this.lblTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(214, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(972, 681);
            this.pnlMain.TabIndex = 5;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 160);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(30, 0, 23, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(197, 40);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // FrmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 681);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "FrmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlHeThongSubMenu.ResumeLayout(false);
            this.pnlChucNangSubMenu.ResumeLayout(false);
            this.pnlQuanLySubMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlHeThongSubMenu;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Panel pnlChucNangSubMenu;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnMuonSach;
        private System.Windows.Forms.Button btnChucNang;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlQuanLySubMenu;
        private System.Windows.Forms.Button btnDauSach;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTaiKhoan;
        public System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnBanIn;
        private System.Windows.Forms.Button btnTheThuVien;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnNhanVien;
    }
}