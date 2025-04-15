using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.Phim.BapNuoc
{
    partial class frmBapnuoc
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
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTaiHinh = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picHinhSP = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.rdoTenSP = new System.Windows.Forms.RadioButton();
            this.rdoGia = new System.Windows.Forms.RadioButton();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtNhapTenSP = new System.Windows.Forms.TextBox();
            this.btnTatca = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToResizeColumns = false;
            this.dgvSanPham.AllowUserToResizeRows = false;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.ColumnHeadersHeight = 50;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanPham.GridColor = System.Drawing.Color.Silver;
            this.dgvSanPham.Location = new System.Drawing.Point(32, 162);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 70;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(617, 718);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnTaiHinh);
            this.panel1.Controls.Add(this.pnlControls);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picHinhSP);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(672, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 718);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboLoaiSP);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(8, 416);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(459, 55);
            this.panel6.TabIndex = 3;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(157, 9);
            this.cboLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(299, 36);
            this.cboLoaiSP.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Loại sản phẩm:";
            // 
            // btnTaiHinh
            // 
            this.btnTaiHinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiHinh.FlatAppearance.BorderSize = 0;
            this.btnTaiHinh.Image = global::qlPhim.Properties.Resources.image;
            this.btnTaiHinh.Location = new System.Drawing.Point(357, 217);
            this.btnTaiHinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaiHinh.Name = "btnTaiHinh";
            this.btnTaiHinh.Size = new System.Drawing.Size(50, 50);
            this.btnTaiHinh.TabIndex = 14;
            this.btnTaiHinh.UseVisualStyleBackColor = true;
            this.btnTaiHinh.Click += new System.EventHandler(this.btnTaiHinh_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnXoa);
            this.pnlControls.Controls.Add(this.btnSua);
            this.pnlControls.Controls.Add(this.btnThem);
            this.pnlControls.Controls.Add(this.btnHuy);
            this.pnlControls.Controls.Add(this.btnThemmoi);
            this.pnlControls.Location = new System.Drawing.Point(4, 621);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(459, 56);
            this.pnlControls.TabIndex = 28;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(309, 4);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 49);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(157, 4);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(146, 49);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(4, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(146, 49);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(309, 3);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(146, 49);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThemmoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(152)))));
            this.btnThemmoi.FlatAppearance.BorderSize = 0;
            this.btnThemmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemmoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.ForeColor = System.Drawing.Color.White;
            this.btnThemmoi.Location = new System.Drawing.Point(156, 3);
            this.btnThemmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(146, 49);
            this.btnThemmoi.TabIndex = 25;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = false;
            this.btnThemmoi.Visible = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSoLuongTon);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(8, 542);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 55);
            this.panel5.TabIndex = 5;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.BackColor = System.Drawing.Color.White;
            this.txtSoLuongTon.Location = new System.Drawing.Point(157, 9);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(299, 35);
            this.txtSoLuongTon.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng tồn:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtGia);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(8, 479);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 55);
            this.panel4.TabIndex = 4;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.Location = new System.Drawing.Point(157, 9);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(299, 35);
            this.txtGia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTenSP);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(8, 353);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 55);
            this.panel3.TabIndex = 2;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.White;
            this.txtTenSP.Location = new System.Drawing.Point(157, 9);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(299, 35);
            this.txtTenSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaSP);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 290);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 55);
            this.panel2.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.White;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(157, 9);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(299, 35);
            this.txtMaSP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // picHinhSP
            // 
            this.picHinhSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHinhSP.Location = new System.Drawing.Point(137, 4);
            this.picHinhSP.Margin = new System.Windows.Forms.Padding(4);
            this.picHinhSP.Name = "picHinhSP";
            this.picHinhSP.Size = new System.Drawing.Size(212, 263);
            this.picHinhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhSP.TabIndex = 0;
            this.picHinhSP.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDen);
            this.groupBox1.Controls.Add(this.rdoTenSP);
            this.groupBox1.Controls.Add(this.rdoGia);
            this.groupBox1.Controls.Add(this.txtTu);
            this.groupBox1.Controls.Add(this.txtNhapTenSP);
            this.groupBox1.Controls.Add(this.btnTatca);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(755, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // txtDen
            // 
            this.txtDen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDen.Location = new System.Drawing.Point(485, 89);
            this.txtDen.Margin = new System.Windows.Forms.Padding(4);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(144, 35);
            this.txtDen.TabIndex = 5;
            // 
            // rdoTenSP
            // 
            this.rdoTenSP.AutoSize = true;
            this.rdoTenSP.Checked = true;
            this.rdoTenSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTenSP.Location = new System.Drawing.Point(34, 38);
            this.rdoTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTenSP.Name = "rdoTenSP";
            this.rdoTenSP.Size = new System.Drawing.Size(167, 34);
            this.rdoTenSP.TabIndex = 1;
            this.rdoTenSP.TabStop = true;
            this.rdoTenSP.Text = "Tên sản phẩm";
            this.rdoTenSP.UseVisualStyleBackColor = true;
            // 
            // rdoGia
            // 
            this.rdoGia.AutoSize = true;
            this.rdoGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGia.Location = new System.Drawing.Point(34, 87);
            this.rdoGia.Margin = new System.Windows.Forms.Padding(4);
            this.rdoGia.Name = "rdoGia";
            this.rdoGia.Size = new System.Drawing.Size(109, 34);
            this.rdoGia.TabIndex = 3;
            this.rdoGia.Text = "Giá bán";
            this.rdoGia.UseVisualStyleBackColor = true;
            this.rdoGia.TextChanged += new System.EventHandler(this.rdoGia_CheckedChanged);
            // 
            // txtTu
            // 
            this.txtTu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTu.Location = new System.Drawing.Point(266, 86);
            this.txtTu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(144, 35);
            this.txtTu.TabIndex = 4;
            // 
            // txtNhapTenSP
            // 
            this.txtNhapTenSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTenSP.Location = new System.Drawing.Point(209, 36);
            this.txtNhapTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapTenSP.Name = "txtNhapTenSP";
            this.txtNhapTenSP.Size = new System.Drawing.Size(419, 35);
            this.txtNhapTenSP.TabIndex = 2;
            this.txtNhapTenSP.TextChanged += new System.EventHandler(this.rdoTenSP_CheckedChanged);
            // 
            // btnTatca
            // 
            this.btnTatca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTatca.FlatAppearance.BorderSize = 0;
            this.btnTatca.Image = global::qlPhim.Properties.Resources.funnel;
            this.btnTatca.Location = new System.Drawing.Point(701, 84);
            this.btnTatca.Margin = new System.Windows.Forms.Padding(4);
            this.btnTatca.Name = "btnTatca";
            this.btnTatca.Size = new System.Drawing.Size(50, 50);
            this.btnTatca.TabIndex = 7;
            this.btnTatca.UseVisualStyleBackColor = true;
            this.btnTatca.Click += new System.EventHandler(this.btnTatca_Click);
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.Image = global::qlPhim.Properties.Resources.loupe;
            this.btnTim.Location = new System.Drawing.Point(645, 84);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(50, 50);
            this.btnTim.TabIndex = 6;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Từ";
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Image = global::qlPhim.Properties.Resources.printer1;
            this.btnPrint.Location = new System.Drawing.Point(998, 98);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 55);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.Image = global::qlPhim.Properties.Resources.xls1;
            this.btnExcel.Location = new System.Drawing.Point(1072, 98);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(67, 55);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmBapnuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 911);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBapnuoc";
            this.Text = "fProduct";
            this.Load += new System.EventHandler(this.frmBapnuoc_Load);
            this.SizeChanged += new System.EventHandler(this.frmBapnuoc_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picHinhSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTatca;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhapTenSP;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.RadioButton rdoTenSP;
        private System.Windows.Forms.RadioButton rdoGia;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Button btnTaiHinh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private Button btnXoa;
        private Button btnSua;
    }
}