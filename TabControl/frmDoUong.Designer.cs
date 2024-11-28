namespace Phan_Mem_Quan_Ly.TabControl
{
    partial class frmDoUong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoUong));
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.dtgDoUong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.MaDU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTaDU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTietDonGia = new System.Windows.Forms.DataGridViewImageColumn();
            this.ThaoTacSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.ThaoTacXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.SanPhambindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThemSP = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhambindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(81, 146);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1463, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // dtgDoUong
            // 
            this.dtgDoUong.AllowUserToAddRows = false;
            this.dtgDoUong.AllowUserToDeleteRows = false;
            this.dtgDoUong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgDoUong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDoUong.AutoGenerateColumns = false;
            this.dtgDoUong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDoUong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDoUong.ColumnHeadersHeight = 70;
            this.dtgDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgDoUong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDU,
            this.TenDU,
            this.MoTaDU,
            this.ChiTietDonGia,
            this.ThaoTacSua,
            this.ThaoTacXoa});
            this.dtgDoUong.DataSource = this.SanPhambindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDoUong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDoUong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgDoUong.Location = new System.Drawing.Point(131, 184);
            this.dtgDoUong.Name = "dtgDoUong";
            this.dtgDoUong.ReadOnly = true;
            this.dtgDoUong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDoUong.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDoUong.RowHeadersVisible = false;
            this.dtgDoUong.RowHeadersWidth = 62;
            this.dtgDoUong.RowTemplate.Height = 50;
            this.dtgDoUong.Size = new System.Drawing.Size(1363, 680);
            this.dtgDoUong.TabIndex = 3;
            this.dtgDoUong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgDoUong.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgDoUong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgDoUong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dtgDoUong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgDoUong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgDoUong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgDoUong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dtgDoUong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgDoUong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgDoUong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgDoUong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgDoUong.ThemeStyle.HeaderStyle.Height = 70;
            this.dtgDoUong.ThemeStyle.ReadOnly = true;
            this.dtgDoUong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgDoUong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgDoUong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgDoUong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgDoUong.ThemeStyle.RowsStyle.Height = 50;
            this.dtgDoUong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dtgDoUong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgDoUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDoUong_CellClick);
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
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn4.FillWeight = 84.75073F;
            this.dataGridViewImageColumn4.HeaderText = "Chi Tiết";
            this.dataGridViewImageColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn4.Image")));
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.MinimumWidth = 8;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn4.Width = 70;
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
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Width = 70;
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
            this.dataGridViewImageColumn6.ReadOnly = true;
            this.dataGridViewImageColumn6.Width = 70;
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
            this.txtTimKiem.Location = new System.Drawing.Point(1091, 78);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm Kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(453, 49);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // MaDU
            // 
            this.MaDU.DataPropertyName = "MaSP";
            this.MaDU.HeaderText = "Mã Đồ Uống";
            this.MaDU.MinimumWidth = 8;
            this.MaDU.Name = "MaDU";
            this.MaDU.ReadOnly = true;
            // 
            // TenDU
            // 
            this.TenDU.DataPropertyName = "TenSP";
            this.TenDU.HeaderText = "Tên Đồ Uống";
            this.TenDU.MinimumWidth = 8;
            this.TenDU.Name = "TenDU";
            this.TenDU.ReadOnly = true;
            // 
            // MoTaDU
            // 
            this.MoTaDU.DataPropertyName = "MoTaSP";
            this.MoTaDU.HeaderText = "Mô Tả ";
            this.MoTaDU.MinimumWidth = 8;
            this.MoTaDU.Name = "MoTaDU";
            this.MoTaDU.ReadOnly = true;
            // 
            // ChiTietDonGia
            // 
            this.ChiTietDonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ChiTietDonGia.FillWeight = 84.75073F;
            this.ChiTietDonGia.HeaderText = "Chi Tiết";
            this.ChiTietDonGia.Image = ((System.Drawing.Image)(resources.GetObject("ChiTietDonGia.Image")));
            this.ChiTietDonGia.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ChiTietDonGia.MinimumWidth = 8;
            this.ChiTietDonGia.Name = "ChiTietDonGia";
            this.ChiTietDonGia.ReadOnly = true;
            this.ChiTietDonGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChiTietDonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChiTietDonGia.Width = 90;
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
            // SanPhambindingSource
            // 
            this.SanPhambindingSource.DataSource = typeof(Phan_Mem_Quan_Ly.Model.SanPham);
            // 
            // btnThemSP
            // 
            this.btnThemSP.AnimationHoverSpeed = 0.07F;
            this.btnThemSP.AnimationSpeed = 0.03F;
            this.btnThemSP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThemSP.BorderColor = System.Drawing.Color.Black;
            this.btnThemSP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemSP.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemSP.Location = new System.Drawing.Point(81, 74);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemSP.OnHoverImage = null;
            this.btnThemSP.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemSP.Size = new System.Drawing.Size(182, 56);
            this.btnThemSP.TabIndex = 1;
            this.btnThemSP.Text = "Thêm Mới";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // frmDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1618, 895);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dtgDoUong);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnThemSP);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.frmDoUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhambindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI.WinForms.GunaButton btnThemSP;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2DataGridView dtgDoUong;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn anhSPDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource SanPhambindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTaDU;
        private System.Windows.Forms.DataGridViewImageColumn ChiTietDonGia;
        private System.Windows.Forms.DataGridViewImageColumn ThaoTacSua;
        private System.Windows.Forms.DataGridViewImageColumn ThaoTacXoa;
    }
}