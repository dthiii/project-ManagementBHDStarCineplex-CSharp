using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.KhachHang
{
    partial class frmThemkhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemkhachhang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtHoKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdoKhac = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDiemTichLuy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cboBacThanhVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(32, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 55);
            this.panel1.TabIndex = 0;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.White;
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(201, 9);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(294, 35);
            this.txtMaKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTenKH);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(691, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 55);
            this.panel3.TabIndex = 2;
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.White;
            this.txtTenKH.Location = new System.Drawing.Point(201, 9);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(294, 35);
            this.txtTenKH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên khách hàng:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtHoKH);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(32, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 55);
            this.panel4.TabIndex = 1;
            // 
            // txtHoKH
            // 
            this.txtHoKH.BackColor = System.Drawing.Color.White;
            this.txtHoKH.Location = new System.Drawing.Point(201, 9);
            this.txtHoKH.Name = "txtHoKH";
            this.txtHoKH.Size = new System.Drawing.Size(294, 35);
            this.txtHoKH.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ khách hàng:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpNgaySinh);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(691, 193);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(512, 55);
            this.panel6.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(201, 9);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(294, 35);
            this.dtpNgaySinh.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rdoKhac);
            this.panel5.Controls.Add(this.rdoNu);
            this.panel5.Controls.Add(this.rdoNam);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(32, 193);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(512, 55);
            this.panel5.TabIndex = 3;
            // 
            // rdoKhac
            // 
            this.rdoKhac.AutoSize = true;
            this.rdoKhac.Location = new System.Drawing.Point(366, 9);
            this.rdoKhac.Name = "rdoKhac";
            this.rdoKhac.Size = new System.Drawing.Size(83, 34);
            this.rdoKhac.TabIndex = 3;
            this.rdoKhac.Text = "Khác";
            this.rdoKhac.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(291, 9);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(66, 34);
            this.rdoNu.TabIndex = 2;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(201, 9);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(83, 34);
            this.rdoNam.TabIndex = 1;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDiemTichLuy);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(691, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 55);
            this.panel2.TabIndex = 6;
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.BackColor = System.Drawing.Color.White;
            this.txtDiemTichLuy.Location = new System.Drawing.Point(201, 9);
            this.txtDiemTichLuy.Name = "txtDiemTichLuy";
            this.txtDiemTichLuy.Size = new System.Drawing.Size(294, 35);
            this.txtDiemTichLuy.TabIndex = 1;
            this.txtDiemTichLuy.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điểm tích lũy:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cboBacThanhVien);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(691, 275);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(512, 55);
            this.panel7.TabIndex = 5;
            // 
            // cboBacThanhVien
            // 
            this.cboBacThanhVien.BackColor = System.Drawing.Color.White;
            this.cboBacThanhVien.FormattingEnabled = true;
            this.cboBacThanhVien.Location = new System.Drawing.Point(201, 9);
            this.cboBacThanhVien.Name = "cboBacThanhVien";
            this.cboBacThanhVien.Size = new System.Drawing.Size(294, 36);
            this.cboBacThanhVien.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bậc thành viên:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtDienThoai);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(32, 275);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(512, 55);
            this.panel8.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.Color.White;
            this.txtDienThoai.Location = new System.Drawing.Point(201, 9);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(294, 35);
            this.txtDienThoai.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điện thoại:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtEmail);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(32, 358);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(512, 55);
            this.panel9.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(201, 9);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 35);
            this.txtEmail.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtDiaChi);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(32, 441);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(512, 236);
            this.panel10.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.Location = new System.Drawing.Point(12, 50);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(483, 172);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Địa chỉ:";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1030, 638);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(183, 50);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1030, 638);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(183, 50);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmThemkhachhang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "frmThemkhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khách hàng mới";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtHoKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdoKhac;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboBacThanhVien;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
    }
}