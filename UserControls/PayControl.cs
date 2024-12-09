using System;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly
{
    public partial class PayControl : UserControl
    {
        public PayControl()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
            }
        }
        decimal DonGiaSP = 0.00m;
        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            decimal TongGiaTien = 0.00m;
            TongGiaTien = DonGiaSP * nudSoLuong.Value;
            lblThanhTien.Text = TongGiaTien.ToString(/*"C", new CultureInfo("vi-VN")*/);
        }

        private void PayControl_Load(object sender, EventArgs e)
        {
            DonGiaSP = decimal.Parse(lblThanhTien.Text/*.Replace(" ₫", "")*/);
            DonGia = DonGiaSP.ToString();
        }
        public string TenSP { get => lblTenSP.Text; set => lblTenSP.Text = value; }
        public string ThanhTien { get => lblThanhTien.Text; set => lblThanhTien.Text = value; }
        public string DonGia { get => lblDonGia.Text; set => lblDonGia.Text = value; }
        public string SizeSP { get => lblSize.Text; set => lblSize.Text = value; }
    }
}
