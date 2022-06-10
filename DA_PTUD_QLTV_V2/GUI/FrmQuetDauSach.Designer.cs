namespace GUI
{
    partial class FrmQuetDauSach
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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDauSach = new System.Windows.Forms.ComboBox();
            this.btnHoanTat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(422, 317);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách đầu sách:";
            // 
            // cmbDauSach
            // 
            this.cmbDauSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDauSach.FormattingEnabled = true;
            this.cmbDauSach.Location = new System.Drawing.Point(129, 336);
            this.cmbDauSach.Name = "cmbDauSach";
            this.cmbDauSach.Size = new System.Drawing.Size(224, 21);
            this.cmbDauSach.TabIndex = 2;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(359, 335);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(75, 23);
            this.btnHoanTat.TabIndex = 3;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            // 
            // FrmQuetDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 364);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.cmbDauSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDisplay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(462, 403);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(462, 403);
            this.Name = "FrmQuetDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quét đầu sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuetDauSach_FormClosing);
            this.Load += new System.EventHandler(this.FrmQuetDauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDauSach;
        private System.Windows.Forms.Button btnHoanTat;
    }
}