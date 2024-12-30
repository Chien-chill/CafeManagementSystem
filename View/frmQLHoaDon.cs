using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Phan_Mem_Quan_Ly.View
{
    public partial class frmDonHang : Form
    {
        public frmDonHang()
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
            if (formName == "DonHangChuaXacNhan" && frm is frmHoaDonChuaXacNhan hoaDonChuaXacNhan)
            {
                hoaDonChuaXacNhan.loadDonHang();
            }
            this.PnPage.Tag = frm;
        }

        private void btnDonHangChuaXacNhan_Click(object sender, EventArgs e)
        {
            loadPage("DonHangChuaXacNhan", new frmHoaDonChuaXacNhan());
        }

        public void frmDonHang_Load(object sender, EventArgs e)
        {
            var cv = fn_ChucVuRespository.GetQuyenChucVu(frmTrangChu.Instance.MaCV);
            if (cv.ThaoTacDonHang == 1)
            {
                btnDonHangChuaXacNhan.Enabled = false;
                btnDSHoaDon.Enabled = false;
            }
            else if (cv.ThaoTacDonHang == 2)
            {
                PnPage.Enabled = false;
            }
            btnDonHangChuaXacNhan.Checked = true;
            btnDonHangChuaXacNhan_Click(sender, e);
        }

        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            loadPage("DSHoaDon", new frmDSHoaDon());
        }
    }
}
