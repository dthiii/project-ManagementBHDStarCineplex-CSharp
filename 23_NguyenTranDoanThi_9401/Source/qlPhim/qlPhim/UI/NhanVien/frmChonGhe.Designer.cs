using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.NhanVien
{
    partial class frmChonGhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonGhe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtNgayChieu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtGhe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpGhe = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTiepTuc);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel10);
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
            // btnTiepTuc
            // 
            this.btnTiepTuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTiepTuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnTiepTuc.FlatAppearance.BorderSize = 0;
            this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiepTuc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.ForeColor = System.Drawing.Color.White;
            this.btnTiepTuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiepTuc.Location = new System.Drawing.Point(191, 646);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(189, 50);
            this.btnTiepTuc.TabIndex = 22;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = false;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(206, 556);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(161, 36);
            this.txtTongTien.TabIndex = 3;
            this.txtTongTien.Text = "0 đ";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng cộng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(0, 527);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 2);
            this.panel3.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtNgayChieu);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Location = new System.Drawing.Point(12, 206);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(368, 84);
            this.panel10.TabIndex = 9;
            // 
            // txtNgayChieu
            // 
            this.txtNgayChieu.BackColor = System.Drawing.Color.White;
            this.txtNgayChieu.Enabled = false;
            this.txtNgayChieu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayChieu.Location = new System.Drawing.Point(10, 39);
            this.txtNgayChieu.Name = "txtNgayChieu";
            this.txtNgayChieu.Size = new System.Drawing.Size(345, 35);
            this.txtNgayChieu.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày chiếu";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label10);
            this.panel14.Controls.Add(this.txtTenPhim);
            this.panel14.Location = new System.Drawing.Point(12, 12);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(368, 84);
            this.panel14.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phim";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.White;
            this.txtTenPhim.Enabled = false;
            this.txtTenPhim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhim.Location = new System.Drawing.Point(10, 39);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(345, 35);
            this.txtTenPhim.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtGhe);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(12, 400);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 84);
            this.panel5.TabIndex = 10;
            // 
            // txtGhe
            // 
            this.txtGhe.BackColor = System.Drawing.Color.White;
            this.txtGhe.Enabled = false;
            this.txtGhe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhe.Location = new System.Drawing.Point(10, 39);
            this.txtGhe.Name = "txtGhe";
            this.txtGhe.Size = new System.Drawing.Size(345, 35);
            this.txtGhe.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ghế";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtGio);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(12, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 84);
            this.panel4.TabIndex = 9;
            // 
            // txtGio
            // 
            this.txtGio.BackColor = System.Drawing.Color.White;
            this.txtGio.Enabled = false;
            this.txtGio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGio.Location = new System.Drawing.Point(10, 39);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(345, 35);
            this.txtGio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suất chiếu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPhong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 84);
            this.panel2.TabIndex = 8;
            // 
            // txtPhong
            // 
            this.txtPhong.BackColor = System.Drawing.Color.White;
            this.txtPhong.Enabled = false;
            this.txtPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(10, 39);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(345, 35);
            this.txtPhong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng chiếu";
            // 
            // flpGhe
            // 
            this.flpGhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGhe.Location = new System.Drawing.Point(0, 71);
            this.flpGhe.Name = "flpGhe";
            this.flpGhe.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.flpGhe.Size = new System.Drawing.Size(886, 585);
            this.flpGhe.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel17);
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Controls.Add(this.panel12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 656);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(886, 88);
            this.panel8.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.button2);
            this.panel11.Location = new System.Drawing.Point(714, 20);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(116, 40);
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
            this.label7.Text = "Đã dặt";
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
            // panel17
            // 
            this.panel17.Controls.Add(this.label13);
            this.panel17.Controls.Add(this.button8);
            this.panel17.Location = new System.Drawing.Point(396, 20);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(124, 40);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(538, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(157, 40);
            this.panel6.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đang chọn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label9);
            this.panel13.Controls.Add(this.button4);
            this.panel13.Location = new System.Drawing.Point(78, 20);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(170, 40);
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
            // panel12
            // 
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.button3);
            this.panel12.Location = new System.Drawing.Point(257, 20);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(128, 40);
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
            // panel7
            // 
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(886, 71);
            this.panel7.TabIndex = 2;
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
            // frmChonGhe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.flpGhe);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "frmChonGhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn ghế";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChonGhe_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpGhe;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtNgayChieu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTiepTuc;
    }
}