using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
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
        private void btnKhachHang_Click(object sender, System.EventArgs e)
        {
            if (cv.ThaoTacKhachHang == 1)
            {
                ResetPage();
                PnDeny.Visible = true;
            }
            else if (cv.ThaoTacKhachHang == 2 || cv.ThaoTacKhachHang == 3)
            {
                PnDeny.Visible = false;
                loadPage("KhachHang", new frmKhachHang());
            }
        }
        public static ChucVu cv { get; set; }
        private void frmQLKhachHang_Load(object sender, System.EventArgs e)
        {
            cv = fn_ChucVuRespository.GetQuyenChucVu(frmTrangChu.Instance.MaCV);
            btnKhachHang.Checked = true;
            btnKhachHang_Click(sender, e);
        }
    }
}
