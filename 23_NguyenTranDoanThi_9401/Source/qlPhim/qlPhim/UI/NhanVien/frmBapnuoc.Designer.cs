using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBapnuoc));
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.picHinhSP = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhSP)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToResizeColumns = false;
            this.dgvSanPham.AllowUserToResizeRows = false;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.ColumnHeadersHeight = 50;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanPham.Location = new System.Drawing.Point(18, 34);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 50;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(770, 573);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboTenSP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(31, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 55);
            this.panel1.TabIndex = 3;
            // 
            // cboTenSP
            // 
            this.cboTenSP.BackColor = System.Drawing.Color.White;
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(180, 9);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(199, 36);
            this.cboTenSP.TabIndex = 1;
            this.cboTenSP.SelectedIndexChanged += new System.EventHandler(this.cboTenSP_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSoLuongTon);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(31, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 55);
            this.panel2.TabIndex = 4;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.BackColor = System.Drawing.Color.White;
            this.txtSoLuongTon.Enabled = false;
            this.txtSoLuongTon.Location = new System.Drawing.Point(180, 9);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(199, 35);
            this.txtSoLuongTon.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng tồn:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtGia);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(31, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 55);
            this.panel3.TabIndex = 5;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(180, 9);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(199, 35);
            this.txtGia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá bán:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.txtSoLuong);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(31, 582);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 55);
            this.panel4.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::qlPhim.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(344, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(35, 35);
            this.btnThem.TabIndex = 24;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.Location = new System.Drawing.Point(180, 9);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(139, 35);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng:";
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTiepTuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnTiepTuc.FlatAppearance.BorderSize = 0;
            this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiepTuc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.ForeColor = System.Drawing.Color.White;
            this.btnTiepTuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiepTuc.Location = new System.Drawing.Point(599, 674);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(189, 55);
            this.btnTiepTuc.TabIndex = 23;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = false;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // picHinhSP
            // 
            this.picHinhSP.BackColor = System.Drawing.SystemColors.Control;
            this.picHinhSP.Location = new System.Drawing.Point(133, 34);
            this.picHinhSP.Name = "picHinhSP";
            this.picHinhSP.Size = new System.Drawing.Size(206, 267);
            this.picHinhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhSP.TabIndex = 2;
            this.picHinhSP.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.txtTongTien);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(469, 613);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 55);
            this.panel5.TabIndex = 6;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(130, 9);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(186, 35);
            this.txtTongTien.TabIndex = 1;
            this.txtTongTien.Text = "0 đ";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng cộng:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.picHinhSP);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(459, 744);
            this.panel6.TabIndex = 24;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.dgvSanPham);
            this.panel7.Controls.Add(this.btnTiepTuc);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(459, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(819, 744);
            this.panel7.TabIndex = 25;
            // 
            // frmBapnuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "frmBapnuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Bắp nước";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBapnuoc_FormClosing);
            this.Load += new System.EventHandler(this.frmBapnuoc_Load);
            this.SizeChanged += new System.EventHandler(this.frmBapnuoc_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhSP)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picHinhSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTenSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvSanPham;
    }
}