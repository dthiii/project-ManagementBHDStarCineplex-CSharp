using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin.TheLoai
{
    partial class frmTheloai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDSPhim = new System.Windows.Forms.DataGridView();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(53, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(52, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thể loại";
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Enabled = false;
            this.txtMaTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaTheLoai.Location = new System.Drawing.Point(206, 85);
            this.txtMaTheLoai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(453, 34);
            this.txtMaTheLoai.TabIndex = 2;
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenTheLoai.Location = new System.Drawing.Point(205, 165);
            this.txtTenTheLoai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(454, 34);
            this.txtTenTheLoai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "THỂ LOẠI";
            // 
            // dgvDSPhim
            // 
            this.dgvDSPhim.AllowUserToResizeColumns = false;
            this.dgvDSPhim.AllowUserToResizeRows = false;
            this.dgvDSPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSPhim.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSPhim.ColumnHeadersHeight = 50;
            this.dgvDSPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDSPhim.GridColor = System.Drawing.Color.Silver;
            this.dgvDSPhim.Location = new System.Drawing.Point(28, 418);
            this.dgvDSPhim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDSPhim.Name = "dgvDSPhim";
            this.dgvDSPhim.ReadOnly = true;
            this.dgvDSPhim.RowHeadersVisible = false;
            this.dgvDSPhim.RowHeadersWidth = 50;
            this.dgvDSPhim.Size = new System.Drawing.Size(1034, 81);
            this.dgvDSPhim.TabIndex = 10;
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AllowUserToResizeColumns = false;
            this.dgvTheLoai.AllowUserToResizeRows = false;
            this.dgvTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTheLoai.BackgroundColor = System.Drawing.Color.White;
            this.dgvTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTheLoai.ColumnHeadersHeight = 50;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTheLoai.GridColor = System.Drawing.Color.Silver;
            this.dgvTheLoai.Location = new System.Drawing.Point(688, 57);
            this.dgvTheLoai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.ReadOnly = true;
            this.dgvTheLoai.RowHeadersVisible = false;
            this.dgvTheLoai.RowHeadersWidth = 50;
            this.dgvTheLoai.Size = new System.Drawing.Size(276, 300);
            this.dgvTheLoai.TabIndex = 11;
            this.dgvTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 364);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "DANH PHIM THEO THỂ LOẠI";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(51, 248);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 55);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(267, 248);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 55);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(478, 248);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 55);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(478, 248);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(180, 55);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThemmoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.ForeColor = System.Drawing.Color.White;
            this.btnThemmoi.Location = new System.Drawing.Point(267, 248);
            this.btnThemmoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(180, 55);
            this.btnThemmoi.TabIndex = 16;
            this.btnThemmoi.Text = "Thêm";
            this.btnThemmoi.UseVisualStyleBackColor = false;
            this.btnThemmoi.Visible = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Image = global::qlPhim.Properties.Resources.xls1;
            this.btnExcel.Location = new System.Drawing.Point(990, 103);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(67, 55);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::qlPhim.Properties.Resources.printer1;
            this.btnPrint.Location = new System.Drawing.Point(990, 42);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(67, 55);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmTheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 519);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTheLoai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDSPhim);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTenTheLoai);
            this.Controls.Add(this.txtMaTheLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTheloai";
            this.Text = "frmTheloai";
            this.Load += new System.EventHandler(this.frmTheloai_Load);
            this.SizeChanged += new System.EventHandler(this.frmTheloai_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaTheLoai;
        private TextBox txtTenTheLoai;
        private Button btnPrint;
        private Button btnExcel;
        private Label label3;
        private DataGridView dgvDSPhim;
        private DataGridView dgvTheLoai;
        private Label label4;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnThemmoi;
    }
}