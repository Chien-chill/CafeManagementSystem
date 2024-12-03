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
using Phan_Mem_Quan_Ly;

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
                MssBox mss = new MssBox("Bạn có muốn hủy hóa đơn "+MaHD+" ?");
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
