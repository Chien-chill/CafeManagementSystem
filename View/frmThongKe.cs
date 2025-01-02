using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System.Windows.Forms;
namespace Phan_Mem_Quan_Ly.View
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        public void loadPage(Form f)
        {
            ResetPage();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PnPage.Controls.Add(f);
            f.Show();
            this.PnPage.Tag = f;
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
        private void frmThongKe_Load(object sender, System.EventArgs e)
        {
            cv = fn_ChucVuRespository.GetQuyenChucVu(frmTrangChu.Instance.MaCV);
            btnThongKeSP.Checked = true;
            btnThongKeSP_Click(sender, e);
        }

        private void btnThongKeSP_Click(object sender, System.EventArgs e)
        {
            if (cv.ThaoTacThongKe == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacThongKe == 2 || cv.ThaoTacThongKe == 3)
            {
                pnDeny.Visible = false;
                loadPage(new frmThongKeSP());
            }
        }

        private void btnThongKeNam_Click(object sender, System.EventArgs e)
        {
            if (cv.ThaoTacThongKe == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacThongKe == 2 || cv.ThaoTacThongKe == 3)
            {
                pnDeny.Visible = false;
                loadPage(new frmThongKeNam());
            }
        }

        private void btnBaoCaoTuan_Click(object sender, System.EventArgs e)
        {
            if (cv.ThaoTacThongKe == 1)
            {
                ResetPage();
                pnDeny.Visible = true;
            }
            else if (cv.ThaoTacThongKe == 2 || cv.ThaoTacThongKe == 3)
            {
                pnDeny.Visible = false;
                loadPage(new frmBaoCaoTuan());
            }
        }
    }
}
