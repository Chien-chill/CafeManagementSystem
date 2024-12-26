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
            // frmBaoCaoTuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1618, 895);
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
    }
}