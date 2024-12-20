using Phan_Mem_Quan_Ly.TabControl;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.View
{
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
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
            frm.Show();
            this.PnPage.Tag = frm;
        }

        private void btnKhachHang_Click(object sender, System.EventArgs e)
        {
            loadPage("KhachHang", new frmKhachHang());
        }

        private void frmQLKhachHang_Load(object sender, System.EventArgs e)
        {
            btnKhachHang.Checked = true;
            btnKhachHang_Click(sender, e);
        }
    }
}
