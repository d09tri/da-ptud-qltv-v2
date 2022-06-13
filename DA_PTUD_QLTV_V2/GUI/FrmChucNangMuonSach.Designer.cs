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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grbDSSachMuon.SuspendLayout();
            this.grbTTPhieuMuon.SuspendLayout();
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
            this.grbTTPhieuMuon.Controls.Add(this.dateTimePicker1);
            this.grbTTPhieuMuon.Controls.Add(this.label4);
            this.grbTTPhieuMuon.Controls.Add(this.label3);
            this.grbTTPhieuMuon.Controls.Add(this.textBox2);
            this.grbTTPhieuMuon.Controls.Add(this.label2);
            this.grbTTPhieuMuon.Controls.Add(this.comboBox1);
            this.grbTTPhieuMuon.Controls.Add(this.textBox1);
            this.grbTTPhieuMuon.Controls.Add(this.label1);
            this.grbTTPhieuMuon.Location = new System.Drawing.Point(12, 12);
            this.grbTTPhieuMuon.Name = "grbTTPhieuMuon";
            this.grbTTPhieuMuon.Size = new System.Drawing.Size(261, 526);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(82, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đọc giả:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(82, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 4;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày mượn:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 7;
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
            this.grbTTPhieuMuon.ResumeLayout(false);
            this.grbTTPhieuMuon.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}