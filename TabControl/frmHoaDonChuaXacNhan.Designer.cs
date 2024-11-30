namespace Phan_Mem_Quan_Ly.TabControl
{
    partial class frmHoaDonChuaXacNhan
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
            this.flpDonHang = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpDonHang
            // 
            this.flpDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.flpDonHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpDonHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.flpDonHang.Location = new System.Drawing.Point(0, 71);
            this.flpDonHang.Name = "flpDonHang";
            this.flpDonHang.Size = new System.Drawing.Size(1618, 824);
            this.flpDonHang.TabIndex = 0;
            // 
            // frmDonHangChuaXacNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1618, 895);
            this.Controls.Add(this.flpDonHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDonHangChuaXacNhan";
            this.Text = "frmDonHangChuaXacNhan";
            this.Load += new System.EventHandler(this.frmDonHangChuaXacNhan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDonHang;
    }
}