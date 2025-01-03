namespace Phan_Mem_Quan_Ly.TabControl
{
    partial class frmBaoCaoTuan
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
            this.chtDoanhThuTuan = new DevExpress.XtraCharts.ChartControl();
            this.dtpNgayTao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnBaoCao = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuTuan)).BeginInit();
            this.SuspendLayout();
            // 
            // chtDoanhThuTuan
            // 
            this.chtDoanhThuTuan.Location = new System.Drawing.Point(29, 254);
            this.chtDoanhThuTuan.Name = "chtDoanhThuTuan";
            this.chtDoanhThuTuan.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chtDoanhThuTuan.Size = new System.Drawing.Size(1561, 641);
            this.chtDoanhThuTuan.TabIndex = 0;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Animated = true;
            this.dtpNgayTao.AutoRoundedCorners = true;
            this.dtpNgayTao.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgayTao.BorderRadius = 29;
            this.dtpNgayTao.Checked = true;
            this.dtpNgayTao.CustomFormat = "";
            this.dtpNgayTao.FillColor = System.Drawing.Color.White;
            this.dtpNgayTao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(29, 47);
            this.dtpNgayTao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(301, 60);
            this.dtpNgayTao.TabIndex = 10;
            this.dtpNgayTao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpNgayTao.Value = new System.DateTime(2025, 1, 3, 14, 19, 2, 0);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaoCao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaoCao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(350, 55);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(180, 45);
            this.btnBaoCao.TabIndex = 11;
            this.btnBaoCao.Text = "Xuất Báo Cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // frmBaoCaoTuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1618, 895);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.dtpNgayTao);
            this.Controls.Add(this.chtDoanhThuTuan);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCaoTuan";
            this.Text = "frmBaoCaoTuan";
            this.Load += new System.EventHandler(this.frmBaoCaoTuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuTuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chtDoanhThuTuan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTao;
        private Guna.UI2.WinForms.Guna2Button btnBaoCao;
    }
}