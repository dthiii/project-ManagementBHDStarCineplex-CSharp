using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel_Body = new System.Windows.Forms.Panel();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnPhim = new System.Windows.Forms.Button();
            this.btnTheloai = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnSuatchieu = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.btnBap = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1538, 76);
            this.panel1.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 76);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(316, 738);
            this.sidebar.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnDangxuat);
            this.panel10.Location = new System.Drawing.Point(1, 641);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(312, 89);
            this.panel10.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPhim);
            this.panel3.Location = new System.Drawing.Point(1, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 89);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTheloai);
            this.panel4.Location = new System.Drawing.Point(1, 95);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 89);
            this.panel4.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnThongke);
            this.panel9.Location = new System.Drawing.Point(1, 550);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(312, 89);
            this.panel9.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnNhanvien);
            this.panel8.Location = new System.Drawing.Point(1, 459);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(312, 89);
            this.panel8.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSuatchieu);
            this.panel5.Location = new System.Drawing.Point(1, 186);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(312, 89);
            this.panel5.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnKhachhang);
            this.panel7.Location = new System.Drawing.Point(1, 368);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(312, 89);
            this.panel7.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnBap);
            this.panel6.Location = new System.Drawing.Point(1, 277);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(312, 89);
            this.panel6.TabIndex = 4;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            // 
            // panel_Body
            // 
            this.panel_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Body.Location = new System.Drawing.Point(316, 76);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1221, 738);
            this.panel_Body.TabIndex = 3;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangxuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.ForeColor = System.Drawing.Color.White;
            this.btnDangxuat.Image = global::qlPhim.Properties.Resources.logout;
            this.btnDangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.Location = new System.Drawing.Point(0, 0);
            this.btnDangxuat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnDangxuat.Size = new System.Drawing.Size(312, 89);
            this.btnDangxuat.TabIndex = 0;
            this.btnDangxuat.Text = "        Đăng xuất";
            this.btnDangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.UseVisualStyleBackColor = false;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnPhim
            // 
            this.btnPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhim.ForeColor = System.Drawing.Color.White;
            this.btnPhim.Image = global::qlPhim.Properties.Resources.film1;
            this.btnPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhim.Location = new System.Drawing.Point(0, 0);
            this.btnPhim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnPhim.Size = new System.Drawing.Size(312, 89);
            this.btnPhim.TabIndex = 0;
            this.btnPhim.Text = "        Phim";
            this.btnPhim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhim.UseVisualStyleBackColor = false;
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
            // 
            // btnTheloai
            // 
            this.btnTheloai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnTheloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheloai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheloai.ForeColor = System.Drawing.Color.White;
            this.btnTheloai.Image = global::qlPhim.Properties.Resources.film11;
            this.btnTheloai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheloai.Location = new System.Drawing.Point(0, 0);
            this.btnTheloai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTheloai.Name = "btnTheloai";
            this.btnTheloai.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnTheloai.Size = new System.Drawing.Size(312, 89);
            this.btnTheloai.TabIndex = 0;
            this.btnTheloai.Text = "        Thể loại";
            this.btnTheloai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheloai.UseVisualStyleBackColor = false;
            this.btnTheloai.Click += new System.EventHandler(this.btnTheloai_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.Image = global::qlPhim.Properties.Resources.trend;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(0, 0);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnThongke.Size = new System.Drawing.Size(312, 89);
            this.btnThongke.TabIndex = 0;
            this.btnThongke.Text = "        Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnNhanvien.Image = global::qlPhim.Properties.Resources.man__1_;
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(0, 0);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnNhanvien.Size = new System.Drawing.Size(312, 89);
            this.btnNhanvien.TabIndex = 0;
            this.btnNhanvien.Text = "        Nhân viên";
            this.btnNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.UseVisualStyleBackColor = false;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnSuatchieu
            // 
            this.btnSuatchieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnSuatchieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuatchieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuatchieu.ForeColor = System.Drawing.Color.White;
            this.btnSuatchieu.Image = global::qlPhim.Properties.Resources.cinema;
            this.btnSuatchieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuatchieu.Location = new System.Drawing.Point(0, 0);
            this.btnSuatchieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSuatchieu.Name = "btnSuatchieu";
            this.btnSuatchieu.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnSuatchieu.Size = new System.Drawing.Size(312, 89);
            this.btnSuatchieu.TabIndex = 0;
            this.btnSuatchieu.Text = "        Suất chiếu";
            this.btnSuatchieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuatchieu.UseVisualStyleBackColor = false;
            this.btnSuatchieu.Click += new System.EventHandler(this.btnSuatchieu_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachhang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.ForeColor = System.Drawing.Color.White;
            this.btnKhachhang.Image = global::qlPhim.Properties.Resources.customer;
            this.btnKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.Location = new System.Drawing.Point(0, 0);
            this.btnKhachhang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnKhachhang.Size = new System.Drawing.Size(312, 89);
            this.btnKhachhang.TabIndex = 0;
            this.btnKhachhang.Text = "        Khách hàng";
            this.btnKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.UseVisualStyleBackColor = false;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnBap
            // 
            this.btnBap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnBap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBap.ForeColor = System.Drawing.Color.White;
            this.btnBap.Image = global::qlPhim.Properties.Resources.popcorn;
            this.btnBap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBap.Location = new System.Drawing.Point(0, 0);
            this.btnBap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBap.Name = "btnBap";
            this.btnBap.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnBap.Size = new System.Drawing.Size(312, 89);
            this.btnBap.TabIndex = 0;
            this.btnBap.Text = "        Bắp nước";
            this.btnBap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBap.UseVisualStyleBackColor = false;
            this.btnBap.Click += new System.EventHandler(this.btnBap_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::qlPhim.Properties.Resources.logo2024;
            this.pictureBox2.Location = new System.Drawing.Point(542, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(476, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnHam
            // 
            this.btnHam.Image = global::qlPhim.Properties.Resources.menu_10110130;
            this.btnHam.Location = new System.Drawing.Point(5, 14);
            this.btnHam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(61, 45);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 2;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1538, 814);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BHD CINEMA";
            this.panel1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private PictureBox btnHam;
        private PictureBox pictureBox2;
        private Panel sidebar;
        private Button btnPhim;
        private Panel panel3;
        private Panel panel4;
        private Button btnTheloai;
        private Panel panel5;
        private Button btnSuatchieu;
        private Panel panel6;
        private Button btnBap;
        private Panel panel7;
        private Button btnKhachhang;
        private Panel panel8;
        private Button btnNhanvien;
        private Panel panel9;
        private Button btnThongke;
        private Panel panel10;
        private Button btnDangxuat;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel_Body;
    }
}