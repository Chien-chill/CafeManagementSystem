namespace Phan_Mem_Quan_Ly
{
    partial class ItemControl 
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemControl));
            this.pnDonGia = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblDonGia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnTen = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTenSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnChecked = new Guna.UI2.WinForms.Guna2Panel();
            this.PnSize = new System.Windows.Forms.Panel();
            this.btnSizeL = new Guna.UI2.WinForms.Guna2Button();
            this.btnSizeM = new Guna.UI2.WinForms.Guna2Button();
            this.btnSizeS = new Guna.UI2.WinForms.Guna2Button();
            this.btnChecked = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MSS = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnDonGia.SuspendLayout();
            this.pnTen.SuspendLayout();
            this.pnChecked.SuspendLayout();
            this.PnSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDonGia
            // 
            this.pnDonGia.Controls.Add(this.lblDonGia);
            this.pnDonGia.Enabled = false;
            this.pnDonGia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.pnDonGia.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.pnDonGia.Location = new System.Drawing.Point(3, 3);
            this.pnDonGia.Name = "pnDonGia";
            this.pnDonGia.Size = new System.Drawing.Size(137, 35);
            this.pnDonGia.TabIndex = 3;
            this.pnDonGia.Visible = false;
            this.pnDonGia.Click += new System.EventHandler(this.pnDonGia_Click);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = false;
            this.lblDonGia.BackColor = System.Drawing.Color.Transparent;
            this.lblDonGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDonGia.Enabled = false;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.White;
            this.lblDonGia.IsSelectionEnabled = false;
            this.lblDonGia.Location = new System.Drawing.Point(0, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(137, 35);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = null;
            this.lblDonGia.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDonGia.Click += new System.EventHandler(this.lblDonGia_Click);
            // 
            // pnTen
            // 
            this.pnTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTen.BackColor = System.Drawing.Color.Transparent;
            this.pnTen.Controls.Add(this.lblTenSP);
            this.pnTen.Enabled = false;
            this.pnTen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnTen.Location = new System.Drawing.Point(20, 112);
            this.pnTen.Name = "pnTen";
            this.pnTen.ShadowColor = System.Drawing.Color.Black;
            this.pnTen.Size = new System.Drawing.Size(223, 56);
            this.pnTen.TabIndex = 4;
            this.pnTen.Click += new System.EventHandler(this.pnTen_Click);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = false;
            this.lblTenSP.BackColor = System.Drawing.Color.Transparent;
            this.lblTenSP.Enabled = false;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTenSP.IsSelectionEnabled = false;
            this.lblTenSP.Location = new System.Drawing.Point(3, 7);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(217, 45);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Tên Sản Phẩm ";
            this.lblTenSP.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnChecked
            // 
            this.pnChecked.BackColor = System.Drawing.Color.Transparent;
            this.pnChecked.BorderColor = System.Drawing.Color.Tomato;
            this.pnChecked.BorderThickness = 4;
            this.pnChecked.Controls.Add(this.PnSize);
            this.pnChecked.Controls.Add(this.btnChecked);
            this.pnChecked.Controls.Add(this.pnTen);
            this.pnChecked.Controls.Add(this.pnDonGia);
            this.pnChecked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnChecked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChecked.FillColor = System.Drawing.Color.Transparent;
            this.pnChecked.Location = new System.Drawing.Point(0, 0);
            this.pnChecked.Name = "pnChecked";
            this.pnChecked.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.pnChecked.Size = new System.Drawing.Size(260, 260);
            this.pnChecked.TabIndex = 0;
            this.pnChecked.Click += new System.EventHandler(this.pnChecked_Click);
            // 
            // PnSize
            // 
            this.PnSize.Controls.Add(this.btnSizeL);
            this.PnSize.Controls.Add(this.btnSizeM);
            this.PnSize.Controls.Add(this.btnSizeS);
            this.PnSize.Location = new System.Drawing.Point(8, 201);
            this.PnSize.Name = "PnSize";
            this.PnSize.Size = new System.Drawing.Size(120, 58);
            this.PnSize.TabIndex = 9;
            // 
            // btnSizeL
            // 
            this.btnSizeL.Animated = true;
            this.btnSizeL.BorderRadius = 10;
            this.btnSizeL.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSizeL.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSizeL.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnSizeL.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSizeL.CustomBorderColor = System.Drawing.Color.LightGray;
            this.btnSizeL.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnSizeL.CustomizableEdges.BottomLeft = false;
            this.btnSizeL.CustomizableEdges.TopLeft = false;
            this.btnSizeL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSizeL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSizeL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.btnSizeL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSizeL.ForeColor = System.Drawing.Color.Gray;
            this.btnSizeL.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnSizeL.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSizeL.Location = new System.Drawing.Point(71, 9);
            this.btnSizeL.Name = "btnSizeL";
            this.btnSizeL.PressedColor = System.Drawing.Color.White;
            this.btnSizeL.Size = new System.Drawing.Size(39, 40);
            this.btnSizeL.TabIndex = 8;
            this.btnSizeL.Text = "L";
            this.btnSizeL.Click += new System.EventHandler(this.btnSizeL_Click);
            // 
            // btnSizeM
            // 
            this.btnSizeM.Animated = true;
            this.btnSizeM.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSizeM.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSizeM.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnSizeM.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSizeM.CustomBorderColor = System.Drawing.Color.LightGray;
            this.btnSizeM.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.btnSizeM.CustomizableEdges.BottomRight = false;
            this.btnSizeM.CustomizableEdges.TopRight = false;
            this.btnSizeM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSizeM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSizeM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.btnSizeM.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSizeM.ForeColor = System.Drawing.Color.Gray;
            this.btnSizeM.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnSizeM.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSizeM.Location = new System.Drawing.Point(34, 9);
            this.btnSizeM.Name = "btnSizeM";
            this.btnSizeM.PressedColor = System.Drawing.Color.White;
            this.btnSizeM.Size = new System.Drawing.Size(39, 40);
            this.btnSizeM.TabIndex = 8;
            this.btnSizeM.Text = "M";
            this.btnSizeM.Click += new System.EventHandler(this.btnSizeM_Click);
            // 
            // btnSizeS
            // 
            this.btnSizeS.Animated = true;
            this.btnSizeS.BorderRadius = 10;
            this.btnSizeS.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSizeS.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSizeS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnSizeS.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSizeS.CustomBorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnSizeS.CustomizableEdges.BottomRight = false;
            this.btnSizeS.CustomizableEdges.TopRight = false;
            this.btnSizeS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSizeS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSizeS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSizeS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.btnSizeS.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSizeS.ForeColor = System.Drawing.Color.Gray;
            this.btnSizeS.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnSizeS.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSizeS.Location = new System.Drawing.Point(2, 9);
            this.btnSizeS.Name = "btnSizeS";
            this.btnSizeS.PressedColor = System.Drawing.Color.White;
            this.btnSizeS.Size = new System.Drawing.Size(39, 40);
            this.btnSizeS.TabIndex = 8;
            this.btnSizeS.Text = "S";
            this.btnSizeS.Click += new System.EventHandler(this.btnSizeS_Click);
            // 
            // btnChecked
            // 
            this.btnChecked.BorderRadius = 10;
            this.btnChecked.CustomizableEdges.BottomLeft = false;
            this.btnChecked.CustomizableEdges.BottomRight = false;
            this.btnChecked.CustomizableEdges.TopRight = false;
            this.btnChecked.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChecked.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChecked.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChecked.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChecked.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChecked.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnChecked.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnChecked.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChecked.ForeColor = System.Drawing.Color.Transparent;
            this.btnChecked.Image = ((System.Drawing.Image)(resources.GetObject("btnChecked.Image")));
            this.btnChecked.ImageSize = new System.Drawing.Size(32, 32);
            this.btnChecked.Location = new System.Drawing.Point(197, 208);
            this.btnChecked.Name = "btnChecked";
            this.btnChecked.Size = new System.Drawing.Size(60, 49);
            this.btnChecked.TabIndex = 5;
            this.btnChecked.Visible = false;
            this.btnChecked.Click += new System.EventHandler(this.btnChecked_Click);
            // 
            // MSS
            // 
            this.MSS.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MSS.Caption = null;
            this.MSS.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.MSS.Parent = null;
            this.MSS.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MSS.Text = null;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 4;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnChecked);
            this.Margin = new System.Windows.Forms.Padding(15, 5, 10, 20);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(260, 260);
            this.Load += new System.EventHandler(this.ItemControl_Load);
            this.Click += new System.EventHandler(this.ItemControl_Click);
            this.pnDonGia.ResumeLayout(false);
            this.pnTen.ResumeLayout(false);
            this.pnChecked.ResumeLayout(false);
            this.PnSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Panel pnChecked;
        public Guna.UI2.WinForms.Guna2GradientButton btnChecked;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDonGia;
        private Guna.UI2.WinForms.Guna2GradientPanel pnDonGia;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenSP;
        private Guna.UI2.WinForms.Guna2MessageDialog MSS;
        public Guna.UI2.WinForms.Guna2Button btnSizeS;
        public Guna.UI2.WinForms.Guna2Button btnSizeL;
        public Guna.UI2.WinForms.Guna2Button btnSizeM;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel PnSize;
    }
}
