namespace Phan_Mem_Quan_Ly.View
{
    partial class frmThongKe
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
            this.chtDoanhThuSanPham = new DevExpress.XtraCharts.ChartControl();
            this.chtDoanhThuThang = new DevExpress.XtraCharts.ChartControl();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuThang)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtDoanhThuSanPham
            // 
            this.chtDoanhThuSanPham.Location = new System.Drawing.Point(41, 20);
            this.chtDoanhThuSanPham.Name = "chtDoanhThuSanPham";
            this.chtDoanhThuSanPham.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chtDoanhThuSanPham.Size = new System.Drawing.Size(732, 427);
            this.chtDoanhThuSanPham.TabIndex = 0;
            // 
            // chtDoanhThuThang
            // 
            this.chtDoanhThuThang.Location = new System.Drawing.Point(819, 20);
            this.chtDoanhThuThang.Name = "chtDoanhThuThang";
            this.chtDoanhThuThang.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chtDoanhThuThang.Size = new System.Drawing.Size(736, 427);
            this.chtDoanhThuThang.TabIndex = 1;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(394, 537);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(360, 178);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(28, 17);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(300, 40);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Doanh Thu Trong Ngày";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1596, 955);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.chtDoanhThuSanPham);
            this.Controls.Add(this.chtDoanhThuThang);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuThang)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chtDoanhThuSanPham;
        private DevExpress.XtraCharts.ChartControl chtDoanhThuThang;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}