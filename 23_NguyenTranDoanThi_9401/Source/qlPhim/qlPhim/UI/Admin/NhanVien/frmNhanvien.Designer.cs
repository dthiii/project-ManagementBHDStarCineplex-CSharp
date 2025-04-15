using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.NhanVien
{
    partial class frmNhanvien
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTatca = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.rdoTenNV = new System.Windows.Forms.RadioButton();
            this.rdoMaNV = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToResizeColumns = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.ColumnHeadersHeight = 50;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.GridColor = System.Drawing.Color.Silver;
            this.dgvNhanVien.Location = new System.Drawing.Point(26, 174);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 70;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.RowTemplate.ReadOnly = true;
            this.dgvNhanVien.Size = new System.Drawing.Size(1074, 330);
            this.dgvNhanVien.TabIndex = 16;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellDoubleClick);
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
            this.btnThem.Size = new System.Drawing.Size(212, 60);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTatca);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.rdoTenNV);
            this.groupBox1.Controls.Add(this.rdoMaNV);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(662, 130);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // btnTatca
            // 
            this.btnTatca.BackColor = System.Drawing.Color.White;
            this.btnTatca.FlatAppearance.BorderSize = 0;
            this.btnTatca.Image = global::qlPhim.Properties.Resources.funnel;
            this.btnTatca.Location = new System.Drawing.Point(598, 81);
            this.btnTatca.Margin = new System.Windows.Forms.Padding(4);
            this.btnTatca.Name = "btnTatca";
            this.btnTatca.Size = new System.Drawing.Size(45, 45);
            this.btnTatca.TabIndex = 9;
            this.btnTatca.UseVisualStyleBackColor = false;
            this.btnTatca.Click += new System.EventHandler(this.btnTatca_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.FlatAppearance.BorderSize = 0;
            this.btnTimkiem.Image = global::qlPhim.Properties.Resources.loupe;
            this.btnTimkiem.Location = new System.Drawing.Point(541, 81);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(45, 45);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // rdoTenNV
            // 
            this.rdoTenNV.AutoSize = true;
            this.rdoTenNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTenNV.Location = new System.Drawing.Point(257, 38);
            this.rdoTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTenNV.Name = "rdoTenNV";
            this.rdoTenNV.Size = new System.Drawing.Size(167, 34);
            this.rdoTenNV.TabIndex = 1;
            this.rdoTenNV.Text = "Tên nhân viên";
            this.rdoTenNV.UseVisualStyleBackColor = true;
            // 
            // rdoMaNV
            // 
            this.rdoMaNV.AutoSize = true;
            this.rdoMaNV.Checked = true;
            this.rdoMaNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaNV.Location = new System.Drawing.Point(34, 38);
            this.rdoMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMaNV.Name = "rdoMaNV";
            this.rdoMaNV.Size = new System.Drawing.Size(165, 34);
            this.rdoMaNV.TabIndex = 0;
            this.rdoMaNV.TabStop = true;
            this.rdoMaNV.Text = "Mã nhân viên";
            this.rdoMaNV.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(20, 86);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(513, 35);
            this.txtTimkiem.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Image = global::qlPhim.Properties.Resources.printer1;
            this.btnPrint.Location = new System.Drawing.Point(739, 98);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 55);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.Image = global::qlPhim.Properties.Resources.xls1;
            this.btnExcel.Location = new System.Drawing.Point(813, 98);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(67, 55);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanvien";
            this.Text = "fEmployee";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            this.SizeChanged += new System.EventHandler(this.frmNhanvien_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTatca;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.RadioButton rdoTenNV;
        private System.Windows.Forms.RadioButton rdoMaNV;
        private System.Windows.Forms.TextBox txtTimkiem;
    }
}