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

            btnThongKeSP_Click(sender, e);





            //Series series1 = new Series("Thống Kê Doanh Thu Tháng", ViewType.Bar);
            //series1.DataSource = fn_ThongKeRespository.GetThongKeDoanhThuThang();
            //series1.ArgumentDataMember = "Thang_Nam";
            //series1.ValueDataMembers.AddRange(new string[] { "TongDoanhThu" });
            //series.Label.TextPattern = "{VP:p0} ({V:.##} VND)";
            //series.LegendTextPattern = "{A}";

            //chtDoanhThuThang.Series.Add(series1);
        }

        private void btnThongKeSP_Click(object sender, System.EventArgs e)
        {
            loadPage(new frmThongKeSP());
        }

        private void btnThongKeNam_Click(object sender, System.EventArgs e)
        {
            loadPage(new frmThongKeNam());
        }
    }
}
