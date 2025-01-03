using Aspose.Words;
using Aspose.Words.Tables;
using DevExpress.XtraCharts;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using ThuVienWinform.Report.AsposeWordExtension;
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

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                var lst = fn_HoaDonRespository.GetHoaDonTheoNgay(dtpNgayTao.Value);
                if (lst.Count > 0)
                {
                    decimal TongSoTien = 0;
                    Document BaoCao = new Document(@"TemplateWord\\Mau_Bao_Cao_Doanh_Thu.doc");
                    BaoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { dtpNgayTao.Text });
                    int count = lst.Count;
                    Table ThongTin = BaoCao.GetChild(NodeType.Table, 0, true) as Table;
                    int row = 1;
                    ThongTin.InsertRows(row, row, count - 1);
                    foreach (var i in lst)
                    {
                        ThongTin.PutValue(row, 0, i.MaHD);
                        ThongTin.PutValue(row, 1, i.MaKH);
                        ThongTin.PutValue(row, 2, i.GioRa);
                        ThongTin.PutValue(row, 3, i.GioVao);
                        ThongTin.PutValue(row, 4, i.MaSK);
                        ThongTin.PutValue(row, 5, i.TongTien.ToString());
                        ThongTin.PutValue(row, 6, i.MaNV);
                        TongSoTien += i.TongTien;
                        row++;
                    }
                    BaoCao.MailMerge.Execute(new[] { "Tong_So_Tien" }, new[] { TongSoTien.ToString() });
                    BaoCao.SaveAndOpenFile("DoanhThu.doc");
                }
                else
                {
                    ToastMSS mss = new ToastMSS("Không có dữ liệu của ngày " + dtpNgayTao.Text, "INFO");
                    mss.Show();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi báo cáo : " + ex.Message);
            }

        }
    }
}
