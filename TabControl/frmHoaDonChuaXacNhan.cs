using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.UserControls;
using System;
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
        public void loadDonHang()
        {
            var lstHoaDon = fn_HoaDonRespository.GetHDChuaXuLy();
            if (lstHoaDon.Count() > 0)
            {
                foreach (var hd in lstHoaDon)
                {
                    OrderControl ord = new OrderControl();
                    {
                        ord.MaHD = hd.MaHD;
                        ord.MaKH = hd.MaKH;
                        ord.MaNV = hd.MaNV;
                        ord.MaSK = hd.MaSK;
                    }
                    flpDonHang.Controls.Add(ord);
                }
            }
        }
        private void frmDonHangChuaXacNhan_Load(object sender, EventArgs e)
        {

        }
    }
}
