using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Phan_Mem_Quan_Ly.View
{
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
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
        public static ChucVu cv;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cv = fn_ChucVuRespository.GetQuyenChucVu(frmTrangChu.Instance.MaCV);
            btnNhanVien.Checked = true;
            btnNhanVien_Click(sender, e);

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (cv.ThaoTacNhanVien == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacNhanVien == 2 || cv.ThaoTacNhanVien == 3)
            {
                pnDeny.Visible = false;
                loadPage("NhanVien", new frmNhanVien());
            }
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            if (cv.ThaoTacChucVu == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacChucVu == 2 || cv.ThaoTacChucVu == 3)
            {
                pnDeny.Visible = false;
                loadPage("ChucVu", new frmChucVu());
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (cv.ThaoTacChucVu == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacChucVu == 2 || cv.ThaoTacChucVu == 3)
            {
                pnDeny.Visible = false;
                loadPage("TaiKhoan", new frmTaiKhoan());
            }
        }
    }
}
