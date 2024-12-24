using DevExpress.XtraCharts;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmThongKeNam : Form
    {
        public frmThongKeNam()
        {
            InitializeComponent();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (lblDauNam.Text.Equals(DateTime.Now.Year.ToString()))
            {
                ToastMSS mss = new ToastMSS("Xin lỗi chưa có dữ liệu năm tiếp theo !", "SAD");
                mss.Show();
            }
            else
            {
                lblDauNam.Text = Convert.ToString(int.Parse(lblDauNam.Text) + 1);
                lblCuoiNam.Text = lblDauNam.Text;
                loadChart(int.Parse(lblCuoiNam.Text));
            }
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            lblDauNam.Text = Convert.ToString(int.Parse(lblDauNam.Text) - 1);
            lblCuoiNam.Text = lblDauNam.Text;
            loadChart(int.Parse(lblCuoiNam.Text));
        }

        private void frmThongKeNam_Load(object sender, EventArgs e)
        {

            lblDauNam.Text = DateTime.Now.Year.ToString();
            lblCuoiNam.Text = DateTime.Now.Year.ToString();
            loadChart(int.Parse(lblCuoiNam.Text));
        }
        private void loadChart(int Nam)
        {
            Series series = new Series("Thống Kê Doanh Thu Năm", ViewType.Bar);
            series.DataSource = fn_ThongKeRespository.GetThongKeDoanhThuNam(Nam);
            series.ArgumentDataMember = "Thang_Nam";
            series.ValueDataMembers.AddRange(new string[] { "TongDoanhThu" });
            series.Label.TextPattern = "{VP:p0} ({V:.##} VND)";
            series.LegendTextPattern = "{A}";
            chtDoanhThuThang.Series.Clear();
            chtDoanhThuThang.Series.Add(series);
        }
    }
}
