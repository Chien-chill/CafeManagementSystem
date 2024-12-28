using Phan_Mem_Quan_Ly.TabControl;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.PartialView
{
    public partial class frmChiTietSP : Form
    {
        public frmChiTietSP()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmDoUong.DoUong = null;
        }

        private void frmChiTietSP_Load(object sender, System.EventArgs e)
        {
            picSP.Image = MainFn.ByteArrayToImage(frmDoUong.DoUong.AnhSP);
            lblMaDoUong.Text = frmDoUong.DoUong.MaSP;
            lblTenDoUong.Text = frmDoUong.DoUong.TenSP;
            lblDonGiaS.Text = frmDoUong.DoUong.DonGia_S.ToString() + " VND";
            lblDonGiaM.Text = frmDoUong.DoUong.DonGia_M.ToString() + " VND";
            lblDonGiaL.Text = frmDoUong.DoUong.DonGia_L.ToString() + " VND";
        }
    }
}
