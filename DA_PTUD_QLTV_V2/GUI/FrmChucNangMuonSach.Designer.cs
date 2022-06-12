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
            this.fpnlDSDauSachMuon = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuetDauSach = new System.Windows.Forms.Button();
            this.btnLoadDauSach = new System.Windows.Forms.Button();
            this.grbTTPhieuMuon = new System.Windows.Forms.GroupBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.grbDSSachMuon.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDSSachMuon
            // 
            this.grbDSSachMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDSSachMuon.Controls.Add(this.fpnlDSDauSachMuon);
            this.grbDSSachMuon.Location = new System.Drawing.Point(279, 72);
            this.grbDSSachMuon.Name = "grbDSSachMuon";
            this.grbDSSachMuon.Size = new System.Drawing.Size(698, 466);
            this.grbDSSachMuon.TabIndex = 0;
            this.grbDSSachMuon.TabStop = false;
            this.grbDSSachMuon.Text = "Danh sách đầu sách mượn";
            // 
            // fpnlDSDauSachMuon
            // 
            this.fpnlDSDauSachMuon.AutoScroll = true;
            this.fpnlDSDauSachMuon.BackColor = System.Drawing.Color.White;
            this.fpnlDSDauSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlDSDauSachMuon.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlDSDauSachMuon.Location = new System.Drawing.Point(3, 16);
            this.fpnlDSDauSachMuon.Name = "fpnlDSDauSachMuon";
            this.fpnlDSDauSachMuon.Size = new System.Drawing.Size(692, 447);
            this.fpnlDSDauSachMuon.TabIndex = 0;
            this.fpnlDSDauSachMuon.WrapContents = false;
            // 
            // btnQuetDauSach
            // 
            this.btnQuetDauSach.ForeColor = System.Drawing.Color.Black;
            this.btnQuetDauSach.Location = new System.Drawing.Point(6, 22);
            this.btnQuetDauSach.Name = "btnQuetDauSach";
            this.btnQuetDauSach.Size = new System.Drawing.Size(94, 23);
            this.btnQuetDauSach.TabIndex = 0;
            this.btnQuetDauSach.Text = "Quét đầu sách";
            this.btnQuetDauSach.UseVisualStyleBackColor = true;
            this.btnQuetDauSach.Click += new System.EventHandler(this.btnQuetDauSach_Click);
            // 
            // btnLoadDauSach
            // 
            this.btnLoadDauSach.ForeColor = System.Drawing.Color.Black;
            this.btnLoadDauSach.Location = new System.Drawing.Point(105, 22);
            this.btnLoadDauSach.Name = "btnLoadDauSach";
            this.btnLoadDauSach.Size = new System.Drawing.Size(94, 23);
            this.btnLoadDauSach.TabIndex = 1;
            this.btnLoadDauSach.Text = "Load đầu sách";
            this.btnLoadDauSach.UseVisualStyleBackColor = true;
            this.btnLoadDauSach.Click += new System.EventHandler(this.btnLoadDauSach_Click);
            // 
            // grbTTPhieuMuon
            // 
            this.grbTTPhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTTPhieuMuon.Location = new System.Drawing.Point(12, 12);
            this.grbTTPhieuMuon.Name = "grbTTPhieuMuon";
            this.grbTTPhieuMuon.Size = new System.Drawing.Size(261, 171);
            this.grbTTPhieuMuon.TabIndex = 1;
            this.grbTTPhieuMuon.TabStop = false;
            this.grbTTPhieuMuon.Text = "Thông tin phiếu mượn";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChucNang.Controls.Add(this.btnQuetDauSach);
            this.grbChucNang.Controls.Add(this.btnLoadDauSach);
            this.grbChucNang.ForeColor = System.Drawing.Color.Red;
            this.grbChucNang.Location = new System.Drawing.Point(279, 12);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(698, 54);
            this.grbChucNang.TabIndex = 2;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Lưu ý: Sau khi quét các đầu sách - vui lòng nhấn chọn nút load để hiển thị danh s" +
    "ách các đầu sách mượn";
            // 
            // FrmChucNangMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbTTPhieuMuon);
            this.Controls.Add(this.grbDSSachMuon);
            this.Name = "FrmChucNangMuonSach";
            this.Text = "Mượn sách";
            this.grbDSSachMuon.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSSachMuon;
        private System.Windows.Forms.FlowLayoutPanel fpnlDSDauSachMuon;
        private System.Windows.Forms.Button btnLoadDauSach;
        private System.Windows.Forms.Button btnQuetDauSach;
        private System.Windows.Forms.GroupBox grbTTPhieuMuon;
        private System.Windows.Forms.GroupBox grbChucNang;
    }
}