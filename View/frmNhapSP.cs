using Phan_Mem_Quan_Ly.View;
using Phan_Mem_Quan_Ly.TabControl;
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
    public partial class frmNhapSP : Form
    {
        public frmNhapSP()
        {
            InitializeComponent();
        }
        public Dictionary<string,Form> frmDic = new Dictionary<string,Form>();
        public void loadPage(string formName, Form f)
        {
            foreach(Control c in PnPage.Controls)
            {
                if (c is Form)
                {
                    c.Hide();
                }
            } 
            if(!frmDic.ContainsKey(formName))
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

        private void btnDoUong_Click(object sender, EventArgs e)
        {
            loadPage("DoUong", new frmDoUong());
        }

        private void frmNhapSP_Load(object sender, EventArgs e)
        {
            btnDoUong.Checked = true;
            btnDoUong_Click(sender,e);
        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            loadPage("DoAn",new frmDoAn());
        }
    }
}
