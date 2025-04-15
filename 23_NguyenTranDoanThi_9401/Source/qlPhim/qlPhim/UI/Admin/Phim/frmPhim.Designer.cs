using System.Drawing;
using System.Windows.Forms;

namespace qlPhim.UI.Admin
{
    partial class frmPhim
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
            this.btnTatcaphim = new System.Windows.Forms.Button();
            this.btnTimphim = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.rdbMaphim = new System.Windows.Forms.RadioButton();
            this.rdbTenphim = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPhim = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTatcaphim);
            this.groupBox1.Controls.Add(this.btnTimphim);
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Controls.Add(this.rdbMaphim);
            this.groupBox1.Controls.Add(this.rdbTenphim);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(564, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTatcaphim
            // 
            this.btnTatcaphim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTatcaphim.BackColor = System.Drawing.Color.White;
            this.btnTatcaphim.Image = global::qlPhim.Properties.Resources.funnel;
            this.btnTatcaphim.Location = new System.Drawing.Point(501, 54);
            this.btnTatcaphim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTatcaphim.Name = "btnTatcaphim";
            this.btnTatcaphim.Size = new System.Drawing.Size(55, 55);
            this.btnTatcaphim.TabIndex = 4;
            this.btnTatcaphim.UseVisualStyleBackColor = false;
            this.btnTatcaphim.Click += new System.EventHandler(this.btnTatcaphim_Click);
            // 
            // btnTimphim
            // 
            this.btnTimphim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimphim.BackColor = System.Drawing.Color.White;
            this.btnTimphim.Image = global::qlPhim.Properties.Resources.loupe;
            this.btnTimphim.Location = new System.Drawing.Point(444, 54);
            this.btnTimphim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimphim.Name = "btnTimphim";
            this.btnTimphim.Size = new System.Drawing.Size(55, 55);
            this.btnTimphim.TabIndex = 3;
            this.btnTimphim.UseVisualStyleBackColor = false;
            this.btnTimphim.Click += new System.EventHandler(this.btnTimphim_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhap.Location = new System.Drawing.Point(21, 68);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(415, 34);
            this.txtNhap.TabIndex = 2;
            // 
            // rdbMaphim
            // 
            this.rdbMaphim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbMaphim.AutoSize = true;
            this.rdbMaphim.Location = new System.Drawing.Point(244, 31);
            this.rdbMaphim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbMaphim.Name = "rdbMaphim";
            this.rdbMaphim.Size = new System.Drawing.Size(115, 32);
            this.rdbMaphim.TabIndex = 1;
            this.rdbMaphim.TabStop = true;
            this.rdbMaphim.Text = "Mã phim";
            this.rdbMaphim.UseVisualStyleBackColor = true;
            // 
            // rdbTenphim
            // 
            this.rdbTenphim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbTenphim.AutoSize = true;
            this.rdbTenphim.Location = new System.Drawing.Point(21, 28);
            this.rdbTenphim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbTenphim.Name = "rdbTenphim";
            this.rdbTenphim.Size = new System.Drawing.Size(115, 32);
            this.rdbTenphim.TabIndex = 0;
            this.rdbTenphim.TabStop = true;
            this.rdbTenphim.Text = "Tên Phim";
            this.rdbTenphim.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(190)))), ((int)(((byte)(67)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(773, 66);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(210, 59);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvPhim
            // 
            this.dgvPhim.AllowUserToResizeColumns = false;
            this.dgvPhim.AllowUserToResizeRows = false;
            this.dgvPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhim.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhim.ColumnHeadersHeight = 50;
            this.dgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhim.GridColor = System.Drawing.Color.Silver;
            this.dgvPhim.Location = new System.Drawing.Point(18, 166);
            this.dgvPhim.Name = "dgvPhim";
            this.dgvPhim.ReadOnly = true;
            this.dgvPhim.RowHeadersVisible = false;
            this.dgvPhim.RowHeadersWidth = 50;
            this.dgvPhim.RowTemplate.Height = 24;
            this.dgvPhim.RowTemplate.ReadOnly = true;
            this.dgvPhim.Size = new System.Drawing.Size(965, 374);
            this.dgvPhim.TabIndex = 0;
            this.dgvPhim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellContentClick);
            this.dgvPhim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhim_CellDoubleClick);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Image = global::qlPhim.Properties.Resources.xls1;
            this.btnExcel.Location = new System.Drawing.Point(687, 68);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(74, 59);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::qlPhim.Properties.Resources.printer1;
            this.btnPrint.Location = new System.Drawing.Point(603, 67);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(74, 59);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.dgvPhim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPhim";
            this.Text = "frmPhim";
            this.Load += new System.EventHandler(this.frmPhim_Load);
            this.SizeChanged += new System.EventHandler(this.frmPhim_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton rdbMaphim;
        private RadioButton rdbTenphim;
        private Button btnTimphim;
        private TextBox txtNhap;
        private Button btnTatcaphim;
        private Button btnPrint;
        private Button btnExcel;
        private Button btnThem;
        private DataGridView dgvPhim;
    }
}