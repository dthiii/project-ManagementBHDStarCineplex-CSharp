using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.Phim
{
    partial class frmChitietphim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChitietphim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrailer = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.picPhanLoai = new System.Windows.Forms.PictureBox();
            this.lblMaPhim = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtNgayChieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhanLoai)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTrailer);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.picPoster);
            this.panel1.Controls.Add(this.picPhanLoai);
            this.panel1.Controls.Add(this.lblMaPhim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 720);
            this.panel1.TabIndex = 0;
            // 
            // btnTrailer
            // 
            this.btnTrailer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrailer.BackColor = System.Drawing.Color.Red;
            this.btnTrailer.FlatAppearance.BorderSize = 0;
            this.btnTrailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrailer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrailer.ForeColor = System.Drawing.Color.White;
            this.btnTrailer.Image = global::qlPhim.Properties.Resources.right_arrow;
            this.btnTrailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrailer.Location = new System.Drawing.Point(25, 409);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnTrailer.Size = new System.Drawing.Size(235, 55);
            this.btnTrailer.TabIndex = 0;
            this.btnTrailer.Text = "Trailer phim";
            this.btnTrailer.UseVisualStyleBackColor = false;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            this.btnTrailer.MouseEnter += new System.EventHandler(this.btnTrailer_MouseEnter);
            this.btnTrailer.MouseLeave += new System.EventHandler(this.btnTrailer_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtNoiDung);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(315, 420);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(925, 283);
            this.panel6.TabIndex = 7;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.Color.White;
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(14, 48);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ReadOnly = true;
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDung.Size = new System.Drawing.Size(888, 217);
            this.txtNoiDung.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nội dung phim";
            // 
            // picPoster
            // 
            this.picPoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPoster.BackColor = System.Drawing.SystemColors.Control;
            this.picPoster.Location = new System.Drawing.Point(25, 71);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(235, 322);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // picPhanLoai
            // 
            this.picPhanLoai.Location = new System.Drawing.Point(197, 24);
            this.picPhanLoai.Name = "picPhanLoai";
            this.picPhanLoai.Size = new System.Drawing.Size(59, 26);
            this.picPhanLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhanLoai.TabIndex = 4;
            this.picPhanLoai.TabStop = false;
            // 
            // lblMaPhim
            // 
            this.lblMaPhim.AutoSize = true;
            this.lblMaPhim.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhim.Location = new System.Drawing.Point(25, 13);
            this.lblMaPhim.Name = "lblMaPhim";
            this.lblMaPhim.Size = new System.Drawing.Size(162, 46);
            this.lblMaPhim.TabIndex = 3;
            this.lblMaPhim.Text = "Mã phim";
            this.lblMaPhim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTenPhim);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(315, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 377);
            this.panel2.TabIndex = 1;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.lblTenPhim.Location = new System.Drawing.Point(9, 9);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(185, 46);
            this.lblTenPhim.TabIndex = 8;
            this.lblTenPhim.Text = "TÊN PHIM";
            this.lblTenPhim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtTheLoai);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(9, 295);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(893, 55);
            this.panel7.TabIndex = 6;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.BackColor = System.Drawing.Color.White;
            this.txtTheLoai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(209, 9);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.ReadOnly = true;
            this.txtTheLoai.Size = new System.Drawing.Size(672, 36);
            this.txtTheLoai.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thể loại";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtNgayChieu);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Location = new System.Drawing.Point(459, 83);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(443, 55);
            this.panel10.TabIndex = 4;
            // 
            // txtNgayChieu
            // 
            this.txtNgayChieu.BackColor = System.Drawing.Color.White;
            this.txtNgayChieu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayChieu.Location = new System.Drawing.Point(209, 9);
            this.txtNgayChieu.Name = "txtNgayChieu";
            this.txtNgayChieu.ReadOnly = true;
            this.txtNgayChieu.Size = new System.Drawing.Size(222, 36);
            this.txtNgayChieu.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày khởi chiếu";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtThoiLuong);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(9, 83);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(443, 55);
            this.panel9.TabIndex = 3;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.BackColor = System.Drawing.Color.White;
            this.txtThoiLuong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiLuong.Location = new System.Drawing.Point(209, 9);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.ReadOnly = true;
            this.txtThoiLuong.Size = new System.Drawing.Size(132, 36);
            this.txtThoiLuong.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thời lượng (phút)";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtQuocGia);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(9, 153);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(893, 55);
            this.panel8.TabIndex = 2;
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.BackColor = System.Drawing.Color.White;
            this.txtQuocGia.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuocGia.Location = new System.Drawing.Point(209, 9);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.ReadOnly = true;
            this.txtQuocGia.Size = new System.Drawing.Size(672, 36);
            this.txtQuocGia.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quốc gia";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDaoDien);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(9, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(893, 55);
            this.panel4.TabIndex = 5;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.BackColor = System.Drawing.Color.White;
            this.txtDaoDien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaoDien.Location = new System.Drawing.Point(209, 9);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.ReadOnly = true;
            this.txtDaoDien.Size = new System.Drawing.Size(672, 36);
            this.txtDaoDien.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đạo diễn";
            // 
            // frmChitietphim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "frmChitietphim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phim";
            this.Load += new System.EventHandler(this.frmChitietphim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhanLoai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMaPhim;
        private System.Windows.Forms.PictureBox picPhanLoai;
        private System.Windows.Forms.Button btnTrailer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayChieu;
        private Label lblTenPhim;
    }
}