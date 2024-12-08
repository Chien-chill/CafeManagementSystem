using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.PartialView
{
    public partial class frmThaoTacKH : Form
    {
        public frmThaoTacKH()
        {
            InitializeComponent();
        }
        public string MaMoi { get => txtMaKH.Text; set => txtMaKH.Text = value; }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();
                {
                    kh.TenKH = txtTenKH.Text;
                    kh.SDT = txtSDT.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.GioiTinh = (btnNam.Checked) ? "Nam" : "Nữ";
                    kh.NgaySinh = dtpNS.Text;
                }
                bool result = fn_KhachHangRespository.AddKhachHang(kh);
                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    Mss.Show("Thêm thất bại ở SQL");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();
                {
                    kh.MaKH = txtMaKH.Text;
                    kh.TenKH = txtTenKH.Text;
                    kh.SDT = txtSDT.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.GioiTinh = (btnNam.Checked) ? "Nam" : "Nữ";
                    kh.NgaySinh = dtpNS.Text;
                }
                bool result = fn_KhachHangRespository.UpdateKH(kh);
                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    Mss.Show("Sửa thất bại");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Sửa: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmKhachHang.khSua = null;
            this.Close();
        }

        private void frmThaoTacKH_Load(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnSua.Visible = false;
            if (frmKhachHang.khSua != null)
            {
                lblTieuDe.Text = "SỬA KHÁCH HÀNG";
                btnThem.Visible = false;
                btnSua.Visible = true;
                txtMaKH.Text = frmKhachHang.khSua.MaKH;
                txtTenKH.Text = frmKhachHang.khSua.TenKH;
                txtDiaChi.Text = frmKhachHang.khSua.DiaChi;
                txtSDT.Text = frmKhachHang.khSua.SDT;
                btnNam.Checked = MainFn.CompareString(frmKhachHang.khSua.GioiTinh, "Nam");
                btnNu.Checked = MainFn.CompareString(frmKhachHang.khSua.GioiTinh, "Nữ");
                string[] SplitNS = frmKhachHang.khSua.NgaySinh.Split('/');
                DateTime NS = new DateTime(int.Parse(SplitNS[2]), int.Parse(SplitNS[1]), int.Parse(SplitNS[0]));
                dtpNS.Value = NS;
            }
        }
    }
}
