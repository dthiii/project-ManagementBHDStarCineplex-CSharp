using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.NhanVien
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.pnlAddCustomer = new System.Windows.Forms.Panel();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.rdoKhac = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiemTichLuy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMovie = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTienVe = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGhe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGioChieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayChieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.flpSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtTienBapNuoc = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.pnlTongTien = new System.Windows.Forms.Panel();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.pnlKhachHang.SuspendLayout();
            this.pnlAddCustomer.SuspendLayout();
            this.pnlCustomerInfo.SuspendLayout();
            this.pnlMovie.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.pnlTongTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.BackColor = System.Drawing.Color.White;
            this.pnlKhachHang.Controls.Add(this.pnlAddCustomer);
            this.pnlKhachHang.Controls.Add(this.pnlCustomerInfo);
            this.pnlKhachHang.Controls.Add(this.textBox3);
            this.pnlKhachHang.Controls.Add(this.btnTimkiem);
            this.pnlKhachHang.Controls.Add(this.txtDienThoai);
            this.pnlKhachHang.Controls.Add(this.label2);
            this.pnlKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlKhachHang.Location = new System.Drawing.Point(851, 22);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(400, 375);
            this.pnlKhachHang.TabIndex = 0;
            // 
            // pnlAddCustomer
            // 
            this.pnlAddCustomer.Controls.Add(this.btnThemKH);
            this.pnlAddCustomer.Controls.Add(this.rdoKhac);
            this.pnlAddCustomer.Controls.Add(this.rdoNu);
            this.pnlAddCustomer.Controls.Add(this.rdoNam);
            this.pnlAddCustomer.Controls.Add(this.txtTenKH);
            this.pnlAddCustomer.Controls.Add(this.label4);
            this.pnlAddCustomer.Controls.Add(this.txtHoKH);
            this.pnlAddCustomer.Controls.Add(this.label3);
            this.pnlAddCustomer.Location = new System.Drawing.Point(3, 132);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Size = new System.Drawing.Size(393, 222);
            this.pnlAddCustomer.TabIndex = 4;
            this.pnlAddCustomer.Visible = false;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThemKH.FlatAppearance.BorderSize = 0;
            this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.Color.White;
            this.btnThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKH.Location = new System.Drawing.Point(226, 162);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(130, 40);
            this.btnThemKH.TabIndex = 40;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // rdoKhac
            // 
            this.rdoKhac.AutoSize = true;
            this.rdoKhac.Location = new System.Drawing.Point(273, 115);
            this.rdoKhac.Name = "rdoKhac";
            this.rdoKhac.Size = new System.Drawing.Size(83, 34);
            this.rdoKhac.TabIndex = 11;
            this.rdoKhac.TabStop = true;
            this.rdoKhac.Text = "Khác";
            this.rdoKhac.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(201, 115);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(66, 34);
            this.rdoNu.TabIndex = 10;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(102, 115);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(83, 34);
            this.rdoNam.TabIndex = 9;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(100, 62);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(268, 35);
            this.txtTenKH.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên:";
            // 
            // txtHoKH
            // 
            this.txtHoKH.Location = new System.Drawing.Point(100, 13);
            this.txtHoKH.Name = "txtHoKH";
            this.txtHoKH.Size = new System.Drawing.Size(268, 35);
            this.txtHoKH.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ:";
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.Controls.Add(this.txtChietKhau);
            this.pnlCustomerInfo.Controls.Add(this.label13);
            this.pnlCustomerInfo.Controls.Add(this.txtDiemTichLuy);
            this.pnlCustomerInfo.Controls.Add(this.label11);
            this.pnlCustomerInfo.Controls.Add(this.txtHoTenKH);
            this.pnlCustomerInfo.Controls.Add(this.label12);
            this.pnlCustomerInfo.Location = new System.Drawing.Point(3, 132);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Size = new System.Drawing.Size(393, 182);
            this.pnlCustomerInfo.TabIndex = 26;
            this.pnlCustomerInfo.Visible = false;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.BackColor = System.Drawing.Color.White;
            this.txtChietKhau.Enabled = false;
            this.txtChietKhau.Location = new System.Drawing.Point(155, 121);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(216, 35);
            this.txtChietKhau.TabIndex = 10;
            this.txtChietKhau.Text = "0%";
            this.txtChietKhau.TextChanged += new System.EventHandler(this.txtChietKhau_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 30);
            this.label13.TabIndex = 9;
            this.label13.Text = "Chiết khấu:";
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.BackColor = System.Drawing.Color.White;
            this.txtDiemTichLuy.Enabled = false;
            this.txtDiemTichLuy.Location = new System.Drawing.Point(155, 65);
            this.txtDiemTichLuy.Name = "txtDiemTichLuy";
            this.txtDiemTichLuy.Size = new System.Drawing.Size(216, 35);
            this.txtDiemTichLuy.TabIndex = 8;
            this.txtDiemTichLuy.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 30);
            this.label11.TabIndex = 7;
            this.label11.Text = "Điểm tích lũy:";
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.BackColor = System.Drawing.Color.White;
            this.txtHoTenKH.Enabled = false;
            this.txtHoTenKH.Location = new System.Drawing.Point(156, 13);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(216, 35);
            this.txtHoTenKH.TabIndex = 6;
            this.txtHoTenKH.Text = "Họ tên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 30);
            this.label12.TabIndex = 5;
            this.label12.Text = "Họ và tên:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(393, 36);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "THÔNG TIN KHÁCH HÀNG";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.Image = global::qlPhim.Properties.Resources.loupe;
            this.btnTimkiem.Location = new System.Drawing.Point(343, 81);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(35, 35);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(159, 83);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(178, 35);
            this.txtDienThoai.TabIndex = 2;
            this.txtDienThoai.TextChanged += new System.EventHandler(this.txtDienThoai_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điện thoại:";
            // 
            // pnlMovie
            // 
            this.pnlMovie.BackColor = System.Drawing.Color.White;
            this.pnlMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMovie.Controls.Add(this.label9);
            this.pnlMovie.Controls.Add(this.txtTienVe);
            this.pnlMovie.Controls.Add(this.panel4);
            this.pnlMovie.Controls.Add(this.label8);
            this.pnlMovie.Controls.Add(this.txtGhe);
            this.pnlMovie.Controls.Add(this.label7);
            this.pnlMovie.Controls.Add(this.txtPhong);
            this.pnlMovie.Controls.Add(this.label6);
            this.pnlMovie.Controls.Add(this.txtGioChieu);
            this.pnlMovie.Controls.Add(this.label5);
            this.pnlMovie.Controls.Add(this.txtNgayChieu);
            this.pnlMovie.Controls.Add(this.label1);
            this.pnlMovie.Controls.Add(this.txtTenPhim);
            this.pnlMovie.Controls.Add(this.textBox4);
            this.pnlMovie.Location = new System.Drawing.Point(31, 22);
            this.pnlMovie.Name = "pnlMovie";
            this.pnlMovie.Size = new System.Drawing.Size(400, 680);
            this.pnlMovie.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 590);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tổng:";
            // 
            // txtTienVe
            // 
            this.txtTienVe.BackColor = System.Drawing.Color.White;
            this.txtTienVe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienVe.Enabled = false;
            this.txtTienVe.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienVe.Location = new System.Drawing.Point(223, 590);
            this.txtTienVe.Name = "txtTienVe";
            this.txtTienVe.Size = new System.Drawing.Size(135, 35);
            this.txtTienVe.TabIndex = 24;
            this.txtTienVe.Text = "100.000";
            this.txtTienVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(12, 580);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 2);
            this.panel4.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 30);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ghế:";
            // 
            // txtGhe
            // 
            this.txtGhe.BackColor = System.Drawing.Color.White;
            this.txtGhe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGhe.Enabled = false;
            this.txtGhe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhe.Location = new System.Drawing.Point(172, 254);
            this.txtGhe.Name = "txtGhe";
            this.txtGhe.Size = new System.Drawing.Size(197, 28);
            this.txtGhe.TabIndex = 21;
            this.txtGhe.Text = "A4, A10";
            this.txtGhe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phòng chiếu:";
            // 
            // txtPhong
            // 
            this.txtPhong.BackColor = System.Drawing.Color.White;
            this.txtPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhong.Enabled = false;
            this.txtPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(234, 210);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(135, 28);
            this.txtPhong.TabIndex = 19;
            this.txtPhong.Text = "Phòng 4";
            this.txtPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giờ chiếu:";
            // 
            // txtGioChieu
            // 
            this.txtGioChieu.BackColor = System.Drawing.Color.White;
            this.txtGioChieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGioChieu.Enabled = false;
            this.txtGioChieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioChieu.Location = new System.Drawing.Point(208, 166);
            this.txtGioChieu.Name = "txtGioChieu";
            this.txtGioChieu.Size = new System.Drawing.Size(161, 28);
            this.txtGioChieu.TabIndex = 17;
            this.txtGioChieu.Text = "10:04 ~ 10:04";
            this.txtGioChieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày chiếu:";
            // 
            // txtNgayChieu
            // 
            this.txtNgayChieu.BackColor = System.Drawing.Color.White;
            this.txtNgayChieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNgayChieu.Enabled = false;
            this.txtNgayChieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayChieu.Location = new System.Drawing.Point(224, 121);
            this.txtNgayChieu.Name = "txtNgayChieu";
            this.txtNgayChieu.Size = new System.Drawing.Size(145, 28);
            this.txtNgayChieu.TabIndex = 15;
            this.txtNgayChieu.Text = "10/04/2024";
            this.txtNgayChieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên phim:";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.White;
            this.txtTenPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenPhim.Enabled = false;
            this.txtTenPhim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(208, 80);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(161, 28);
            this.txtTenPhim.TabIndex = 12;
            this.txtTenPhim.Text = "TÊN PHIM";
            this.txtTenPhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(372, 36);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "PHIM";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlProduct
            // 
            this.pnlProduct.BackColor = System.Drawing.Color.White;
            this.pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProduct.Controls.Add(this.flpSanPham);
            this.pnlProduct.Controls.Add(this.label10);
            this.pnlProduct.Controls.Add(this.textBox5);
            this.pnlProduct.Controls.Add(this.txtTienBapNuoc);
            this.pnlProduct.Controls.Add(this.panel5);
            this.pnlProduct.Location = new System.Drawing.Point(441, 22);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(400, 680);
            this.pnlProduct.TabIndex = 2;
            // 
            // flpSanPham
            // 
            this.flpSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpSanPham.Location = new System.Drawing.Point(-1, 77);
            this.flpSanPham.Name = "flpSanPham";
            this.flpSanPham.Size = new System.Drawing.Size(384, 499);
            this.flpSanPham.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 590);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 36);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tổng:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(12, 28);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(372, 36);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "BẮP - NƯỚC";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTienBapNuoc
            // 
            this.txtTienBapNuoc.BackColor = System.Drawing.Color.White;
            this.txtTienBapNuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienBapNuoc.Enabled = false;
            this.txtTienBapNuoc.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienBapNuoc.Location = new System.Drawing.Point(223, 590);
            this.txtTienBapNuoc.Name = "txtTienBapNuoc";
            this.txtTienBapNuoc.Size = new System.Drawing.Size(135, 35);
            this.txtTienBapNuoc.TabIndex = 27;
            this.txtTienBapNuoc.Text = "100.000";
            this.txtTienBapNuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(13, 582);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(370, 2);
            this.panel5.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 30);
            this.label14.TabIndex = 32;
            this.label14.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTongTien.Location = new System.Drawing.Point(224, 19);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 30);
            this.txtTongTien.TabIndex = 33;
            this.txtTongTien.Text = "100.000 đ";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label15.Location = new System.Drawing.Point(6, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 30);
            this.label15.TabIndex = 34;
            this.label15.Text = "Khuyến mãi:";
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.BackColor = System.Drawing.Color.White;
            this.txtKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKhuyenMai.Enabled = false;
            this.txtKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtKhuyenMai.Location = new System.Drawing.Point(224, 69);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(150, 30);
            this.txtKhuyenMai.TabIndex = 35;
            this.txtKhuyenMai.Text = "0 đ";
            this.txtKhuyenMai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label16.Location = new System.Drawing.Point(7, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 30);
            this.label16.TabIndex = 36;
            this.label16.Text = "Phải thanh toán:";
            // 
            // txtTongThu
            // 
            this.txtTongThu.BackColor = System.Drawing.Color.White;
            this.txtTongThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongThu.Enabled = false;
            this.txtTongThu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThu.Location = new System.Drawing.Point(252, 120);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(123, 30);
            this.txtTongThu.TabIndex = 37;
            this.txtTongThu.Text = "100.000 đ";
            this.txtTongThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlTongTien
            // 
            this.pnlTongTien.BackColor = System.Drawing.Color.White;
            this.pnlTongTien.Controls.Add(this.label14);
            this.pnlTongTien.Controls.Add(this.txtTongTien);
            this.pnlTongTien.Controls.Add(this.label16);
            this.pnlTongTien.Controls.Add(this.txtKhuyenMai);
            this.pnlTongTien.Controls.Add(this.txtTongThu);
            this.pnlTongTien.Controls.Add(this.label15);
            this.pnlTongTien.Location = new System.Drawing.Point(851, 422);
            this.pnlTongTien.Name = "pnlTongTien";
            this.pnlTongTien.Size = new System.Drawing.Size(400, 185);
            this.pnlTongTien.TabIndex = 38;
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnTaoHD.FlatAppearance.BorderSize = 0;
            this.btnTaoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHD.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.ForeColor = System.Drawing.Color.White;
            this.btnTaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHD.Location = new System.Drawing.Point(1062, 635);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(189, 55);
            this.btnTaoHD.TabIndex = 39;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            this.btnTaoHD.Visible = false;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.pnlTongTien);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.pnlMovie);
            this.Controls.Add(this.pnlKhachHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.pnlKhachHang.ResumeLayout(false);
            this.pnlKhachHang.PerformLayout();
            this.pnlAddCustomer.ResumeLayout(false);
            this.pnlAddCustomer.PerformLayout();
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            this.pnlMovie.ResumeLayout(false);
            this.pnlMovie.PerformLayout();
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.pnlTongTien.ResumeLayout(false);
            this.pnlTongTien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Panel pnlAddCustomer;
        private System.Windows.Forms.TextBox txtHoKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoKhac;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Panel pnlMovie;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayChieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGioChieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGhe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTienVe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienBapNuoc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flpSanPham;
        private System.Windows.Forms.Panel pnlCustomerInfo;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.Panel pnlTongTien;
        private System.Windows.Forms.Button btnTaoHD;
        private Button btnThemKH;
    }
}