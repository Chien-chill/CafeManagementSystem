﻿namespace Phan_Mem_Quan_Ly.PartialView
{
    partial class frmLichSuSuKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuSuKien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pcTieuDe = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTieuDe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Mss = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.dtgDoAn = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.maSKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianBDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lichSuSuKienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcTieuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoAn)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lichSuSuKienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.pcTieuDe);
            this.guna2GradientPanel1.Controls.Add(this.lblTieuDe);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1052, 100);
            this.guna2GradientPanel1.TabIndex = 44;
            // 
            // pcTieuDe
            // 
            this.pcTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.pcTieuDe.FillColor = System.Drawing.Color.Transparent;
            this.pcTieuDe.Image = ((System.Drawing.Image)(resources.GetObject("pcTieuDe.Image")));
            this.pcTieuDe.ImageRotate = 0F;
            this.pcTieuDe.Location = new System.Drawing.Point(12, 12);
            this.pcTieuDe.Name = "pcTieuDe";
            this.pcTieuDe.Size = new System.Drawing.Size(76, 75);
            this.pcTieuDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcTieuDe.TabIndex = 1;
            this.pcTieuDe.TabStop = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.IsSelectionEnabled = false;
            this.lblTieuDe.Location = new System.Drawing.Point(94, 31);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(232, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Lịch Sử Kích Hoạt:";
            // 
            // Mss
            // 
            this.Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.Mss.Caption = "Thông Báo";
            this.Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.Mss.Parent = null;
            this.Mss.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.Mss.Text = null;
            // 
            // btnThoat
            // 
            this.btnThoat.Animated = true;
            this.btnThoat.AutoRoundedCorners = true;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BorderRadius = 30;
            this.btnThoat.CustomizableEdges.BottomLeft = false;
            this.btnThoat.CustomizableEdges.TopRight = false;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(294, 26);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(430, 62);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtgDoAn
            // 
            this.dtgDoAn.AllowUserToAddRows = false;
            this.dtgDoAn.AllowUserToDeleteRows = false;
            this.dtgDoAn.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgDoAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDoAn.AutoGenerateColumns = false;
            this.dtgDoAn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDoAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDoAn.ColumnHeadersHeight = 70;
            this.dtgDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgDoAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSKDataGridViewTextBoxColumn,
            this.thoiGianBDDataGridViewTextBoxColumn,
            this.thoiGianKTDataGridViewTextBoxColumn});
            this.dtgDoAn.DataSource = this.lichSuSuKienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDoAn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDoAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgDoAn.Location = new System.Drawing.Point(22, 124);
            this.dtgDoAn.Name = "dtgDoAn";
            this.dtgDoAn.ReadOnly = true;
            this.dtgDoAn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDoAn.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDoAn.RowHeadersVisible = false;
            this.dtgDoAn.RowHeadersWidth = 62;
            this.dtgDoAn.RowTemplate.Height = 50;
            this.dtgDoAn.Size = new System.Drawing.Size(1018, 451);
            this.dtgDoAn.TabIndex = 46;
            this.dtgDoAn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgDoAn.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgDoAn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgDoAn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dtgDoAn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgDoAn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgDoAn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgDoAn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dtgDoAn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgDoAn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgDoAn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgDoAn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgDoAn.ThemeStyle.HeaderStyle.Height = 70;
            this.dtgDoAn.ThemeStyle.ReadOnly = true;
            this.dtgDoAn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgDoAn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgDoAn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgDoAn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgDoAn.ThemeStyle.RowsStyle.Height = 50;
            this.dtgDoAn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dtgDoAn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnThoat);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 602);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1052, 111);
            this.guna2Panel1.TabIndex = 45;
            // 
            // maSKDataGridViewTextBoxColumn
            // 
            this.maSKDataGridViewTextBoxColumn.DataPropertyName = "MaSK";
            this.maSKDataGridViewTextBoxColumn.HeaderText = "Mã Sự Kiện";
            this.maSKDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maSKDataGridViewTextBoxColumn.Name = "maSKDataGridViewTextBoxColumn";
            this.maSKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianBDDataGridViewTextBoxColumn
            // 
            this.thoiGianBDDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianBD";
            this.thoiGianBDDataGridViewTextBoxColumn.HeaderText = "Thời Gian Bắt Đầu";
            this.thoiGianBDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thoiGianBDDataGridViewTextBoxColumn.Name = "thoiGianBDDataGridViewTextBoxColumn";
            this.thoiGianBDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianKTDataGridViewTextBoxColumn
            // 
            this.thoiGianKTDataGridViewTextBoxColumn.DataPropertyName = "ThoiGianKT";
            this.thoiGianKTDataGridViewTextBoxColumn.HeaderText = "Thời Gian Kết Thúc";
            this.thoiGianKTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thoiGianKTDataGridViewTextBoxColumn.Name = "thoiGianKTDataGridViewTextBoxColumn";
            this.thoiGianKTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lichSuSuKienBindingSource
            // 
            this.lichSuSuKienBindingSource.DataSource = typeof(Phan_Mem_Quan_Ly.Model.LichSuSuKien);
            // 
            // frmLichSuSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1052, 713);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.dtgDoAn);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLichSuSuKien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLichSuSuKien";
            this.Load += new System.EventHandler(this.frmLichSuSuKien_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcTieuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoAn)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lichSuSuKienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox pcTieuDe;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTieuDe;
        private Guna.UI2.WinForms.Guna2MessageDialog Mss;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2DataGridView dtgDoAn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianBDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lichSuSuKienBindingSource;
    }
}