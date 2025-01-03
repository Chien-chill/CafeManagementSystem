using DevExpress.XtraCharts;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmThongKeSP : Form
    {
        public frmThongKeSP()
        {
            InitializeComponent();
        }

        private void frmThongKeSP_Load(object sender, EventArgs e)
        {
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

            // Customize the legend.
            chtDoanhThuSanPham.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add the chart to the form.
            chtDoanhThuSanPham.Series.Add(series);


            var tk = fn_ThongKeRespository.GetThongKe();
            lblTongDoanhThu.Text = tk.TongDoanhThu.ToString("C", new CultureInfo("vi-VN"));
            lblSoLuongHD.Text = tk.TongSoLuong.ToString() + " Hóa Đơn ";
            lblTyLeHoanThanh.Text = tk.TyLeHoanThanh.ToString() + " %";

        }
    }
}
