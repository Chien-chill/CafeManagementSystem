using DevExpress.XtraCharts;
using Phan_Mem_Quan_Ly.Respository;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.View
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, System.EventArgs e)
        {
            //var lst = fn_ThongKeRespository.GetThongKeSanPham();
            //foreach (var i in lst)
            //{
            //    Debug.WriteLine($"Mã Sản Phẩm: {i.MaSP},Tên Sản Phẩm: {i.TenSP},Tổng Số Lượng: {i.TongSoLuong},Tổng Doanh Thu: {i.TongDoanhThu}");
            //}
            Series series = new Series("Thống Kê Doanh Thu Sản Phẩm", ViewType.Pie);
            series.DataSource = fn_ThongKeRespository.GetThongKeSanPham();
            series.ArgumentDataMember = "TenSP";
            series.ValueDataMembers.AddRange(new string[] { "TongDoanhThu" });
            series.Label.TextPattern = "{VP:p0} ({V:.##} VND)";
            // Format the series legend items.
            series.LegendTextPattern = "{A}";
            // Adjust the position of series labels. 
            ((PieSeriesLabel)series.Label).Position = PieSeriesLabelPosition.TwoColumns;

            // Detect overlapping of series labels.
            ((PieSeriesLabel)series.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series.
            PieSeriesView myView = (PieSeriesView)series.View;

            // Specify the pie rotation.
            myView.Rotation = -60;

            // Specify a data filter to explode points.
            //myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
            //    DataFilterCondition.GreaterThanOrEqual, 9));
            //myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
            //    DataFilterCondition.NotEqual, "Others"));
            //myView.ExplodeMode = PieExplodeMode.UseFilters;
            //myView.ExplodedDistancePercentage = 30;
            //myView.RuntimeExploding = true;

            // Customize the legend.
            chtDoanhThuSanPham.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add the chart to the form.
            chtDoanhThuSanPham.Series.Add(series);






            //var lst = fn_ThongKeRespository.GetThongKeDoanhThu();
            //foreach (var i in lst)
            //{
            //    Debug.WriteLine($"Tháng/Năm: {i.Thang_Nam},Tổng Doanh Thu: {i.TongDoanhThu}");
            //}
            Series series1 = new Series("Thống Kê Doanh Thu Tháng", ViewType.Bar);
            series1.DataSource = fn_ThongKeRespository.GetThongKeDoanhThuThang();
            series1.ArgumentDataMember = "Thang_Nam";
            series1.ValueDataMembers.AddRange(new string[] { "TongDoanhThu" });
            series.Label.TextPattern = "{VP:p0} ({V:.##} VND)";
            series.LegendTextPattern = "{A}";

            chtDoanhThuThang.Series.Add(series1);
        }
    }
}
