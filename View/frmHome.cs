using Phan_Mem_Quan_Ly.Respository;
using System.Linq;
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

            var lstSP = fn_ThongKeRespository.GetSanPhamBanChay();
            if (lstSP.Any())
            {
                var bestSeller = lstSP.First();
                pbBestSeller.Image = MainFn.ByteArrayToImage(bestSeller.AnhSP);
                lblSoLuongBan.Text = MainFn.FormatNumber(bestSeller.TongSoLuong);
                lblDoanhThu.Text = MainFn.FormatNumber(bestSeller.TongDoanhThu);
                lblLuongKHDat.Text = MainFn.FormatNumber(bestSeller.TongKhachHangDat);
            }
            //Series series1 = new Series("Thống Kê Doanh Thu Tuần", ViewType.Bar);
            //series1.DataSource = fn_ThongKeRespository.GetThongKeDoanhThuTuan();
            //series1.ArgumentDataMember = "Thu";
            //series1.ValueDataMembers.AddRange(new string[] { "TongDoanhThu" });
            //chtDoanhThuTuan.Series.Add(series1);
        }


    }
}
