namespace Phan_Mem_Quan_Ly.TabControl
{
    partial class frmThongKeSP
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // chtDoanhThuSanPham
            // 
            this.chtDoanhThuSanPham.Location = new System.Drawing.Point(26, 19);
            this.chtDoanhThuSanPham.Name = "chtDoanhThuSanPham";
            this.chtDoanhThuSanPham.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chtDoanhThuSanPham.Size = new System.Drawing.Size(800, 800);
            this.chtDoanhThuSanPham.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Location = new System.Drawing.Point(889, 19);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(316, 168);
            this.guna2Panel1.TabIndex = 1;
            // 
            // frmThongKeSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1596, 839);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.chtDoanhThuSanPham);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKeSP";
            this.Text = "frmThongKeSP";
            this.Load += new System.EventHandler(this.frmThongKeSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThuSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chtDoanhThuSanPham;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}