using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.PartialView
{
    public partial class frmThaoTac : Form
    {
        public frmThaoTac()
        {
            InitializeComponent();
        }
        public string MaMoi { get => txtMaSP.Text; set => txtMaSP.Text = value; }
        public string frmCall { get; set; }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDoUong.DoUong = null;
            frmDoAn.DoAn = null;
            this.Close();
        }
        private void frmThaoTac_Load(object sender, EventArgs e)
        {
            btnThem.Visible = true;
            btnSua.Visible = false;
            txtTenSP.Focus();
            if (frmCall.Equals("DoUong"))
            {
                lblTieuDe.Text = "THÊM ĐỒ UỐNG";
                if (frmDoUong.DoUong != null)
                {
                    btnThem.Visible = false;
                    btnSua.Visible = true;
                    lblTieuDe.Text = "SỬA ĐỒ UỐNG";
                    txtMaSP.Text = frmDoUong.DoUong.MaSP;
                    txtTenSP.Text = frmDoUong.DoUong.TenSP;
                    picSP.Image = MainFn.ByteArrayToImage(frmDoUong.DoUong.AnhSP);
                    txtDonGiaS.Text = frmDoUong.DoUong.DonGia_S.ToString();
                    txtDonGiaM.Text = frmDoUong.DoUong.DonGia_M.ToString();
                    txtDonGiaL.Text = frmDoUong.DoUong.DonGia_L.ToString();
                }
            }
            else if (frmCall.Equals("DoAn"))
            {
                pcTieuDe.Image = Phan_Mem_Quan_Ly.Properties.Resources.icons8_strawberry_cheesecake_50_hover;
                lblTieuDe.Text = "Thêm Đồ Ăn Nhẹ";
                lblMaSP.Text = "Mã Đồ Ăn";
                lblTenSP.Text = "Tên Đồ Ăn";
                lblDonGia.Visible = txtDonGia.Visible = true;
                txtDonGiaS.Visible = txtDonGiaL.Visible = txtDonGiaM.Visible = btnSizeS.Visible = btnSizeM.Visible = btnSizeL.Visible = false;
                lblMoTa.Location = new Point(32, 396);
                txtMoTa.Location = new Point(195, 388);
                if(frmDoAn.DoAn !=null)
                {
                    btnThem.Visible = false;
                    btnSua.Visible = true;
                    lblTieuDe.Text = "SỬA ĐỒ ĂN";
                    txtMaSP.Text = frmDoAn.DoAn.MaSP;
                    txtTenSP.Text = frmDoAn.DoAn.TenSP;
                    txtDonGia.Text = frmDoAn.DoAn.DonGia_SP.ToString();
                    picSP.Image = MainFn.ByteArrayToImage(frmDoAn.DoAn.AnhSP);
                }

            }
        }
        private void btnDuyetAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ảnh Sản Phẩm (*.jpg, *.png, *.jpeg)|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picSP.Image = new Bitmap(ofd.FileName);
            }
        }
        private readonly Image DefaultImage = Phan_Mem_Quan_Ly.Properties.Resources.icons8_image_96;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = new SanPham();
                {
                    sp.TenSP = txtTenSP.Text;
                    sp.AnhSP = MainFn.ImageToByteArray(picSP.Image);
                    sp.MoTaSP = txtMoTa.Text;
                    sp.DonGia_S = (string.IsNullOrEmpty(txtDonGiaS.Text)) ? 0 : decimal.Parse(txtDonGiaS.Text);
                    sp.DonGia_M = (string.IsNullOrEmpty(txtDonGiaM.Text)) ? 0 : decimal.Parse(txtDonGiaM.Text);
                    sp.DonGia_L = (string.IsNullOrEmpty(txtDonGiaL.Text)) ? 0 : decimal.Parse(txtDonGiaL.Text);
                    sp.DonGia_SP = (string.IsNullOrEmpty(txtDonGia.Text))?0:decimal.Parse(txtDonGia.Text);
                    sp.MaLoai = (frmCall.Equals("DoUong"))?"ML01":"ML02";
                }
                if (MainFn.CompareImages(picSP.Image, DefaultImage) || picSP.Image == null)
                {
                    Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    Mss.Show($"Ảnh không được để trống");
                }
                else
                {
                    if (!SanPham.KiemTraSP(sp, out string errorMessage))
                    {
                        Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                        Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                        Mss.Show($"Thêm thất bại: \n{errorMessage}");
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        bool result = fn_SanPhamRespository.AddSanPham(sp);
                        if (result)
                        {
                            Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            Mss.Show("Thêm thành công");
                        }
                        else
                        {
                            Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            Mss.Show("Thêm thất bại ở SQL");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
                var sp = new SanPham();
                {
                    sp.MaSP = txtMaSP.Text;
                    sp.TenSP = txtTenSP.Text;
                    sp.AnhSP = MainFn.ImageToByteArray(picSP.Image);
                    sp.MoTaSP = txtMoTa.Text;
                    sp.DonGia_S = (string.IsNullOrEmpty(txtDonGiaS.Text)) ? 0 : decimal.Parse(txtDonGiaS.Text);
                    sp.DonGia_M = (string.IsNullOrEmpty(txtDonGiaM.Text)) ? 0 : decimal.Parse(txtDonGiaM.Text);
                    sp.DonGia_L = (string.IsNullOrEmpty(txtDonGiaL.Text)) ? 0 : decimal.Parse(txtDonGiaL.Text);
                    sp.DonGia_SP = (string.IsNullOrEmpty(txtDonGia.Text)) ? 0 : decimal.Parse(txtDonGia.Text);
                    sp.MaLoai = (frmCall.Equals("DoUong")) ? "ML01" : "ML02";
                }
                    if (!SanPham.KiemTraSP(sp, out string errorMessage))
                    {
                        Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                        Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                        Mss.Show($"Sửa thất bại: \n{errorMessage}");
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        bool result = fn_SanPhamRespository.UpdateSanPham(sp);
                        frmDoUong.DoUong = null;
                        frmDoAn.DoAn = null;
                        if (result)
                        {
                            Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            Mss.Show("Sửa thành công");
                        }
                        else
                        {
                            Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            Mss.Show("Sửa thất bại");
                        }
                    }
          
        }



        private void btnSizeS_Click(object sender, EventArgs e)
        {
            if (btnSizeS.Checked)
            {
                txtDonGiaS.Enabled = true;
            }
            else
            {
                txtDonGiaS.Enabled = false;
                txtDonGiaS.Text = "";
            }
        }

        private void btnSizeM_Click(object sender, EventArgs e)
        {
            if (btnSizeM.Checked)
            {
                txtDonGiaM.Enabled = true;
            }
            else
            {
                txtDonGiaM.Enabled = false;
                txtDonGiaM.Text = "";
            }
        }

        private void btnSizeL_Click(object sender, EventArgs e)
        {
            if (btnSizeL.Checked)
            {
                txtDonGiaL.Enabled = true;
            }
            else
            {
                txtDonGiaL.Enabled = false;
                txtDonGiaL.Text = "";
            }
        }


    }
}
