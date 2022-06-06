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
            this.grbTTDauSach = new System.Windows.Forms.GroupBox();
            this.toolStripChucNang = new System.Windows.Forms.ToolStrip();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.lblMaSach_z = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblAnhBia = new System.Windows.Forms.Label();
            this.txtAnhBia = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.cmbTheLoai = new System.Windows.Forms.ComboBox();
            this.cmbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.txtNamXuatBan = new System.Windows.Forms.TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblNhaXB = new System.Windows.Forms.Label();
            this.lblNamXB = new System.Windows.Forms.Label();
            this.pnlHinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).BeginInit();
            this.grbTTDauSach.SuspendLayout();
            this.toolStripChucNang.SuspendLayout();
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
            this.grbDSDauSach.Location = new System.Drawing.Point(12, 12);
            this.grbDSDauSach.Name = "grbDSDauSach";
            this.grbDSDauSach.Size = new System.Drawing.Size(519, 526);
            this.grbDSDauSach.TabIndex = 1;
            this.grbDSDauSach.TabStop = false;
            this.grbDSDauSach.Text = "Danh sách đầu sách";
            // 
            // grbTTDauSach
            // 
            this.grbTTDauSach.Controls.Add(this.lblNamXB);
            this.grbTTDauSach.Controls.Add(this.lblNhaXB);
            this.grbTTDauSach.Controls.Add(this.lblTheLoai);
            this.grbTTDauSach.Controls.Add(this.txtNamXuatBan);
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
            this.grbTTDauSach.Location = new System.Drawing.Point(537, 12);
            this.grbTTDauSach.Name = "grbTTDauSach";
            this.grbTTDauSach.Size = new System.Drawing.Size(440, 231);
            this.grbTTDauSach.TabIndex = 2;
            this.grbTTDauSach.TabStop = false;
            this.grbTTDauSach.Text = "Thông tin đầu sách";
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
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 22);
            this.btnThem.Text = "Thêm";
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
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(49, 22);
            this.btnHuy.Text = "Hủy";
            // 
            // lblMaSach_z
            // 
            this.lblMaSach_z.AutoSize = true;
            this.lblMaSach_z.Location = new System.Drawing.Point(164, 44);
            this.lblMaSach_z.Name = "lblMaSach_z";
            this.lblMaSach_z.Size = new System.Drawing.Size(51, 13);
            this.lblMaSach_z.TabIndex = 2;
            this.lblMaSach_z.Text = "Mã sách:";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaSach.Location = new System.Drawing.Point(221, 44);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(57, 13);
            this.lblMaSach.TabIndex = 26;
            this.lblMaSach.Text = "lblMaSach";
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
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(224, 71);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(210, 20);
            this.txtTenSach.TabIndex = 29;
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
            // txtAnhBia
            // 
            this.txtAnhBia.Location = new System.Drawing.Point(224, 97);
            this.txtAnhBia.Name = "txtAnhBia";
            this.txtAnhBia.ReadOnly = true;
            this.txtAnhBia.Size = new System.Drawing.Size(168, 20);
            this.txtAnhBia.TabIndex = 31;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(398, 96);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(36, 23);
            this.btnChonAnh.TabIndex = 32;
            this.btnChonAnh.Text = "...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
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
            // cmbTheLoai
            // 
            this.cmbTheLoai.FormattingEnabled = true;
            this.cmbTheLoai.Location = new System.Drawing.Point(224, 149);
            this.cmbTheLoai.Name = "cmbTheLoai";
            this.cmbTheLoai.Size = new System.Drawing.Size(210, 21);
            this.cmbTheLoai.TabIndex = 35;
            // 
            // cmbNhaXuatBan
            // 
            this.cmbNhaXuatBan.FormattingEnabled = true;
            this.cmbNhaXuatBan.Location = new System.Drawing.Point(224, 176);
            this.cmbNhaXuatBan.Name = "cmbNhaXuatBan";
            this.cmbNhaXuatBan.Size = new System.Drawing.Size(210, 21);
            this.cmbNhaXuatBan.TabIndex = 36;
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(224, 203);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Size = new System.Drawing.Size(210, 20);
            this.txtNamXuatBan.TabIndex = 37;
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
            // lblNhaXB
            // 
            this.lblNhaXB.AutoSize = true;
            this.lblNhaXB.Location = new System.Drawing.Point(164, 179);
            this.lblNhaXB.Name = "lblNhaXB";
            this.lblNhaXB.Size = new System.Drawing.Size(47, 13);
            this.lblNhaXB.TabIndex = 39;
            this.lblNhaXB.Text = "Nhà XB:";
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
            // FrmQuanLyDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.grbTTDauSach);
            this.Controls.Add(this.grbDSDauSach);
            this.Name = "FrmQuanLyDauSach";
            this.Text = "Quản lý đầu sách";
            this.pnlHinhAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhBia)).EndInit();
            this.grbTTDauSach.ResumeLayout(false);
            this.grbTTDauSach.PerformLayout();
            this.toolStripChucNang.ResumeLayout(false);
            this.toolStripChucNang.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNamXuatBan;
        private System.Windows.Forms.Label lblNamXB;
        private System.Windows.Forms.Label lblNhaXB;
        private System.Windows.Forms.Label lblTheLoai;
    }
}