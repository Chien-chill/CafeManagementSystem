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

            chtDoanhThuSanPham.Series.Add(series);

        }
    }
}
