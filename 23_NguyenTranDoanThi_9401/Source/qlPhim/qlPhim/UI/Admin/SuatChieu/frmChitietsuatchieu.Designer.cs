using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.SuatChieu
{
    partial class frmChitietsuatchieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChitietsuatchieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGheTrong = new System.Windows.Forms.Label();
            this.lblTongGhe = new System.Windows.Forms.Label();
            this.lblGheDaDat = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaSC = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpGioBD = new System.Windows.Forms.DateTimePicker();
            this.txtGioKT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTenPhim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(886, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 744);
            this.panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(6, 674);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(180, 50);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(200, 674);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 50);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGheTrong);
            this.groupBox1.Controls.Add(this.lblTongGhe);
            this.groupBox1.Controls.Add(this.lblGheDaDat);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 499);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình trạng ghế";
            // 
            // lblGheTrong
            // 
            this.lblGheTrong.AutoSize = true;
            this.lblGheTrong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGheTrong.Location = new System.Drawing.Point(182, 59);
            this.lblGheTrong.Name = "lblGheTrong";
            this.lblGheTrong.Size = new System.Drawing.Size(33, 30);
            this.lblGheTrong.TabIndex = 6;
            this.lblGheTrong.Text = "10";
            // 
            // lblTongGhe
            // 
            this.lblTongGhe.AutoSize = true;
            this.lblTongGhe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGhe.Location = new System.Drawing.Point(182, 88);
            this.lblTongGhe.Name = "lblTongGhe";
            this.lblTongGhe.Size = new System.Drawing.Size(37, 30);
            this.lblTongGhe.TabIndex = 5;
            this.lblTongGhe.Text = "50";
            // 
            // lblGheDaDat
            // 
            this.lblGheDaDat.AutoSize = true;
            this.lblGheDaDat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGheDaDat.Location = new System.Drawing.Point(182, 30);
            this.lblGheDaDat.Name = "lblGheDaDat";
            this.lblGheDaDat.Size = new System.Drawing.Size(37, 30);
            this.lblGheDaDat.TabIndex = 4;
            this.lblGheDaDat.Text = "40";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 30);
            this.label14.TabIndex = 3;
            this.label14.Text = "Còn trống: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng số ghế: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đã đặt: ";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.cboPhong);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Location = new System.Drawing.Point(12, 206);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(368, 84);
            this.panel15.TabIndex = 2;
            // 
            // cboPhong
            // 
            this.cboPhong.BackColor = System.Drawing.Color.White;
            this.cboPhong.Enabled = false;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(10, 39);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(345, 36);
            this.cboPhong.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Phòng chiếu";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label10);
            this.panel14.Controls.Add(this.txtMaSC);
            this.panel14.Location = new System.Drawing.Point(12, 12);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(368, 84);
            this.panel14.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã suất chiếu";
            // 
            // txtMaSC
            // 
            this.txtMaSC.BackColor = System.Drawing.Color.White;
            this.txtMaSC.Enabled = false;
            this.txtMaSC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSC.Location = new System.Drawing.Point(10, 39);
            this.txtMaSC.Name = "txtMaSC";
            this.txtMaSC.Size = new System.Drawing.Size(345, 35);
            this.txtMaSC.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpGioBD);
            this.panel5.Controls.Add(this.txtGioKT);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(12, 400);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 84);
            this.panel5.TabIndex = 5;
            // 
            // dtpGioBD
            // 
            this.dtpGioBD.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpGioBD.CustomFormat = "HH:mm";
            this.dtpGioBD.Enabled = false;
            this.dtpGioBD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGioBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioBD.Location = new System.Drawing.Point(10, 39);
            this.dtpGioBD.Name = "dtpGioBD";
            this.dtpGioBD.ShowUpDown = true;
            this.dtpGioBD.Size = new System.Drawing.Size(107, 35);
            this.dtpGioBD.TabIndex = 1;
            this.dtpGioBD.ValueChanged += new System.EventHandler(this.dtpGioBD_ValueChanged);
            // 
            // txtGioKT
            // 
            this.txtGioKT.BackColor = System.Drawing.Color.White;
            this.txtGioKT.Enabled = false;
            this.txtGioKT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioKT.Location = new System.Drawing.Point(150, 39);
            this.txtGioKT.Name = "txtGioKT";
            this.txtGioKT.Size = new System.Drawing.Size(107, 35);
            this.txtGioKT.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(121, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 30);
            this.label12.TabIndex = 2;
            this.label12.Text = "~";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giờ chiếu";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpNgayChieu);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 84);
            this.panel4.TabIndex = 4;
            // 
            // dtpNgayChieu
            // 
            this.dtpNgayChieu.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayChieu.Enabled = false;
            this.dtpNgayChieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChieu.Location = new System.Drawing.Point(10, 39);
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(345, 35);
            this.dtpNgayChieu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày chiếu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTenPhim);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 84);
            this.panel2.TabIndex = 3;
            // 
            // cboTenPhim
            // 
            this.cboTenPhim.BackColor = System.Drawing.Color.White;
            this.cboTenPhim.Enabled = false;
            this.cboTenPhim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenPhim.FormattingEnabled = true;
            this.cboTenPhim.Location = new System.Drawing.Point(10, 39);
            this.cboTenPhim.Name = "cboTenPhim";
            this.cboTenPhim.Size = new System.Drawing.Size(345, 36);
            this.cboTenPhim.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phim";
            // 
            // flpGhe
            // 
            this.flpGhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGhe.Location = new System.Drawing.Point(0, 71);
            this.flpGhe.Name = "flpGhe";
            this.flpGhe.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.flpGhe.Size = new System.Drawing.Size(886, 585);
            this.flpGhe.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.flpGhe);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(886, 744);
            this.panel6.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel17);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 656);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(886, 88);
            this.panel8.TabIndex = 1;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label13);
            this.panel17.Controls.Add(this.button8);
            this.panel17.Location = new System.Drawing.Point(631, 18);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(126, 40);
            this.panel17.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 30);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ghế đôi";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(205)))));
            this.button8.Enabled = false;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(2, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 25);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.button3);
            this.panel12.Location = new System.Drawing.Point(478, 18);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(124, 40);
            this.panel12.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ghế VIP";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(2, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.button2);
            this.panel11.Location = new System.Drawing.Point(137, 18);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(113, 40);
            this.panel11.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đã đặt";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(2, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label9);
            this.panel13.Controls.Add(this.button4);
            this.panel13.Location = new System.Drawing.Point(281, 18);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(165, 40);
            this.panel13.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ghế thường";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(230)))));
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(2, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(886, 71);
            this.panel7.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(200, 15);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(500, 5);
            this.panel9.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "MÀN HÌNH";
            // 
            // frmChitietsuatchieu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "frmChitietsuatchieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết lịch chiếu";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpGhe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaSC;
        private System.Windows.Forms.TextBox txtGioKT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboTenPhim;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.DateTimePicker dtpGioBD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblGheTrong;
        private System.Windows.Forms.Label lblTongGhe;
        private System.Windows.Forms.Label lblGheDaDat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
    }
}