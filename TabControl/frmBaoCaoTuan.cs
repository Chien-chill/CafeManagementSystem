using DevExpress.XtraCharts;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmBaoCaoTuan : Form
    {
        public frmBaoCaoTuan()
        {
            InitializeComponent();
        }

        private void frmBaoCaoTuan_Load(object sender, EventArgs e)
        {
            Series series = new Series("Thống Kê Doanh Thu Tuần", ViewType.Bar);
            series.DataSource = fn_ThongKeRespository.GetThongKeDoanhThuTuan();
            series.ArgumentDataMember = "Thu";
            series.ValueDataMembers.AddRange(new string[] { "TongDoanhThu" });
            chtDoanhThuTuan.Series.Add(series);
        }
    }
}
