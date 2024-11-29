using Phan_Mem_Quan_Ly.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
        decimal DonGiaSP= 0.00m;
        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            decimal TongGiaTien=0.00m;
            TongGiaTien = DonGiaSP * nudSoLuong.Value;
            lblDonGia.Text = TongGiaTien.ToString(/*"C", new CultureInfo("vi-VN")*/);
        }

        private void PayControl_Load(object sender, EventArgs e)
        {
          DonGiaSP = decimal.Parse(lblDonGia.Text/*.Replace(" ₫", "")*/);
        }
        public string TenSP { get => lblTenSP.Text; set=> lblTenSP.Text = value; }
        public string DonGia { get=> lblDonGia.Text; set=> lblDonGia.Text = value; }
        public string SizeSP { get => lblSize.Text; set => lblSize.Text = value; }
    }
}
