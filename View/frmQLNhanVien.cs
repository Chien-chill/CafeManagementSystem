using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
