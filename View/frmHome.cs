using DevExpress.XtraCharts;
using Phan_Mem_Quan_Ly.Respository;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.View
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, System.EventArgs e)
        {
            Series series1 = new Series("Thống Kê Doanh Thu Tuần", ViewType.Bar);
            series1.DataSource = fn_ThongKeRespository.GetThongKeDoanhThuTuan();
            series1.ArgumentDataMember = "Thu";
            series1.ValueDataMembers.AddRange(new string[] { "TongDoanhThu" });
            chtDoanhThuTuan.Series.Add(series1);
        }
    }
}
