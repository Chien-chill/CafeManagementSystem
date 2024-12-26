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
            foreach (Control c in PnPage.Controls)
            {
                if (c is Form)
                {
                    c.Hide();
                }
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PnPage.Controls.Add(f);
            f.Show();
            this.PnPage.Tag = f;
        }
        private void frmThongKe_Load(object sender, System.EventArgs e)
        {
            btnThongKeSP.Checked = true;
            btnThongKeSP_Click(sender, e);
        }

        private void btnThongKeSP_Click(object sender, System.EventArgs e)
        {
            loadPage(new frmThongKeSP());
        }

        private void btnThongKeNam_Click(object sender, System.EventArgs e)
        {
            loadPage(new frmThongKeNam());
        }

        private void btnBaoCaoTuan_Click(object sender, System.EventArgs e)
        {
            loadPage(new frmBaoCaoTuan());
        }
    }
}
