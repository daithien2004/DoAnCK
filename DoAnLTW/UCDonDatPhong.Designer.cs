namespace DoAnLTW
{
    partial class UCDonDatPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTinhtrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtNgaytra = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtNgaydat = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.Color.White;
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.DefaultText = "Mã đơn: 2A11";
            this.txtMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.Location = new System.Drawing.Point(259, 12);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMa.Name = "txtMa";
            this.txtMa.PasswordChar = '\0';
            this.txtMa.PlaceholderText = "";
            this.txtMa.SelectedText = "";
            this.txtMa.Size = new System.Drawing.Size(378, 40);
            this.txtMa.TabIndex = 64;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.BackColor = System.Drawing.Color.White;
            this.txtTinhtrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTinhtrang.DefaultText = "Tình Trạng: Hoàn Tất";
            this.txtTinhtrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTinhtrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTinhtrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinhtrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinhtrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhtrang.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhtrang.ForeColor = System.Drawing.Color.Black;
            this.txtTinhtrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhtrang.Location = new System.Drawing.Point(259, 148);
            this.txtTinhtrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.PasswordChar = '\0';
            this.txtTinhtrang.PlaceholderText = "";
            this.txtTinhtrang.SelectedText = "";
            this.txtTinhtrang.Size = new System.Drawing.Size(378, 40);
            this.txtTinhtrang.TabIndex = 67;
            // 
            // dtNgaytra
            // 
            this.dtNgaytra.BackColor = System.Drawing.Color.Transparent;
            this.dtNgaytra.BorderRadius = 10;
            this.dtNgaytra.Checked = true;
            this.dtNgaytra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.dtNgaytra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgaytra.ForeColor = System.Drawing.Color.White;
            this.dtNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtNgaytra.Location = new System.Drawing.Point(259, 103);
            this.dtNgaytra.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgaytra.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgaytra.Name = "dtNgaytra";
            this.dtNgaytra.Size = new System.Drawing.Size(378, 38);
            this.dtNgaytra.TabIndex = 69;
            this.dtNgaytra.Value = new System.DateTime(2024, 3, 7, 9, 52, 27, 126);
            // 
            // dtNgaydat
            // 
            this.dtNgaydat.BackColor = System.Drawing.Color.Transparent;
            this.dtNgaydat.BorderRadius = 10;
            this.dtNgaydat.Checked = true;
            this.dtNgaydat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtNgaydat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgaydat.ForeColor = System.Drawing.Color.Black;
            this.dtNgaydat.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtNgaydat.Location = new System.Drawing.Point(259, 59);
            this.dtNgaydat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgaydat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgaydat.Name = "dtNgaydat";
            this.dtNgaydat.Size = new System.Drawing.Size(378, 38);
            this.dtNgaydat.TabIndex = 68;
            this.dtNgaydat.Value = new System.DateTime(2024, 3, 7, 9, 52, 27, 126);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DoAnLTW.Properties.Resources.thiet_ke_noi_that_can_ho_chung_cu_vinhomes_metropolis_chi_nga_9_1024x683;
            this.gunaPictureBox1.Location = new System.Drawing.Point(13, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(227, 176);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 37;
            this.gunaPictureBox1.TabStop = false;
            // 
            // UCDonDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dtNgaytra);
            this.Controls.Add(this.dtNgaydat);
            this.Controls.Add(this.txtTinhtrang);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.gunaPictureBox1);
            this.Name = "UCDonDatPhong";
            this.Size = new System.Drawing.Size(667, 207);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI2.WinForms.Guna2TextBox txtMa;
        public Guna.UI2.WinForms.Guna2TextBox txtTinhtrang;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtNgaytra;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtNgaydat;
    }
}
