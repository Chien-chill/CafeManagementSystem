using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib;
using Phan_Mem_Quan_Ly.View;
namespace Phan_Mem_Quan_Ly
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        private Dictionary<string, Form> frmDic = new Dictionary<string, Form>();
        private void loadfrm(string formName, Form f)
        {
            foreach (Control c in this.MainPanel.Controls)
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
                this.MainPanel.Controls.Add(f);
                frmDic[formName] = f;
            }

            Form frm = frmDic[formName];
            frm.Show();
            if (formName == "BanHang" && frm is frmBanHang banHang)
            {
                txtTimKiem.IconRightClick += (sender, e) =>
                {
                    banHang.TimKiemSP(txtTimKiem.Text);
                };
                txtTimKiem.TextChanged += (sender, e) =>
                {
                    if(string.IsNullOrEmpty(txtTimKiem.Text))
                    banHang.TimKiemSP(txtTimKiem.Text);
                };
                banHang.loadDanhMuc();
            }
            
            this.MainPanel.Tag = frm;
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            btnTatCa_Click(sender, e);
        }
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            loadfrm("BanHang", new frmBanHang());

        }

        private void btnNuocUong_Click(object sender, EventArgs e)
        {
            loadfrm("NhapSP", new frmNhapSP());
        }
    }
}
