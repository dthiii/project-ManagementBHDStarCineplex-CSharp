using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.NhanVien
{
    partial class frmSuatchieu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.dgvSuatchieu = new System.Windows.Forms.DataGridView();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMoiveInfo = new System.Windows.Forms.Panel();
            this.txtNgayGio = new System.Windows.Forms.TextBox();
            this.btnChonGhe = new System.Windows.Forms.Button();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuocGia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatchieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMoiveInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1427, 891);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTimkiem);
            this.panel3.Controls.Add(this.btnTimkiem);
            this.panel3.Controls.Add(this.dgvSuatchieu);
            this.panel3.Controls.Add(this.dtpNgayChieu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 891);
            this.panel3.TabIndex = 20;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(30, 87);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(420, 35);
            this.txtTimkiem.TabIndex = 16;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.Image = global::qlPhim.Properties.Resources.loupe;
            this.btnTimkiem.Location = new System.Drawing.Point(458, 80);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(50, 50);
            this.btnTimkiem.TabIndex = 17;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // dgvSuatchieu
            // 
            this.dgvSuatchieu.AllowUserToResizeColumns = false;
            this.dgvSuatchieu.AllowUserToResizeRows = false;
            this.dgvSuatchieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuatchieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuatchieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuatchieu.ColumnHeadersHeight = 50;
            this.dgvSuatchieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuatchieu.GridColor = System.Drawing.Color.Silver;
            this.dgvSuatchieu.Location = new System.Drawing.Point(30, 144);
            this.dgvSuatchieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSuatchieu.Name = "dgvSuatchieu";
            this.dgvSuatchieu.ReadOnly = true;
            this.dgvSuatchieu.RowHeadersVisible = false;
            this.dgvSuatchieu.RowHeadersWidth = 70;
            this.dgvSuatchieu.RowTemplate.Height = 24;
            this.dgvSuatchieu.Size = new System.Drawing.Size(926, 718);
            this.dgvSuatchieu.TabIndex = 18;
            this.dgvSuatchieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuatchieu_CellClick);
            this.dgvSuatchieu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuatchieu_CellDoubleClick);
            this.dgvSuatchieu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSuatchieu_CellFormatting);
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayChieu.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChieu.Location = new System.Drawing.Point(727, 82);
            this.dtpNgayChieu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(206, 43);
            this.dtpNgayChieu.TabIndex = 15;
            this.dtpNgayChieu.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlMoiveInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(986, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 891);
            this.panel1.TabIndex = 19;
            // 
            // pnlMoiveInfo
            // 
            this.pnlMoiveInfo.Controls.Add(this.txtNgayGio);
            this.pnlMoiveInfo.Controls.Add(this.btnChonGhe);
            this.pnlMoiveInfo.Controls.Add(this.lblTheLoai);
            this.pnlMoiveInfo.Controls.Add(this.label6);
            this.pnlMoiveInfo.Controls.Add(this.lblPhanLoai);
            this.pnlMoiveInfo.Controls.Add(this.label8);
            this.pnlMoiveInfo.Controls.Add(this.lblThoiLuong);
            this.pnlMoiveInfo.Controls.Add(this.label4);
            this.pnlMoiveInfo.Controls.Add(this.lblQuocGia);
            this.pnlMoiveInfo.Controls.Add(this.label1);
            this.pnlMoiveInfo.Controls.Add(this.txtTenPhim);
            this.pnlMoiveInfo.Controls.Add(this.picPoster);
            this.pnlMoiveInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMoiveInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlMoiveInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMoiveInfo.Name = "pnlMoiveInfo";
            this.pnlMoiveInfo.Size = new System.Drawing.Size(441, 891);
            this.pnlMoiveInfo.TabIndex = 11;
            this.pnlMoiveInfo.Visible = false;
            // 
            // txtNgayGio
            // 
            this.txtNgayGio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgayGio.Enabled = false;
            this.txtNgayGio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayGio.Location = new System.Drawing.Point(24, 465);
            this.txtNgayGio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayGio.Name = "txtNgayGio";
            this.txtNgayGio.Size = new System.Drawing.Size(397, 28);
            this.txtNgayGio.TabIndex = 22;
            this.txtNgayGio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChonGhe
            // 
            this.btnChonGhe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonGhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnChonGhe.FlatAppearance.BorderSize = 0;
            this.btnChonGhe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonGhe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonGhe.ForeColor = System.Drawing.Color.White;
            this.btnChonGhe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonGhe.Location = new System.Drawing.Point(87, 742);
            this.btnChonGhe.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonGhe.Name = "btnChonGhe";
            this.btnChonGhe.Size = new System.Drawing.Size(235, 60);
            this.btnChonGhe.TabIndex = 21;
            this.btnChonGhe.Text = "Chọn ghế";
            this.btnChonGhe.UseVisualStyleBackColor = false;
            this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(181, 669);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(86, 30);
            this.lblTheLoai.TabIndex = 20;
            this.lblTheLoai.Text = "Thể loại";
            this.lblTheLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 669);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Thể loại:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location = new System.Drawing.Point(181, 621);
            this.lblPhanLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(99, 30);
            this.lblPhanLoai.TabIndex = 18;
            this.lblPhanLoai.Text = "Phân loại";
            this.lblPhanLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 621);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phân loại:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.Location = new System.Drawing.Point(181, 568);
            this.lblThoiLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(114, 30);
            this.lblThoiLuong.TabIndex = 16;
            this.lblThoiLuong.Text = "Thời lượng";
            this.lblThoiLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 568);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Thời lượng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuocGia
            // 
            this.lblQuocGia.AutoSize = true;
            this.lblQuocGia.Location = new System.Drawing.Point(181, 520);
            this.lblQuocGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuocGia.Name = "lblQuocGia";
            this.lblQuocGia.Size = new System.Drawing.Size(97, 30);
            this.lblQuocGia.TabIndex = 14;
            this.lblQuocGia.Text = "Quốc gia";
            this.lblQuocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 520);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quốc gia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenPhim.Enabled = false;
            this.txtTenPhim.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(24, 411);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(397, 36);
            this.txtTenPhim.TabIndex = 12;
            this.txtTenPhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picPoster
            // 
            this.picPoster.BackColor = System.Drawing.SystemColors.Control;
            this.picPoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPoster.Location = new System.Drawing.Point(95, 50);
            this.picPoster.Margin = new System.Windows.Forms.Padding(4);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(235, 322);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 11;
            this.picPoster.TabStop = false;
            // 
            // frmSuatchieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 891);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSuatchieu";
            this.Text = "fEMovie";
            this.Load += new System.EventHandler(this.frmSuatchieu_Load);
            this.SizeChanged += new System.EventHandler(this.frmSuatchieu_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatchieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlMoiveInfo.ResumeLayout(false);
            this.pnlMoiveInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMoiveInfo;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridView dgvSuatchieu;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.TextBox txtNgayGio;
    }
}