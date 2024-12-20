namespace Phan_Mem_Quan_Ly.View
{
    partial class frmQLSuKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSuKien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThemSK = new Guna.UI2.WinForms.Guna2Button();
            this.dtgSuKien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ThaoTacSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.ThaoTacXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.MaSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuKienbindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSuKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuKienbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconRight = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.IconRight")));
            this.txtTimKiem.IconRightSize = new System.Drawing.Size(32, 32);
            this.txtTimKiem.Location = new System.Drawing.Point(1077, 64);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm Kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(453, 49);
            this.txtTimKiem.TabIndex = 16;
            this.txtTimKiem.IconRightClick += new System.EventHandler(this.txtTimKiem_IconRightClick);
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn5.FillWeight = 124.6334F;
            this.dataGridViewImageColumn5.HeaderText = "Sửa";
            this.dataGridViewImageColumn5.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn5.Image")));
            this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn5.MinimumWidth = 8;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.Width = 70;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn4.FillWeight = 84.75073F;
            this.dataGridViewImageColumn4.HeaderText = "Chi Tiết";
            this.dataGridViewImageColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn4.Image")));
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.MinimumWidth = 8;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn4.Width = 70;
            // 
            // btnThemSK
            // 
            this.btnThemSK.AutoRoundedCorners = true;
            this.btnThemSK.BorderRadius = 27;
            this.btnThemSK.CustomizableEdges.TopRight = false;
            this.btnThemSK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSK.ForeColor = System.Drawing.Color.White;
            this.btnThemSK.Location = new System.Drawing.Point(67, 60);
            this.btnThemSK.Name = "btnThemSK";
            this.btnThemSK.Size = new System.Drawing.Size(182, 56);
            this.btnThemSK.TabIndex = 17;
            this.btnThemSK.Text = "Thêm Mới";
            this.btnThemSK.Click += new System.EventHandler(this.btnThemSK_Click);
            // 
            // dtgSuKien
            // 
            this.dtgSuKien.AllowUserToAddRows = false;
            this.dtgSuKien.AllowUserToDeleteRows = false;
            this.dtgSuKien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgSuKien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSuKien.AutoGenerateColumns = false;
            this.dtgSuKien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSuKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgSuKien.ColumnHeadersHeight = 70;
            this.dtgSuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgSuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSK,
            this.TenSK,
            this.ThoiGianBD,
            this.ThoiGianKT,
            this.TrangThai,
            this.ThaoTacSua,
            this.ThaoTacXoa});
            this.dtgSuKien.DataSource = this.SuKienbindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSuKien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgSuKien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgSuKien.Location = new System.Drawing.Point(117, 170);
            this.dtgSuKien.Name = "dtgSuKien";
            this.dtgSuKien.ReadOnly = true;
            this.dtgSuKien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSuKien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgSuKien.RowHeadersVisible = false;
            this.dtgSuKien.RowHeadersWidth = 62;
            this.dtgSuKien.RowTemplate.Height = 50;
            this.dtgSuKien.Size = new System.Drawing.Size(1363, 680);
            this.dtgSuKien.TabIndex = 15;
            this.dtgSuKien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgSuKien.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgSuKien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgSuKien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dtgSuKien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgSuKien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgSuKien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgSuKien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dtgSuKien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgSuKien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgSuKien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgSuKien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgSuKien.ThemeStyle.HeaderStyle.Height = 70;
            this.dtgSuKien.ThemeStyle.ReadOnly = true;
            this.dtgSuKien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgSuKien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgSuKien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgSuKien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgSuKien.ThemeStyle.RowsStyle.Height = 50;
            this.dtgSuKien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dtgSuKien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgSuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSuKien_CellClick);
            // 
            // ThaoTacSua
            // 
            this.ThaoTacSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ThaoTacSua.FillWeight = 124.6334F;
            this.ThaoTacSua.HeaderText = "Sửa";
            this.ThaoTacSua.Image = ((System.Drawing.Image)(resources.GetObject("ThaoTacSua.Image")));
            this.ThaoTacSua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ThaoTacSua.MinimumWidth = 8;
            this.ThaoTacSua.Name = "ThaoTacSua";
            this.ThaoTacSua.ReadOnly = true;
            this.ThaoTacSua.Width = 90;
            // 
            // ThaoTacXoa
            // 
            this.ThaoTacXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ThaoTacXoa.FillWeight = 136.3636F;
            this.ThaoTacXoa.HeaderText = "Xóa";
            this.ThaoTacXoa.Image = ((System.Drawing.Image)(resources.GetObject("ThaoTacXoa.Image")));
            this.ThaoTacXoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ThaoTacXoa.MinimumWidth = 8;
            this.ThaoTacXoa.Name = "ThaoTacXoa";
            this.ThaoTacXoa.ReadOnly = true;
            this.ThaoTacXoa.Width = 90;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.FillWeight = 136.3636F;
            this.dataGridViewImageColumn3.HeaderText = "Xóa";
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 8;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 70;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 136.3636F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 232;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 124.6334F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 232;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn6.FillWeight = 136.3636F;
            this.dataGridViewImageColumn6.HeaderText = "Xóa";
            this.dataGridViewImageColumn6.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn6.Image")));
            this.dataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn6.MinimumWidth = 8;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.Width = 70;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(67, 132);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1463, 10);
            this.guna2Separator1.TabIndex = 14;
            // 
            // MaSK
            // 
            this.MaSK.DataPropertyName = "MaSK";
            this.MaSK.HeaderText = "Mã Sự Kiện";
            this.MaSK.MinimumWidth = 8;
            this.MaSK.Name = "MaSK";
            this.MaSK.ReadOnly = true;
            // 
            // TenSK
            // 
            this.TenSK.DataPropertyName = "TenSK";
            this.TenSK.HeaderText = "Tên Sự Kiện";
            this.TenSK.MinimumWidth = 8;
            this.TenSK.Name = "TenSK";
            this.TenSK.ReadOnly = true;
            // 
            // ThoiGianBD
            // 
            this.ThoiGianBD.DataPropertyName = "ThoiGianBD";
            this.ThoiGianBD.HeaderText = "Thời Gian Bắt Đầu";
            this.ThoiGianBD.MinimumWidth = 8;
            this.ThoiGianBD.Name = "ThoiGianBD";
            this.ThoiGianBD.ReadOnly = true;
            // 
            // ThoiGianKT
            // 
            this.ThoiGianKT.DataPropertyName = "ThoiGianKT";
            this.ThoiGianKT.HeaderText = "Thời Gian Kết Thúc";
            this.ThoiGianKT.MinimumWidth = 8;
            this.ThoiGianKT.Name = "ThoiGianKT";
            this.ThoiGianKT.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // SuKienbindingSource
            // 
            this.SuKienbindingSource.DataSource = typeof(Phan_Mem_Quan_Ly.Model.SuKien);
            // 
            // frmQLSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1618, 895);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThemSK);
            this.Controls.Add(this.dtgSuKien);
            this.Controls.Add(this.guna2Separator1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLSuKien";
            this.Text = "frmQLSuKien";
            this.Load += new System.EventHandler(this.frmQLSuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSuKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuKienbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private Guna.UI2.WinForms.Guna2Button btnThemSK;
        private System.Windows.Forms.BindingSource SuKienbindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView dtgSuKien;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewImageColumn ThaoTacSua;
        private System.Windows.Forms.DataGridViewImageColumn ThaoTacXoa;
    }
}