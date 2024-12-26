using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.UserControls
{
    public partial class DiscountControl : UserControl
    {
        public DiscountControl()
        {
            InitializeComponent();
        }
        public string MaSP { get => lblMaSP.Text; set => lblMaSP.Text = value; }
        public decimal GiamGia { get => nudGiamGia.Value; set => nudGiamGia.Value = value; }

        private void nudGiamGia_ValueChanged(object sender, System.EventArgs e)
        {
        }
    }
}
