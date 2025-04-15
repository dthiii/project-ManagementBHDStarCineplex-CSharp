using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.SuatChieu
{
    partial class frmThemsuatchieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemsuatchieu));
            this.label7 = new System.Windows.Forms.Label();
            this.dtpGioChieu = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.cboTenPhim = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaSC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbThongTinSC = new System.Windows.Forms.GroupBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblGioChieu = new System.Windows.Forms.Label();
            this.lblNgayChieu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.grbThongTinSC.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "Giờ chiếu";
            // 
            // dtpGioChieu
            // 
            this.dtpGioChieu.CustomFormat = "HH:mm";
            this.dtpGioChieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioChieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioChieu.Location = new System.Drawing.Point(210, 9);
            this.dtpGioChieu.Name = "dtpGioChieu";
            this.dtpGioChieu.ShowUpDown = true;
            this.dtpGioChieu.Size = new System.Drawing.Size(199, 35);
            this.dtpGioChieu.TabIndex = 19;
            this.dtpGioChieu.ValueChanged += new System.EventHandler(this.dtpGioChieu_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày chiếu";
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChieu.Location = new System.Drawing.Point(216, 9);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(199, 35);
            this.dtpNgayChieu.TabIndex = 17;
            this.dtpNgayChieu.ValueChanged += new System.EventHandler(this.dtpNgayChieu_ValueChanged);
            // 
            // cboTenPhim
            // 
            this.cboTenPhim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenPhim.FormattingEnabled = true;
            this.cboTenPhim.Location = new System.Drawing.Point(216, 9);
            this.cboTenPhim.Name = "cboTenPhim";
            this.cboTenPhim.Size = new System.Drawing.Size(667, 36);
            this.cboTenPhim.TabIndex = 16;
            this.cboTenPhim.SelectedIndexChanged += new System.EventHandler(this.cboTenPhim_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 30);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tên phim";
            // 
            // cboPhong
            // 
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(216, 9);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(199, 36);
            this.cboPhong.TabIndex = 14;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 30);
            this.label10.TabIndex = 13;
            this.label10.Text = "Phòng chiếu";
            // 
            // txtMaSC
            // 
            this.txtMaSC.BackColor = System.Drawing.Color.White;
            this.txtMaSC.Enabled = false;
            this.txtMaSC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSC.Location = new System.Drawing.Point(216, 9);
            this.txtMaSC.Name = "txtMaSC";
            this.txtMaSC.Size = new System.Drawing.Size(199, 35);
            this.txtMaSC.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 30);
            this.label11.TabIndex = 11;
            this.label11.Text = "Mã suất chiếu";
            // 
            // picPoster
            // 
            this.picPoster.BackColor = System.Drawing.SystemColors.Control;
            this.picPoster.Location = new System.Drawing.Point(46, 40);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(235, 322);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 21;
            this.picPoster.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(968, 626);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(265, 59);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbThongTinSC
            // 
            this.grbThongTinSC.Controls.Add(this.lblPhong);
            this.grbThongTinSC.Controls.Add(this.lblGioChieu);
            this.grbThongTinSC.Controls.Add(this.lblNgayChieu);
            this.grbThongTinSC.Controls.Add(this.label3);
            this.grbThongTinSC.Controls.Add(this.label2);
            this.grbThongTinSC.Controls.Add(this.label1);
            this.grbThongTinSC.Controls.Add(this.lblTenPhim);
            this.grbThongTinSC.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinSC.Location = new System.Drawing.Point(46, 416);
            this.grbThongTinSC.Name = "grbThongTinSC";
            this.grbThongTinSC.Size = new System.Drawing.Size(719, 275);
            this.grbThongTinSC.TabIndex = 23;
            this.grbThongTinSC.TabStop = false;
            this.grbThongTinSC.Text = "Thông tin suất chiếu";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(184, 210);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(93, 30);
            this.lblPhong.TabIndex = 6;
            this.lblPhong.Text = "Phòng 4";
            // 
            // lblGioChieu
            // 
            this.lblGioChieu.AutoSize = true;
            this.lblGioChieu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioChieu.Location = new System.Drawing.Point(184, 155);
            this.lblGioChieu.Name = "lblGioChieu";
            this.lblGioChieu.Size = new System.Drawing.Size(190, 30);
            this.lblGioChieu.TabIndex = 5;
            this.lblGioChieu.Text = "HH:mm ~ HH:mm";
            // 
            // lblNgayChieu
            // 
            this.lblNgayChieu.AutoSize = true;
            this.lblNgayChieu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayChieu.Location = new System.Drawing.Point(184, 100);
            this.lblNgayChieu.Name = "lblNgayChieu";
            this.lblNgayChieu.Size = new System.Drawing.Size(141, 30);
            this.lblNgayChieu.TabIndex = 4;
            this.lblNgayChieu.Text = "dd/MM/yyyy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phòng chiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giờ chiếu: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày chiếu: ";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.lblTenPhim.Location = new System.Drawing.Point(30, 45);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(141, 36);
            this.lblTenPhim.TabIndex = 0;
            this.lblTenPhim.Text = "TÊN PHIM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtMaSC);
            this.panel1.Location = new System.Drawing.Point(325, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 55);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cboPhong);
            this.panel2.Location = new System.Drawing.Point(793, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 55);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cboTenPhim);
            this.panel3.Location = new System.Drawing.Point(325, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 55);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtpNgayChieu);
            this.panel4.Location = new System.Drawing.Point(325, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 55);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dtpGioChieu);
            this.panel5.Location = new System.Drawing.Point(799, 204);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(434, 55);
            this.panel5.TabIndex = 25;
            // 
            // frmThemsuatchieu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbThongTinSC);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.picPoster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "frmThemsuatchieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm suất chiếu";
            this.Load += new System.EventHandler(this.frmThemsuatchieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.grbThongTinSC.ResumeLayout(false);
            this.grbThongTinSC.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpGioChieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.ComboBox cboTenPhim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaSC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbThongTinSC;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblGioChieu;
        private System.Windows.Forms.Label lblNgayChieu;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}