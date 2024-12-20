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
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuThang)).BeginInit();
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
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1596, 955);
            this.Controls.Add(this.chtDoanhThuThang);
            this.Controls.Add(this.chtDoanhThuSanPham);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chtDoanhThuSanPham;
        private DevExpress.XtraCharts.ChartControl chtDoanhThuThang;
    }
}