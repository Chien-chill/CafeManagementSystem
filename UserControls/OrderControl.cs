using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
                    MessageBox.Show("Xác Nhận Thành Công");
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
                var hd = new HoaDon();
                {
                    hd.MaHD = MaHD;
                }
                bool result = fn_HoaDonRespository.UPDATEHoaDon(hd, "Hủy");
                if (result)
                {
                    MessageBox.Show("Hủy Thành Công");
                }
                else
                {
                    MessageBox.Show("Hủy Thất Bại");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Hủy: " + ex.Message);
            }
        }
    }
}
