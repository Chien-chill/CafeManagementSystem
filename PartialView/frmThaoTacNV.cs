using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.PartialView
{
    public partial class frmThaoTacNV : Form
    {
        public frmThaoTacNV()
        {
            InitializeComponent();
        }
        public string MaMoi { get => txtMaNV.Text; set => txtMaNV.Text = value; }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                {
                    nv.TenNV = txtTenNV.Text;
                    nv.AnhNV = MainFn.ImageToByteArray(picNV.Image);
                    nv.SDT = txtSDT.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.CCCD = txtCCCD.Text;
                    nv.GioiTinh = (btnNam.Checked) ? "Nam" : "Nữ";
                    nv.NgaySinh = dtpNS.Text;
                }
                bool result = fn_NhanVienRespository.AddNhanVien(nv);
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
                NhanVien nv = new NhanVien();
                {
                    nv.MaNV = txtMaNV.Text;
                    nv.TenNV = txtTenNV.Text;
                    nv.AnhNV = MainFn.ImageToByteArray(picNV.Image);
                    nv.SDT = txtSDT.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.CCCD = txtCCCD.Text;
                    nv.GioiTinh = (btnNam.Checked) ? "Nam" : "Nữ";
                    nv.NgaySinh = dtpNS.Text;
                }
                bool result = fn_NhanVienRespository.UpdateNV(nv);
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
            frmNhanVien.nvSua = null;
            this.Close();
        }

        private void frmThaoTacNV_Load(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnSua.Visible = false;
            if (frmNhanVien.nvSua != null)
            {
                lblTieuDe.Text = "SỬA NHÂN VIÊN";
                btnThem.Visible = false;
                btnSua.Visible = true;
                txtMaNV.Text = frmNhanVien.nvSua.MaNV;
                txtTenNV.Text = frmNhanVien.nvSua.TenNV;
                txtDiaChi.Text = frmNhanVien.nvSua.DiaChi;
                txtSDT.Text = frmNhanVien.nvSua.SDT;
                txtCCCD.Text = frmNhanVien.nvSua.CCCD;
                picNV.Image = MainFn.ByteArrayToImage(frmNhanVien.nvSua.AnhNV);
                btnNam.Checked = MainFn.CompareString(frmNhanVien.nvSua.GioiTinh, "Nam");
                btnNu.Checked = MainFn.CompareString(frmNhanVien.nvSua.GioiTinh, "Nữ");
                string[] SplitNS = frmNhanVien.nvSua.NgaySinh.Split('/');
                DateTime NS = new DateTime(int.Parse(SplitNS[2]), int.Parse(SplitNS[1]), int.Parse(SplitNS[0]));
                dtpNS.Value = NS;
            }
        }

        private void picNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ảnh Sản Phẩm (*.jpg, *.png, *.jpeg)|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picNV.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
