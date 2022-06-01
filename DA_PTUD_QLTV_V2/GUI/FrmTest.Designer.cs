namespace GUI
{
    partial class FrmTest
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
            this.ucThongTinDauSach = new CustomControls.UcThongTinDauSach();
            this.SuspendLayout();
            // 
            // ucThongTinDauSach
            // 
            this.ucThongTinDauSach.AnhBia = null;
            this.ucThongTinDauSach.Location = new System.Drawing.Point(12, 12);
            this.ucThongTinDauSach.Name = "ucThongTinDauSach";
            this.ucThongTinDauSach.NamXuatBan = null;
            this.ucThongTinDauSach.NhaXuatBan = null;
            this.ucThongTinDauSach.Size = new System.Drawing.Size(537, 167);
            this.ucThongTinDauSach.TabIndex = 0;
            this.ucThongTinDauSach.TacGia = null;
            this.ucThongTinDauSach.TenSach = null;
            this.ucThongTinDauSach.TheLoai = null;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 382);
            this.Controls.Add(this.ucThongTinDauSach);
            this.Name = "FrmTest";
            this.Text = "FrmTest";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.UcThongTinDauSach ucThongTinDauSach;
    }
}