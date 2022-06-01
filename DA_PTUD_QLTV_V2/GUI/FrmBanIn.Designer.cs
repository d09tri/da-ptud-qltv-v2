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
            this.grbDSDauSach = new System.Windows.Forms.GroupBox();
            this.grbDSBanIn = new System.Windows.Forms.GroupBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.ucThongTinDauSach = new CustomControls.UcThongTinDauSach();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTheLoai = new System.Windows.Forms.ComboBox();
            this.cmbNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.dgvDSDauSach = new System.Windows.Forms.DataGridView();
            this.dgvDSBanIn = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDSDauSach.SuspendLayout();
            this.grbDSBanIn.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDauSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBanIn)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDSDauSach
            // 
            this.grbDSDauSach.Controls.Add(this.dgvDSDauSach);
            this.grbDSDauSach.Controls.Add(this.groupBox1);
            this.grbDSDauSach.Location = new System.Drawing.Point(12, 12);
            this.grbDSDauSach.Name = "grbDSDauSach";
            this.grbDSDauSach.Size = new System.Drawing.Size(414, 478);
            this.grbDSDauSach.TabIndex = 0;
            this.grbDSDauSach.TabStop = false;
            this.grbDSDauSach.Text = "Danh sách đầu sách";
            // 
            // grbDSBanIn
            // 
            this.grbDSBanIn.Controls.Add(this.dgvDSBanIn);
            this.grbDSBanIn.Location = new System.Drawing.Point(432, 185);
            this.grbDSBanIn.Name = "grbDSBanIn";
            this.grbDSBanIn.Size = new System.Drawing.Size(537, 245);
            this.grbDSBanIn.TabIndex = 2;
            this.grbDSBanIn.TabStop = false;
            this.grbDSBanIn.Text = "Bản in đầu sách";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnHuy);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Location = new System.Drawing.Point(432, 436);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(537, 54);
            this.grbChucNang.TabIndex = 3;
            this.grbChucNang.TabStop = false;
            // 
            // ucThongTinDauSach
            // 
            this.ucThongTinDauSach.AnhBia = null;
            this.ucThongTinDauSach.Location = new System.Drawing.Point(432, 12);
            this.ucThongTinDauSach.Name = "ucThongTinDauSach";
            this.ucThongTinDauSach.NamXuatBan = null;
            this.ucThongTinDauSach.NhaXuatBan = null;
            this.ucThongTinDauSach.Size = new System.Drawing.Size(537, 167);
            this.ucThongTinDauSach.TabIndex = 4;
            this.ucThongTinDauSach.TacGia = null;
            this.ucThongTinDauSach.TenSach = null;
            this.ucThongTinDauSach.TheLoai = null;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(87, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(168, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(249, 25);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(330, 25);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(411, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thể loại";
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
            // cmbTheLoai
            // 
            this.cmbTheLoai.FormattingEnabled = true;
            this.cmbTheLoai.Location = new System.Drawing.Point(83, 31);
            this.cmbTheLoai.Name = "cmbTheLoai";
            this.cmbTheLoai.Size = new System.Drawing.Size(313, 21);
            this.cmbTheLoai.TabIndex = 2;
            this.cmbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cmbTheLoai_SelectedIndexChanged);
            // 
            // cmbNhaXuatBan
            // 
            this.cmbNhaXuatBan.FormattingEnabled = true;
            this.cmbNhaXuatBan.Location = new System.Drawing.Point(83, 58);
            this.cmbNhaXuatBan.Name = "cmbNhaXuatBan";
            this.cmbNhaXuatBan.Size = new System.Drawing.Size(313, 21);
            this.cmbNhaXuatBan.TabIndex = 3;
            this.cmbNhaXuatBan.SelectedIndexChanged += new System.EventHandler(this.cmbNhaXuatBan_SelectedIndexChanged);
            // 
            // dgvDSDauSach
            // 
            this.dgvDSDauSach.AllowUserToAddRows = false;
            this.dgvDSDauSach.AllowUserToDeleteRows = false;
            this.dgvDSDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach});
            this.dgvDSDauSach.Location = new System.Drawing.Point(6, 125);
            this.dgvDSDauSach.MultiSelect = false;
            this.dgvDSDauSach.Name = "dgvDSDauSach";
            this.dgvDSDauSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDauSach.Size = new System.Drawing.Size(402, 347);
            this.dgvDSDauSach.TabIndex = 1;
            this.dgvDSDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDauSach_CellClick);
            // 
            // dgvDSBanIn
            // 
            this.dgvDSBanIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBanIn.Location = new System.Drawing.Point(6, 19);
            this.dgvDSBanIn.Name = "dgvDSBanIn";
            this.dgvDSBanIn.Size = new System.Drawing.Size(525, 220);
            this.dgvDSBanIn.TabIndex = 2;
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
            // FrmBanIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 502);
            this.Controls.Add(this.ucThongTinDauSach);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbDSBanIn);
            this.Controls.Add(this.grbDSDauSach);
            this.Name = "FrmBanIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bản in";
            this.Load += new System.EventHandler(this.FrmBanIn_Load);
            this.grbDSDauSach.ResumeLayout(false);
            this.grbDSBanIn.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDauSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBanIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSDauSach;
        private System.Windows.Forms.GroupBox grbDSBanIn;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private CustomControls.UcThongTinDauSach ucThongTinDauSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNhaXuatBan;
        private System.Windows.Forms.ComboBox cmbTheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSDauSach;
        private System.Windows.Forms.DataGridView dgvDSBanIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
    }
}