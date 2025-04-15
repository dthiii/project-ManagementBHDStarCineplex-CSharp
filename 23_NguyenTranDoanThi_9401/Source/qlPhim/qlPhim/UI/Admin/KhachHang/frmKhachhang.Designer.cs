using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.Phim
{
    partial class frmKhachhang
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
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBacThanhVien = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnTatca = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(200, 110);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(341, 35);
            this.txtTenKH.TabIndex = 1;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToResizeColumns = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachHang.ColumnHeadersHeight = 50;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhachHang.GridColor = System.Drawing.Color.Silver;
            this.dgvKhachHang.Location = new System.Drawing.Point(26, 180);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 70;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.RowTemplate.ReadOnly = true;
            this.dgvKhachHang.Size = new System.Drawing.Size(1074, 330);
            this.dgvKhachHang.TabIndex = 5;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellDoubleClick);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(887, 98);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(210, 60);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bậc thành viên:";
            // 
            // cboBacThanhVien
            // 
            this.cboBacThanhVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBacThanhVien.FormattingEnabled = true;
            this.cboBacThanhVien.Location = new System.Drawing.Point(200, 39);
            this.cboBacThanhVien.Margin = new System.Windows.Forms.Padding(4);
            this.cboBacThanhVien.Name = "cboBacThanhVien";
            this.cboBacThanhVien.Size = new System.Drawing.Size(254, 36);
            this.cboBacThanhVien.TabIndex = 13;
            this.cboBacThanhVien.SelectedIndexChanged += new System.EventHandler(this.cboBacThanhVien_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Image = global::qlPhim.Properties.Resources.printer1;
            this.btnPrint.Location = new System.Drawing.Point(731, 98);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 55);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnTatca
            // 
            this.btnTatca.BackColor = System.Drawing.Color.White;
            this.btnTatca.FlatAppearance.BorderSize = 0;
            this.btnTatca.Image = global::qlPhim.Properties.Resources.funnel;
            this.btnTatca.Location = new System.Drawing.Point(609, 108);
            this.btnTatca.Margin = new System.Windows.Forms.Padding(4);
            this.btnTatca.Name = "btnTatca";
            this.btnTatca.Size = new System.Drawing.Size(45, 45);
            this.btnTatca.TabIndex = 9;
            this.btnTatca.UseVisualStyleBackColor = false;
            this.btnTatca.Click += new System.EventHandler(this.btnTatca_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.Image = global::qlPhim.Properties.Resources.xls1;
            this.btnExcel.Location = new System.Drawing.Point(805, 98);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(67, 55);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.Image = global::qlPhim.Properties.Resources.loupe;
            this.btnTim.Location = new System.Drawing.Point(559, 108);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(45, 45);
            this.btnTim.TabIndex = 2;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 533);
            this.Controls.Add(this.cboBacThanhVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnTatca);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachhang";
            this.Text = "frmKhachhang";
            this.Load += new System.EventHandler(this.frmKhachhang_Load);
            this.SizeChanged += new System.EventHandler(this.frmKhachhang_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnTatca;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBacThanhVien;
    }
}