using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.UserControls;
using System;
using Phan_Mem_Quan_Ly;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }
            flpDonHang.Controls.Add(ord);
        }

        public void loadDonHang()
        {
            var lstHoaDon = fn_HoaDonRespository.GetHDChuaXuLy();
            var lstHoaDonThem = lstHoaDon.Where(hd => !flpDonHang.Controls.OfType<OrderControl>().Any(ord => ord.MaHD.Equals(hd.MaHD))).ToList();
            if (lstHoaDon.Any())
            {
                foreach (var hd in lstHoaDonThem)
                {
                    addOrderCtrl(hd);
                }
            }
        }
        private void frmDonHangChuaXacNhan_Load(object sender, EventArgs e)
        {
            loadDonHang();
        }
    }
}
