using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Phan_Mem_Quan_Ly
{
    public partial class frmTrangChu : Form
    {
        public static frmTrangChu Instance;
        public string MaNV { get => lblMaNV.Text; set => lblMaNV.Text = value; }
        public string TenNV { get => lblTenNV.Text; set => lblTenNV.Text = value; }
        public string ChucVu { get => lblChucVu.Text; set => lblChucVu.Text = value; }
        public Image AnhNV { get => pcbAnhNV.Image; set => pcbAnhNV.Image = value; }
        public frmTrangChu()
        {
            Instance = this;
            InitializeComponent();
        }
        private Dictionary<string, Form> frmDic = new Dictionary<string, Form>();
        private void loadfrm(string formName, Form f, bool refreshForm = false)
        {
            txtTimKiem.Visible = false;
            foreach (Control c in this.MainPanel.Controls)
            {
                if (c is Form)
                {
                    c.Hide();
                }
            }
            if (refreshForm && frmDic.ContainsKey(formName))
            {
                // Loại bỏ form cũ khỏi MainPanel và Dictionary
                Form oldForm = frmDic[formName];
                this.MainPanel.Controls.Remove(oldForm);
                frmDic.Remove(formName);
                oldForm.Dispose(); // Giải phóng tài nguyên
            }
            if (!frmDic.ContainsKey(formName))
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.MainPanel.Controls.Add(f);
                frmDic[formName] = f;
            }

            Form frm = frmDic[formName];
            frm.Show();
            if (formName == "BanHang" && frm is frmBanHang banHang)
            {
                txtTimKiem.Visible = true;
                txtTimKiem.IconRightClick += (sender, e) =>
                {
                    banHang.TimKiemSP(txtTimKiem.Text);
                };
                txtTimKiem.KeyDown += (sender, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        banHang.TimKiemSP(txtTimKiem.Text);
                    }
                };
                txtTimKiem.TextChanged += (sender, e) =>
                {
                    if (string.IsNullOrEmpty(txtTimKiem.Text))
                        banHang.TimKiemSP(txtTimKiem.Text);
                };
                banHang.btnThanhToan.Click += (sender, e) =>
                {
                    if (banHang.checkHD)
                    {
                        loadThongBao();
                    }
                };
                banHang.loadDanhMuc();
            }

            this.MainPanel.Tag = frm;
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            btnTrangChu_Click(sender, e);
            loadThongBao();
        }
        public void loadThongBao()
        {
            var lstHDChuaXuLy = fn_HoaDonRespository.GetHoaDonTheoTrangThai("Chưa Xác Nhận");
            if (lstHDChuaXuLy.Count > 0)
            {
                if (lstHDChuaXuLy.Count() > 99)
                {
                    notifPDonHang.Size = new Size(40, 22);
                }
                notifPDonHang.Visible = true;
                notifPDonHang.Text = lstHDChuaXuLy.Count.ToString("D2");
            }
            else
            {
                notifPDonHang.Visible = false;
            }
        }
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            loadfrm("BanHang", new frmBanHang());

        }

        private void btnNuocUong_Click(object sender, EventArgs e)
        {
            loadfrm("QLNhapSP", new frmNhapSP());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            loadfrm("QLDonHang", new frmDonHang(), true);
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            loadfrm("QLKhachHang", new frmQLKhachHang());
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            loadfrm("QLNhanVien", new frmQLNhanVien());
        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            loadfrm("ThongKe", new frmThongKe(), true);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            loadfrm("TrangChu", new frmHome(), true);
        }
    }
}
