namespace GUI
{
    partial class FrmThongKe
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
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cmbLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.dgvDSThongKe = new System.Windows.Forms.DataGridView();
            this.pnlTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThongKe)).BeginInit();
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
            this.pnlTieuDe.TabIndex = 16;
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
            this.lblTieuDe.Text = "THỐNG KÊ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(139, 61);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 19;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cmbLoaiPhieu
            // 
            this.cmbLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiPhieu.FormattingEnabled = true;
            this.cmbLoaiPhieu.Items.AddRange(new object[] {
            "Phiếu mượn",
            "Phiếu trả"});
            this.cmbLoaiPhieu.Location = new System.Drawing.Point(12, 62);
            this.cmbLoaiPhieu.Name = "cmbLoaiPhieu";
            this.cmbLoaiPhieu.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiPhieu.TabIndex = 20;
            this.cmbLoaiPhieu.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPhieu_SelectedIndexChanged);
            // 
            // dgvDSThongKe
            // 
            this.dgvDSThongKe.AllowUserToAddRows = false;
            this.dgvDSThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThongKe.Location = new System.Drawing.Point(12, 90);
            this.dgvDSThongKe.MultiSelect = false;
            this.dgvDSThongKe.Name = "dgvDSThongKe";
            this.dgvDSThongKe.ReadOnly = true;
            this.dgvDSThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSThongKe.Size = new System.Drawing.Size(965, 448);
            this.dgvDSThongKe.TabIndex = 21;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(989, 550);
            this.Controls.Add(this.dgvDSThongKe);
            this.Controls.Add(this.cmbLoaiPhieu);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.pnlTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ComboBox cmbLoaiPhieu;
        private System.Windows.Forms.DataGridView dgvDSThongKe;
    }
}