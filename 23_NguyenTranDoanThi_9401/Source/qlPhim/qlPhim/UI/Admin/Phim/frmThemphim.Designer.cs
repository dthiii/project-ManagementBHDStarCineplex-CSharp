using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.Phim
{
    partial class frmThemphim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemphim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboPhanLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtTrailer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.clbTheLoai = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonAnh);
            this.panel1.Controls.Add(this.picPoster);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 720);
            this.panel1.TabIndex = 1;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.SystemColors.Control;
            this.btnChonAnh.FlatAppearance.BorderSize = 0;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnChonAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonAnh.Location = new System.Drawing.Point(25, 443);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(234, 53);
            this.btnChonAnh.TabIndex = 10;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            // 
            // picPoster
            // 
            this.picPoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPoster.BackColor = System.Drawing.SystemColors.Control;
            this.picPoster.Location = new System.Drawing.Point(25, 100);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(235, 322);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtMaPhim);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(15, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(256, 55);
            this.panel5.TabIndex = 3;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.BackColor = System.Drawing.Color.White;
            this.txtMaPhim.Enabled = false;
            this.txtMaPhim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhim.Location = new System.Drawing.Point(111, 10);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(133, 36);
            this.txtMaPhim.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã phim";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Location = new System.Drawing.Point(290, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 699);
            this.panel2.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(762, 638);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(183, 50);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(560, 638);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(183, 50);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtpNgayChieu);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(653, 97);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(305, 84);
            this.panel10.TabIndex = 5;
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChieu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChieu.Location = new System.Drawing.Point(10, 39);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(279, 36);
            this.dtpNgayChieu.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày khởi chiếu";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboPhanLoai);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(15, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 84);
            this.panel4.TabIndex = 2;
            // 
            // cboPhanLoai
            // 
            this.cboPhanLoai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanLoai.FormattingEnabled = true;
            this.cboPhanLoai.Location = new System.Drawing.Point(10, 39);
            this.cboPhanLoai.Name = "cboPhanLoai";
            this.cboPhanLoai.Size = new System.Drawing.Size(279, 38);
            this.cboPhanLoai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phân loại";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtDaoDien);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Location = new System.Drawing.Point(15, 199);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(463, 84);
            this.panel11.TabIndex = 6;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.BackColor = System.Drawing.Color.White;
            this.txtDaoDien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaoDien.Location = new System.Drawing.Point(10, 39);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.Size = new System.Drawing.Size(440, 36);
            this.txtDaoDien.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Đạo diễn";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtTrailer);
            this.panel13.Controls.Add(this.label11);
            this.panel13.Location = new System.Drawing.Point(15, 298);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(305, 84);
            this.panel13.TabIndex = 7;
            // 
            // txtTrailer
            // 
            this.txtTrailer.BackColor = System.Drawing.Color.White;
            this.txtTrailer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrailer.Location = new System.Drawing.Point(10, 39);
            this.txtTrailer.Name = "txtTrailer";
            this.txtTrailer.Size = new System.Drawing.Size(279, 36);
            this.txtTrailer.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "Trailer (Link youtube)";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.clbTheLoai);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(15, 400);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(305, 228);
            this.panel7.TabIndex = 9;
            // 
            // clbTheLoai
            // 
            this.clbTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbTheLoai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTheLoai.FormattingEnabled = true;
            this.clbTheLoai.Location = new System.Drawing.Point(10, 39);
            this.clbTheLoai.Name = "clbTheLoai";
            this.clbTheLoai.Size = new System.Drawing.Size(279, 165);
            this.clbTheLoai.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thể loại";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTenPhim);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(15, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 55);
            this.panel3.TabIndex = 1;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.White;
            this.txtTenPhim.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(188, 9);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(742, 36);
            this.txtTenPhim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên phim";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtNoiDung);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(326, 298);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(632, 330);
            this.panel6.TabIndex = 8;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.Color.White;
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(10, 39);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDung.Size = new System.Drawing.Size(606, 279);
            this.txtNoiDung.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nội dung phim";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtThoiLuong);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(334, 97);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(305, 84);
            this.panel9.TabIndex = 4;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.BackColor = System.Drawing.Color.White;
            this.txtThoiLuong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiLuong.Location = new System.Drawing.Point(10, 39);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(279, 36);
            this.txtThoiLuong.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thời lượng (phút)";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtQuocGia);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(495, 199);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(463, 84);
            this.panel8.TabIndex = 3;
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.BackColor = System.Drawing.Color.White;
            this.txtQuocGia.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuocGia.Location = new System.Drawing.Point(10, 39);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(440, 36);
            this.txtQuocGia.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quốc gia";
            // 
            // frmThemphim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "frmThemphim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm phim mới";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clbTheLoai;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtTrailer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboPhanLoai;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
    }
}