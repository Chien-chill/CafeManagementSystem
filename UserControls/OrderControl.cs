using CrystalDecisions.CrystalReports.Engine;
using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Reports;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.UserControls
{
    public partial class OrderControl : UserControl
    {
        public string MaHD { get => lblMaHD.Text; set => lblMaHD.Text = value; }
        public string MaKH { get => lblMaKH.Text; set => lblMaKH.Text = value; }
        public string MaNV { get => lblMaNV.Text; set => lblMaNV.Text = value; }
        public string MaSK { get => lblMaSK.Text; set => lblMaSK.Text = value; }
        public string TongTien { get => lblTongTien.Text; set => lblTongTien.Text = value; }
        public string NgayTao { get => lblNgayTao.Text; set => lblNgayTao.Text = value; }
        public string GioVao { get => lblGioVao.Text; set => lblGioVao.Text = value; }

        public OrderControl()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var hd = new HoaDon();
                {
                    hd.MaHD = MaHD;
                }
                bool result = fn_HoaDonRespository.UPDATEHoaDon(hd, "Xác Nhận");
                if (result)
                {
                    if (this.Parent != null)
                    {
                        this.Parent.Controls.Remove(this);
                    }
                    ToastMSS ts = new ToastMSS("Xác nhận thành công !", "SUCCESS");
                    ts.Show();
                    frmTrangChu.Instance.loadThongBao();

                    HoaDonDataSet dataset = new HoaDonDataSet();

                    // Tạo dữ liệu mẫu
                    DataRow hdRow = dataset.Tables["HoaDonTable"].NewRow();
                    hdRow["MaHD"] = MaHD;
                    hdRow["NgayTao"] = NgayTao;
                    hdRow["GioRa"] = DateTime.Now.ToString("HH:mm:ss");
                    hdRow["GioVao"] = GioVao;
                    hdRow["TongTien"] = TongTien;
                    dataset.Tables["HoaDonTable"].Rows.Add(hdRow);

                    var lstcthd = fn_HoaDonRespository.GetChiTietHDTheoMa(MaHD);
                    int stt = 1;

                    foreach (var ct in lstcthd)
                    {
                        DataRow ctRow = dataset.Tables["ChiTietHDTable"].NewRow();
                        ctRow["STT"] = stt;
                        ctRow["TenSP"] = ct.TenSP;
                        ctRow["SoLuong"] = ct.SoLuong;
                        ctRow["DonGia"] = ct.DonGia;
                        ctRow["ThanhTien"] = ct.ThanhTien;
                        dataset.Tables["ChiTietHDTable"].Rows.Add(ctRow);
                        stt++;
                    }

                    // Kiểm tra dữ liệu trong DataSet
                    if (dataset.Tables["HoaDonTable"].Rows.Count == 0 || dataset.Tables["ChiTietHDTable"].Rows.Count == 0)
                    {
                        throw new Exception("DataSet không có dữ liệu.");
                    }

                    // Khởi tạo báo cáo
                    ReportDocument report = new ReportDocument();
                    string pathReport = Path.GetFullPath(Application.StartupPath + @"\..\..\Reports\HoaDonReport.rpt");
                    Console.WriteLine(pathReport);
                    report.Load(pathReport);

                    // Gán DataSet cho báo cáo
                    report.SetDataSource(dataset);

                    // Hiển thị báo cáo
                    frmReport rp = new frmReport();
                    rp.crystalReportViewer.ReportSource = report;
                    rp.crystalReportViewer.Refresh();
                    rp.Show();

                }
                else
                {
                    MessageBox.Show("Xác Nhận Thất Bại");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Xác Nhận: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                MssBox mss = new MssBox("Bạn có muốn hủy hóa đơn " + MaHD + " ?");
                if (mss.ShowDialog() == DialogResult.Yes)
                {
                    var hd = new HoaDon();
                    {
                        hd.MaHD = MaHD;
                    }
                    bool result = fn_HoaDonRespository.UPDATEHoaDon(hd, "Hủy");
                    if (result)
                    {
                        if (this.Parent != null)
                        {
                            this.Parent.Controls.Remove(this);
                        }
                        ToastMSS ts = new ToastMSS("Hủy thành công !", "DELETE");
                        ts.Show();
                        frmTrangChu.Instance.loadThongBao();
                    }
                    else
                    {
                        MessageBox.Show("Hủy Thất Bại");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Hủy: " + ex.Message);
            }
        }
    }
}
