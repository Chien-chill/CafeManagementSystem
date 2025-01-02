using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.View
{
    public partial class frmNhapSP : Form
    {
        public frmNhapSP()
        {
            InitializeComponent();
        }
        public Dictionary<string, Form> frmDic = new Dictionary<string, Form>();
        public void loadPage(string formName, Form f)
        {
            ResetPage();
            if (!frmDic.ContainsKey(formName))
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.PnPage.Controls.Add(f);
                frmDic[formName] = f;
            }
            Form frm = frmDic[formName];
            frm.Show();
            this.PnPage.Tag = frm;
        }
        public void ResetPage()
        {
            foreach (Control c in PnPage.Controls)
            {
                if (c is Form)
                {
                    c.Hide();
                }
            }
        }
        public static ChucVu cv { get; set; }
        private void btnDoUong_Click(object sender, EventArgs e)
        {
            if (cv.ThaoTacSanPham == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacSanPham == 2 || cv.ThaoTacSanPham == 3)
            {
                pnDeny.Visible = false;
                loadPage("DoUong", new frmDoUong());
            }
        }
        private void frmNhapSP_Load(object sender, EventArgs e)
        {
            cv = fn_ChucVuRespository.GetQuyenChucVu(frmTrangChu.Instance.MaCV);
            btnDoUong.Checked = true;
            btnDoUong_Click(sender, e);
        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            if (cv.ThaoTacSanPham == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacSanPham == 2 || cv.ThaoTacSanPham == 3)
            {
                pnDeny.Visible = false;
                loadPage("DoAn", new frmDoAn());
            }
        }

        private void btnSuKien_Click(object sender, EventArgs e)
        {
            if (cv.ThaoTacSuKien == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacSuKien == 2 || cv.ThaoTacSuKien == 3)
            {
                pnDeny.Visible = false;
                loadPage("SuKien", new frmSuKien());
            }
        }
    }
}
