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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPhieuMuon = new System.Windows.Forms.ComboBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocGia = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTinhTrang = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu mượn chưa trả";
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
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(95, 51);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(147, 20);
            this.txtNhanVien.TabIndex = 2;
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
            // txtDocGia
            // 
            this.txtDocGia.Location = new System.Drawing.Point(95, 77);
            this.txtDocGia.Name = "txtDocGia";
            this.txtDocGia.Size = new System.Drawing.Size(147, 20);
            this.txtDocGia.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Độc giả:";
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
            this.chkTinhTrang.Location = new System.Drawing.Point(187, 131);
            this.chkTinhTrang.Name = "chkTinhTrang";
            this.chkTinhTrang.Size = new System.Drawing.Size(55, 17);
            this.chkTinhTrang.TabIndex = 12;
            this.chkTinhTrang.Text = "Đã trả";
            this.chkTinhTrang.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(260, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 178);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu mượn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbPhieuMuon);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.chkTinhTrang);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNhanVien);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDocGia);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMaThe);
            this.groupBox3.Controls.Add(this.dtpNgayMuon);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 178);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // FrmChucNangTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmChucNangTraSach";
            this.Load += new System.EventHandler(this.FrmChucNangTraSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}