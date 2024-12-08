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
            foreach (Control c in PnPage.Controls)
            {
                if (c is Form)
                {
                    c.Hide();
                }
            }
            if (!frmDic.ContainsKey(formName))
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.PnPage.Controls.Add(f);
                frmDic[formName] = f;
            }
            Form frm = frmDic[formName];
            frm.BringToFront();
            frm.Show();
            this.PnPage.Tag = frm;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            btnNhanVien.Checked = true;
            btnNhanVien_Click(sender, e);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            loadPage("NhanVien", new frmNhanVien());
        }
    }
}
