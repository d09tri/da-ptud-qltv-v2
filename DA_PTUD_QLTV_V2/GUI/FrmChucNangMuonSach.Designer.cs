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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbDSSachMuon.SuspendLayout();
            this.grbTTPhieuMuon.SuspendLayout();
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
            this.grbDSSachMuon.Location = new System.Drawing.Point(279, 12);
            this.grbDSSachMuon.Name = "grbDSSachMuon";
            this.grbDSSachMuon.Size = new System.Drawing.Size(698, 526);
            this.grbDSSachMuon.TabIndex = 0;
            this.grbDSSachMuon.TabStop = false;
            this.grbDSSachMuon.Text = "Danh sách đầu sách mượn";
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
            this.fpnlDSDauSachMuon.Size = new System.Drawing.Size(692, 475);
            this.fpnlDSDauSachMuon.TabIndex = 0;
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
            // grbTTPhieuMuon
            // 
            this.grbTTPhieuMuon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 7;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 4;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 1;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lưu ý: Nhấn chọn \"Load đầu sách\" sau khi đã quét xong đầu sách cho mượn";
            // 
            // FrmChucNangMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.grbTTPhieuMuon);
            this.Controls.Add(this.grbDSSachMuon);
            this.Name = "FrmChucNangMuonSach";
            this.Text = "Mượn sách";
            this.grbDSSachMuon.ResumeLayout(false);
            this.grbDSSachMuon.PerformLayout();
            this.grbTTPhieuMuon.ResumeLayout(false);
            this.grbTTPhieuMuon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSSachMuon;
        private System.Windows.Forms.FlowLayoutPanel fpnlDSDauSachMuon;
        private System.Windows.Forms.Button btnLoadDauSach;
        private System.Windows.Forms.Button btnQuetDauSach;
        private System.Windows.Forms.GroupBox grbTTPhieuMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}