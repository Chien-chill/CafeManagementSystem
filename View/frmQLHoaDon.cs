using Phan_Mem_Quan_Ly.Model;
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
            if (formName == "DonHangChuaXacNhan" && frm is frmHoaDonChuaXacNhan hoaDonChuaXacNhan)
            {
                hoaDonChuaXacNhan.loadDonHang();
            }
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
        private void btnDonHangChuaXacNhan_Click(object sender, EventArgs e)
        {
            if (cv.ThaoTacDonHang == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacDonHang == 2 || cv.ThaoTacDonHang == 3)
            {
                pnDeny.Visible = false;
                loadPage("DonHangChuaXacNhan", new frmHoaDonChuaXacNhan());
            }
        }
        public static ChucVu cv { get; set; }
        public void frmDonHang_Load(object sender, EventArgs e)
        {
            cv = fn_ChucVuRespository.GetQuyenChucVu(frmTrangChu.Instance.MaCV);
            btnDonHangChuaXacNhan.Checked = true;
            btnDonHangChuaXacNhan_Click(sender, e);
        }

        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            if (cv.ThaoTacDonHang == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacDonHang == 2 || cv.ThaoTacDonHang == 3)
            {
                pnDeny.Visible = false;
                loadPage("DSHoaDon", new frmDSHoaDon());
            }
        }
    }
}
