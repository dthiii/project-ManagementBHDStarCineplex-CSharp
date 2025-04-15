using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.ThongKe
{
    partial class frmThongke
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMovie = new System.Windows.Forms.TabPage();
            this.btnPBieuDo = new System.Windows.Forms.Button();
            this.btnPPrint = new System.Windows.Forms.Button();
            this.btnPExcel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpPTuNgay = new System.Windows.Forms.DateTimePicker();
            this.rdoPKhoangThoiGian = new System.Windows.Forms.RadioButton();
            this.rdoPTatCa = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPTongVe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDoanhThuPhim = new System.Windows.Forms.TextBox();
            this.dgvTKPhim = new System.Windows.Forms.DataGridView();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.btnSPBieuDo = new System.Windows.Forms.Button();
            this.btnSPPrint = new System.Windows.Forms.Button();
            this.btnSPExcel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSPDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpSPTuNgay = new System.Windows.Forms.DateTimePicker();
            this.rdoSPKhoangThoiGian = new System.Windows.Forms.RadioButton();
            this.rdoSPTatCa = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSoLuongDaBan = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDoanhThuSP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvTKBapnuoc = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabMovie.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKPhim)).BeginInit();
            this.tabProduct.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKBapnuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMovie);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1250, 670);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabMovie
            // 
            this.tabMovie.Controls.Add(this.btnPBieuDo);
            this.tabMovie.Controls.Add(this.btnPPrint);
            this.tabMovie.Controls.Add(this.btnPExcel);
            this.tabMovie.Controls.Add(this.groupBox1);
            this.tabMovie.Controls.Add(this.panel2);
            this.tabMovie.Controls.Add(this.panel1);
            this.tabMovie.Controls.Add(this.dgvTKPhim);
            this.tabMovie.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMovie.Location = new System.Drawing.Point(4, 37);
            this.tabMovie.Margin = new System.Windows.Forms.Padding(4);
            this.tabMovie.Name = "tabMovie";
            this.tabMovie.Padding = new System.Windows.Forms.Padding(4);
            this.tabMovie.Size = new System.Drawing.Size(1242, 629);
            this.tabMovie.TabIndex = 0;
            this.tabMovie.Text = "Phim";
            this.tabMovie.UseVisualStyleBackColor = true;
            // 
            // btnPBieuDo
            // 
            this.btnPBieuDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPBieuDo.FlatAppearance.BorderSize = 0;
            this.btnPBieuDo.Image = global::qlPhim.Properties.Resources.chart;
            this.btnPBieuDo.Location = new System.Drawing.Point(1004, 565);
            this.btnPBieuDo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPBieuDo.Name = "btnPBieuDo";
            this.btnPBieuDo.Size = new System.Drawing.Size(63, 56);
            this.btnPBieuDo.TabIndex = 10;
            this.btnPBieuDo.UseVisualStyleBackColor = true;
            this.btnPBieuDo.Click += new System.EventHandler(this.btnPBieuDo_Click);
            // 
            // btnPPrint
            // 
            this.btnPPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPPrint.FlatAppearance.BorderSize = 0;
            this.btnPPrint.Image = global::qlPhim.Properties.Resources.printer1;
            this.btnPPrint.Location = new System.Drawing.Point(1077, 565);
            this.btnPPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPPrint.Name = "btnPPrint";
            this.btnPPrint.Size = new System.Drawing.Size(63, 56);
            this.btnPPrint.TabIndex = 9;
            this.btnPPrint.UseVisualStyleBackColor = true;
            this.btnPPrint.Click += new System.EventHandler(this.btnPPrint_Click);
            // 
            // btnPExcel
            // 
            this.btnPExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPExcel.FlatAppearance.BorderSize = 0;
            this.btnPExcel.Image = global::qlPhim.Properties.Resources.xls1;
            this.btnPExcel.Location = new System.Drawing.Point(1150, 565);
            this.btnPExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPExcel.Name = "btnPExcel";
            this.btnPExcel.Size = new System.Drawing.Size(63, 56);
            this.btnPExcel.TabIndex = 8;
            this.btnPExcel.UseVisualStyleBackColor = true;
            this.btnPExcel.Click += new System.EventHandler(this.btnPExcel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpPDenNgay);
            this.groupBox1.Controls.Add(this.dtpPTuNgay);
            this.groupBox1.Controls.Add(this.rdoPKhoangThoiGian);
            this.groupBox1.Controls.Add(this.rdoPTatCa);
            this.groupBox1.Location = new System.Drawing.Point(26, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(595, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "đến";
            // 
            // dtpPDenNgay
            // 
            this.dtpPDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPDenNgay.Location = new System.Drawing.Point(305, 86);
            this.dtpPDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPDenNgay.Name = "dtpPDenNgay";
            this.dtpPDenNgay.Size = new System.Drawing.Size(146, 35);
            this.dtpPDenNgay.TabIndex = 3;
            this.dtpPDenNgay.ValueChanged += new System.EventHandler(this.dtpPDenNgay_ValueChanged);
            // 
            // dtpPTuNgay
            // 
            this.dtpPTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPTuNgay.Location = new System.Drawing.Point(90, 86);
            this.dtpPTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPTuNgay.Name = "dtpPTuNgay";
            this.dtpPTuNgay.Size = new System.Drawing.Size(146, 35);
            this.dtpPTuNgay.TabIndex = 2;
            this.dtpPTuNgay.ValueChanged += new System.EventHandler(this.dtpPTuNgay_ValueChanged);
            // 
            // rdoPKhoangThoiGian
            // 
            this.rdoPKhoangThoiGian.AutoSize = true;
            this.rdoPKhoangThoiGian.Location = new System.Drawing.Point(20, 89);
            this.rdoPKhoangThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPKhoangThoiGian.Name = "rdoPKhoangThoiGian";
            this.rdoPKhoangThoiGian.Size = new System.Drawing.Size(61, 34);
            this.rdoPKhoangThoiGian.TabIndex = 1;
            this.rdoPKhoangThoiGian.Text = "Từ";
            this.rdoPKhoangThoiGian.UseVisualStyleBackColor = true;
            this.rdoPKhoangThoiGian.CheckedChanged += new System.EventHandler(this.rdoPKhoangThoiGian_CheckedChanged);
            // 
            // rdoPTatCa
            // 
            this.rdoPTatCa.AutoSize = true;
            this.rdoPTatCa.Checked = true;
            this.rdoPTatCa.Location = new System.Drawing.Point(20, 38);
            this.rdoPTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPTatCa.Name = "rdoPTatCa";
            this.rdoPTatCa.Size = new System.Drawing.Size(196, 34);
            this.rdoPTatCa.TabIndex = 0;
            this.rdoPTatCa.TabStop = true;
            this.rdoPTatCa.Text = "Từ trước đến nay";
            this.rdoPTatCa.UseVisualStyleBackColor = true;
            this.rdoPTatCa.CheckedChanged += new System.EventHandler(this.rdoPTatCa_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.txtPTongVe);
            this.panel2.Location = new System.Drawing.Point(742, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 125);
            this.panel2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(18, 16);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(189, 29);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Tổng số vé đã bán";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPTongVe
            // 
            this.txtPTongVe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPTongVe.BackColor = System.Drawing.Color.White;
            this.txtPTongVe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPTongVe.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTongVe.Location = new System.Drawing.Point(18, 64);
            this.txtPTongVe.Margin = new System.Windows.Forms.Padding(4);
            this.txtPTongVe.Name = "txtPTongVe";
            this.txtPTongVe.ReadOnly = true;
            this.txtPTongVe.Size = new System.Drawing.Size(189, 36);
            this.txtPTongVe.TabIndex = 3;
            this.txtPTongVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtDoanhThuPhim);
            this.panel1.Location = new System.Drawing.Point(988, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 125);
            this.panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(18, 16);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(189, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Tổng doanh thu";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoanhThuPhim
            // 
            this.txtDoanhThuPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoanhThuPhim.BackColor = System.Drawing.Color.White;
            this.txtDoanhThuPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoanhThuPhim.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThuPhim.Location = new System.Drawing.Point(18, 64);
            this.txtDoanhThuPhim.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoanhThuPhim.Name = "txtDoanhThuPhim";
            this.txtDoanhThuPhim.ReadOnly = true;
            this.txtDoanhThuPhim.Size = new System.Drawing.Size(189, 36);
            this.txtDoanhThuPhim.TabIndex = 3;
            this.txtDoanhThuPhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvTKPhim
            // 
            this.dgvTKPhim.AllowUserToResizeColumns = false;
            this.dgvTKPhim.AllowUserToResizeRows = false;
            this.dgvTKPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTKPhim.ColumnHeadersHeight = 50;
            this.dgvTKPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTKPhim.Location = new System.Drawing.Point(26, 177);
            this.dgvTKPhim.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTKPhim.Name = "dgvTKPhim";
            this.dgvTKPhim.ReadOnly = true;
            this.dgvTKPhim.RowHeadersVisible = false;
            this.dgvTKPhim.RowHeadersWidth = 50;
            this.dgvTKPhim.RowTemplate.Height = 24;
            this.dgvTKPhim.Size = new System.Drawing.Size(1187, 374);
            this.dgvTKPhim.TabIndex = 0;
            this.dgvTKPhim.DataSourceChanged += new System.EventHandler(this.dgvTKPhim_DataSourceChanged);
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.btnSPBieuDo);
            this.tabProduct.Controls.Add(this.btnSPPrint);
            this.tabProduct.Controls.Add(this.btnSPExcel);
            this.tabProduct.Controls.Add(this.groupBox2);
            this.tabProduct.Controls.Add(this.panel4);
            this.tabProduct.Controls.Add(this.panel3);
            this.tabProduct.Controls.Add(this.dgvTKBapnuoc);
            this.tabProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProduct.Location = new System.Drawing.Point(4, 37);
            this.tabProduct.Margin = new System.Windows.Forms.Padding(4);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(4);
            this.tabProduct.Size = new System.Drawing.Size(1242, 629);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Bắp nước";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // btnSPBieuDo
            // 
            this.btnSPBieuDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSPBieuDo.BackColor = System.Drawing.Color.White;
            this.btnSPBieuDo.FlatAppearance.BorderSize = 0;
            this.btnSPBieuDo.Image = global::qlPhim.Properties.Resources.chart;
            this.btnSPBieuDo.Location = new System.Drawing.Point(1004, 565);
            this.btnSPBieuDo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSPBieuDo.Name = "btnSPBieuDo";
            this.btnSPBieuDo.Size = new System.Drawing.Size(63, 56);
            this.btnSPBieuDo.TabIndex = 10;
            this.btnSPBieuDo.UseVisualStyleBackColor = false;
            this.btnSPBieuDo.Click += new System.EventHandler(this.btnSPBieuDo_Click);
            // 
            // btnSPPrint
            // 
            this.btnSPPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSPPrint.BackColor = System.Drawing.Color.White;
            this.btnSPPrint.FlatAppearance.BorderSize = 0;
            this.btnSPPrint.Image = global::qlPhim.Properties.Resources.printer1;
            this.btnSPPrint.Location = new System.Drawing.Point(1077, 565);
            this.btnSPPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnSPPrint.Name = "btnSPPrint";
            this.btnSPPrint.Size = new System.Drawing.Size(63, 56);
            this.btnSPPrint.TabIndex = 9;
            this.btnSPPrint.UseVisualStyleBackColor = false;
            this.btnSPPrint.Click += new System.EventHandler(this.btnSPPrint_Click);
            // 
            // btnSPExcel
            // 
            this.btnSPExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSPExcel.BackColor = System.Drawing.Color.White;
            this.btnSPExcel.FlatAppearance.BorderSize = 0;
            this.btnSPExcel.Image = global::qlPhim.Properties.Resources.xls1;
            this.btnSPExcel.Location = new System.Drawing.Point(1150, 565);
            this.btnSPExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnSPExcel.Name = "btnSPExcel";
            this.btnSPExcel.Size = new System.Drawing.Size(63, 56);
            this.btnSPExcel.TabIndex = 8;
            this.btnSPExcel.UseVisualStyleBackColor = false;
            this.btnSPExcel.Click += new System.EventHandler(this.btnSPExcel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpSPDenNgay);
            this.groupBox2.Controls.Add(this.dtpSPTuNgay);
            this.groupBox2.Controls.Add(this.rdoSPKhoangThoiGian);
            this.groupBox2.Controls.Add(this.rdoSPTatCa);
            this.groupBox2.Location = new System.Drawing.Point(26, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(518, 147);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "đến";
            // 
            // dtpSPDenNgay
            // 
            this.dtpSPDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSPDenNgay.Location = new System.Drawing.Point(305, 86);
            this.dtpSPDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSPDenNgay.Name = "dtpSPDenNgay";
            this.dtpSPDenNgay.Size = new System.Drawing.Size(146, 35);
            this.dtpSPDenNgay.TabIndex = 3;
            this.dtpSPDenNgay.ValueChanged += new System.EventHandler(this.dtpSPDenNgay_ValueChanged);
            // 
            // dtpSPTuNgay
            // 
            this.dtpSPTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSPTuNgay.Location = new System.Drawing.Point(90, 86);
            this.dtpSPTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSPTuNgay.Name = "dtpSPTuNgay";
            this.dtpSPTuNgay.Size = new System.Drawing.Size(146, 35);
            this.dtpSPTuNgay.TabIndex = 2;
            this.dtpSPTuNgay.ValueChanged += new System.EventHandler(this.dtpSPTuNgay_ValueChanged);
            // 
            // rdoSPKhoangThoiGian
            // 
            this.rdoSPKhoangThoiGian.AutoSize = true;
            this.rdoSPKhoangThoiGian.Location = new System.Drawing.Point(20, 89);
            this.rdoSPKhoangThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSPKhoangThoiGian.Name = "rdoSPKhoangThoiGian";
            this.rdoSPKhoangThoiGian.Size = new System.Drawing.Size(61, 34);
            this.rdoSPKhoangThoiGian.TabIndex = 1;
            this.rdoSPKhoangThoiGian.Text = "Từ";
            this.rdoSPKhoangThoiGian.UseVisualStyleBackColor = true;
            this.rdoSPKhoangThoiGian.CheckedChanged += new System.EventHandler(this.rdoSPKhoangThoiGian_CheckedChanged);
            // 
            // rdoSPTatCa
            // 
            this.rdoSPTatCa.AutoSize = true;
            this.rdoSPTatCa.Checked = true;
            this.rdoSPTatCa.Location = new System.Drawing.Point(20, 38);
            this.rdoSPTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSPTatCa.Name = "rdoSPTatCa";
            this.rdoSPTatCa.Size = new System.Drawing.Size(196, 34);
            this.rdoSPTatCa.TabIndex = 0;
            this.rdoSPTatCa.TabStop = true;
            this.rdoSPTatCa.Text = "Từ trước đến nay";
            this.rdoSPTatCa.UseVisualStyleBackColor = true;
            this.rdoSPTatCa.CheckedChanged += new System.EventHandler(this.rdoSPTatCa_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.panel4.Controls.Add(this.txtSoLuongDaBan);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Location = new System.Drawing.Point(742, 30);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 125);
            this.panel4.TabIndex = 3;
            // 
            // txtSoLuongDaBan
            // 
            this.txtSoLuongDaBan.BackColor = System.Drawing.Color.White;
            this.txtSoLuongDaBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuongDaBan.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongDaBan.Location = new System.Drawing.Point(18, 64);
            this.txtSoLuongDaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongDaBan.Name = "txtSoLuongDaBan";
            this.txtSoLuongDaBan.ReadOnly = true;
            this.txtSoLuongDaBan.Size = new System.Drawing.Size(189, 36);
            this.txtSoLuongDaBan.TabIndex = 1;
            this.txtSoLuongDaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(18, 16);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(189, 29);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "Số lượng đã bán";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.panel3.Controls.Add(this.txtDoanhThuSP);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(988, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 125);
            this.panel3.TabIndex = 2;
            // 
            // txtDoanhThuSP
            // 
            this.txtDoanhThuSP.BackColor = System.Drawing.Color.White;
            this.txtDoanhThuSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoanhThuSP.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThuSP.Location = new System.Drawing.Point(18, 64);
            this.txtDoanhThuSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoanhThuSP.Name = "txtDoanhThuSP";
            this.txtDoanhThuSP.ReadOnly = true;
            this.txtDoanhThuSP.Size = new System.Drawing.Size(189, 36);
            this.txtDoanhThuSP.TabIndex = 1;
            this.txtDoanhThuSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(220)))), ((int)(((byte)(165)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(189, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tổng doanh thu";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvTKBapnuoc
            // 
            this.dgvTKBapnuoc.AllowUserToResizeColumns = false;
            this.dgvTKBapnuoc.AllowUserToResizeRows = false;
            this.dgvTKBapnuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKBapnuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTKBapnuoc.ColumnHeadersHeight = 50;
            this.dgvTKBapnuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTKBapnuoc.Location = new System.Drawing.Point(26, 177);
            this.dgvTKBapnuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTKBapnuoc.Name = "dgvTKBapnuoc";
            this.dgvTKBapnuoc.ReadOnly = true;
            this.dgvTKBapnuoc.RowHeadersVisible = false;
            this.dgvTKBapnuoc.RowHeadersWidth = 50;
            this.dgvTKBapnuoc.RowTemplate.Height = 24;
            this.dgvTKBapnuoc.Size = new System.Drawing.Size(1187, 374);
            this.dgvTKBapnuoc.TabIndex = 1;
            this.dgvTKBapnuoc.DataSourceChanged += new System.EventHandler(this.dgvTKBapnuoc_DataSourceChanged);
            // 
            // frmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 670);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongke";
            this.Text = "fStatistic";
            this.Load += new System.EventHandler(this.frmThongke_Load);
            this.SizeChanged += new System.EventHandler(this.frmThongke_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabMovie.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKPhim)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKBapnuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMovie;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.DataGridView dgvTKPhim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtDoanhThuPhim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPTongVe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPKhoangThoiGian;
        private System.Windows.Forms.RadioButton rdoPTatCa;
        private System.Windows.Forms.DateTimePicker dtpPTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPDenNgay;
        private System.Windows.Forms.DataGridView dgvTKBapnuoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDoanhThuSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSoLuongDaBan;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSPTatCa;
        private System.Windows.Forms.RadioButton rdoSPKhoangThoiGian;
        private System.Windows.Forms.DateTimePicker dtpSPTuNgay;
        private System.Windows.Forms.DateTimePicker dtpSPDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPPrint;
        private System.Windows.Forms.Button btnPExcel;
        private System.Windows.Forms.Button btnPBieuDo;
        private System.Windows.Forms.Button btnSPPrint;
        private System.Windows.Forms.Button btnSPExcel;
        private System.Windows.Forms.Button btnSPBieuDo;
    }
}