using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.UserControls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmHoaDonChuaXacNhan : Form
    {
        public frmHoaDonChuaXacNhan()
        {
            InitializeComponent();
        }
        private void addOrderCtrl(HoaDon hd)
        {
            OrderControl ord = new OrderControl();
            {
                ord.MaHD = hd.MaHD;
                ord.MaKH = hd.MaKH;
                ord.MaNV = hd.MaNV;
                ord.MaSK = hd.MaSK;
                ord.GioVao = hd.GioVao;
                ord.NgayTao = hd.NgayTao;
                ord.TongTien = hd.TongTien.ToString();
            }
            flpDonHang.Controls.Add(ord);
        }

        public void loadDonHang()
        {
            try
            {
                flpDonHang.Controls.Clear();
                var lstHoaDon = fn_HoaDonRespository.GetHoaDonTheoTrangThai("Chưa Xác Nhận");
                if (lstHoaDon.Any())
                {
                    foreach (var hd in lstHoaDon)
                    {
                        addOrderCtrl(hd);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng hóa đơn" + ex.Message);
            }
        }
        private void frmDonHangChuaXacNhan_Load(object sender, EventArgs e)
        {

            loadDonHang();
        }
    }
}
