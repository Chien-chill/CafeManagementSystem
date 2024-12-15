namespace Phan_Mem_Quan_Ly.PartialView
{
    partial class ToastMSS
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
            this.components = new System.ComponentModel.Container();
            this.lblNoiDung = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.timerHide = new System.Windows.Forms.Timer(this.components);
            this.pcbIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = false;
            this.lblNoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.ForeColor = System.Drawing.Color.White;
            this.lblNoiDung.Location = new System.Drawing.Point(128, 12);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(291, 79);
            this.lblNoiDung.TabIndex = 1;
            this.lblNoiDung.Text = "Nội Dung";
            this.lblNoiDung.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerShow
            // 
            this.timerShow.Enabled = true;
            this.timerShow.Interval = 10;
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // timerHide
            // 
            this.timerHide.Interval = 10;
            this.timerHide.Tick += new System.EventHandler(this.timerHide_Tick);
            // 
            // pcbIcon
            // 
            this.pcbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcbIcon.Image = global::Phan_Mem_Quan_Ly.Properties.Resources.icons8_checked_32;
            this.pcbIcon.ImageRotate = 0F;
            this.pcbIcon.Location = new System.Drawing.Point(12, 12);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(91, 79);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcon.TabIndex = 0;
            this.pcbIcon.TabStop = false;
            // 
            // ToastMSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(180)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(431, 103);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.pcbIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastMSS";
            this.Text = "ToastMSS";
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pcbIcon;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoiDung;
        private System.Windows.Forms.Timer timerShow;
        private System.Windows.Forms.Timer timerHide;
    }
}