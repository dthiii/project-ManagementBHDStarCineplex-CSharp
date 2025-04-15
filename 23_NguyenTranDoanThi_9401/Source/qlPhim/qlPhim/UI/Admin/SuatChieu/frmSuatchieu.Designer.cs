using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.SuatChieu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTatca = new System.Windows.Forms.Button();
            this.btnTimphim = new System.Windows.Forms.Button();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTenPhim = new System.Windows.Forms.ComboBox();
            this.ckGio = new System.Windows.Forms.CheckBox();
            this.ckTenphim = new System.Windows.Forms.CheckBox();
            this.dptNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSuatchieu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatchieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTatca);
            this.groupBox1.Controls.Add(this.btnTimphim);
            this.groupBox1.Controls.Add(this.dtpDen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTenPhim);
            this.groupBox1.Controls.Add(this.ckGio);
            this.groupBox1.Controls.Add(this.ckTenphim);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(638, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // btnTatca
            // 
            this.btnTatca.BackColor = System.Drawing.Color.White;
            this.btnTatca.Image = global::qlPhim.Properties.Resources.funnel;
            this.btnTatca.Location = new System.Drawing.Point(577, 91);
            this.btnTatca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTatca.Name = "btnTatca";
            this.btnTatca.Size = new System.Drawing.Size(45, 45);
            this.btnTatca.TabIndex = 8;
            this.btnTatca.UseVisualStyleBackColor = false;
            this.btnTatca.Click += new System.EventHandler(this.btnTatca_Click);
            // 
            // btnTimphim
            // 
            this.btnTimphim.BackColor = System.Drawing.Color.White;
            this.btnTimphim.Image = global::qlPhim.Properties.Resources.loupe;
            this.btnTimphim.Location = new System.Drawing.Point(524, 91);
            this.btnTimphim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimphim.Name = "btnTimphim";
            this.btnTimphim.Size = new System.Drawing.Size(45, 45);
            this.btnTimphim.TabIndex = 7;
            this.btnTimphim.UseVisualStyleBackColor = false;
            this.btnTimphim.Click += new System.EventHandler(this.btnTimphim_Click);
            // 
            // dtpDen
            // 
            this.dtpDen.CustomFormat = "HH:mm";
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDen.Location = new System.Drawing.Point(390, 101);
            this.dtpDen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.ShowUpDown = true;
            this.dtpDen.Size = new System.Drawing.Size(104, 34);
            this.dtpDen.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "đến";
            // 
            // dtpTu
            // 
            this.dtpTu.CustomFormat = "HH:mm";
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTu.Location = new System.Drawing.Point(189, 101);
            this.dtpTu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.ShowUpDown = true;
            this.dtpTu.Size = new System.Drawing.Size(104, 34);
            this.dtpTu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ";
            // 
            // cboTenPhim
            // 
            this.cboTenPhim.FormattingEnabled = true;
            this.cboTenPhim.Location = new System.Drawing.Point(153, 46);
            this.cboTenPhim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTenPhim.Name = "cboTenPhim";
            this.cboTenPhim.Size = new System.Drawing.Size(341, 36);
            this.cboTenPhim.TabIndex = 2;
            // 
            // ckGio
            // 
            this.ckGio.AutoSize = true;
            this.ckGio.Location = new System.Drawing.Point(19, 101);
            this.ckGio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckGio.Name = "ckGio";
            this.ckGio.Size = new System.Drawing.Size(69, 32);
            this.ckGio.TabIndex = 1;
            this.ckGio.Text = "Giờ";
            this.ckGio.UseVisualStyleBackColor = true;
            // 
            // ckTenphim
            // 
            this.ckTenphim.AutoSize = true;
            this.ckTenphim.Location = new System.Drawing.Point(19, 48);
            this.ckTenphim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ckTenphim.Name = "ckTenphim";
            this.ckTenphim.Size = new System.Drawing.Size(117, 32);
            this.ckTenphim.TabIndex = 0;
            this.ckTenphim.Text = "Tên phim";
            this.ckTenphim.UseVisualStyleBackColor = true;
            // 
            // dptNgay
            // 
            this.dptNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dptNgay.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptNgay.Location = new System.Drawing.Point(865, 33);
            this.dptNgay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dptNgay.Name = "dptNgay";
            this.dptNgay.Size = new System.Drawing.Size(281, 42);
            this.dptNgay.TabIndex = 1;
            this.dptNgay.ValueChanged += new System.EventHandler(this.dptNgay_ValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(908, 97);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(238, 60);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvSuatchieu
            // 
            this.dgvSuatchieu.AllowUserToResizeColumns = false;
            this.dgvSuatchieu.AllowUserToResizeRows = false;
            this.dgvSuatchieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuatchieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuatchieu.ColumnHeadersHeight = 50;
            this.dgvSuatchieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuatchieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuatchieu.GridColor = System.Drawing.Color.Silver;
            this.dgvSuatchieu.Location = new System.Drawing.Point(270, 204);
            this.dgvSuatchieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSuatchieu.Name = "dgvSuatchieu";
            this.dgvSuatchieu.ReadOnly = true;
            this.dgvSuatchieu.RowHeadersVisible = false;
            this.dgvSuatchieu.RowHeadersWidth = 50;
            this.dgvSuatchieu.Size = new System.Drawing.Size(956, 462);
            this.dgvSuatchieu.TabIndex = 9;
            this.dgvSuatchieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellContentClick);
            this.dgvSuatchieu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellDoubleClick);
            this.dgvSuatchieu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhim_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dptNgay);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 204);
            this.panel1.TabIndex = 11;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::qlPhim.Properties.Resources.printer1;
            this.btnPrint.Location = new System.Drawing.Point(761, 97);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 55);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Image = global::qlPhim.Properties.Resources.xls1;
            this.btnExcel.Location = new System.Drawing.Point(834, 97);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(67, 55);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // flpPhong
            // 
            this.flpPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpPhong.Location = new System.Drawing.Point(0, 204);
            this.flpPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(270, 462);
            this.flpPhong.TabIndex = 10;
            // 
            // frmSuatchieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 666);
            this.Controls.Add(this.dgvSuatchieu);
            this.Controls.Add(this.flpPhong);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSuatchieu";
            this.Text = "frmSuatchieu";
            this.Load += new System.EventHandler(this.frmSuatchieu_Load);
            this.SizeChanged += new System.EventHandler(this.frmSuatchieu_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatchieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboTenPhim;
        private CheckBox ckGio;
        private CheckBox ckTenphim;
        private DateTimePicker dtpDen;
        private Label label2;
        private DateTimePicker dtpTu;
        private Label label1;
        private Button btnTatca;
        private Button btnTimphim;
        private DateTimePicker dptNgay;
        private Button btnThem;
        private Button btnExcel;
        private Button btnPrint;
        private DataGridView dgvSuatchieu;
        private Panel panel1;
        private FlowLayoutPanel flpPhong;
    }
}