using Phan_Mem_Quan_Ly.PartialView;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly
{
    public partial class ItemControl : UserControl
    {
        public ItemControl()
        {
            InitializeComponent();
        }
        public string TenSP { get => lblTenSP.Text; set => lblTenSP.Text = value; }
        public string DonGia_SP { get => lblDonGia.Text; set => lblDonGia.Text = value; }
        public string MaLoai { get; set; }
        public string DonGia_S { get; set; }
        public string DonGia_M { get; set; }
        public string DonGia_L { get; set; }
        public string GiamGia { get => lblGiamGia.Text; set => lblGiamGia.Text = value; }
        public bool SizeS { get => btnSizeS.Checked; set => btnSizeS.Checked = value; }
        public bool SizeM { get => btnSizeM.Checked; set => btnSizeM.Checked = value; }
        public bool SizeL { get => btnSizeL.Checked; set => btnSizeL.Checked = value; }
        public bool PnDonGia { get => pnDonGia.Visible; set => pnDonGia.Visible = value; }
        public (bool Visible, bool Enabled) PnSizeState
        {
            get => (PnSize.Visible, PnSize.Enabled);
            set
            {
                PnSize.Visible = value.Visible;
                PnSize.Enabled = value.Enabled;
            }
        }
        private void pnDonGia_Click(object sender, EventArgs e)
        {
            ItemControl_Click(sender, e);

        }

        private void pnTen_Click(object sender, EventArgs e)
        {
            ItemControl_Click(sender, e);
        }

        private void btnChecked_Click(object sender, EventArgs e)
        {
            ItemControl_Click(sender, e);
        }

        private void pnChecked_Click(object sender, EventArgs e)
        {
            ItemControl_Click(sender, e);
        }
        private void ItemControl_Load(object sender, EventArgs e)
        {
            btnChecked.Visible = false;
            pnChecked.BorderColor = Color.Transparent;
            int GiamGia = int.Parse(lblGiamGia.Text.Replace("%", ""));
            if (GiamGia > 0)
            {
                lblGiamGia.Visible = true;
            }
        }

        private void lblDonGia_Click(object sender, EventArgs e)
        {
            ItemControl_Click(sender, e);
        }


        public void ItemControl_Click(object sender, EventArgs e)
        {
            if (!btnSizeS.Checked && !btnSizeM.Checked && !btnSizeL.Checked)
            {
                ToastMSS toast = new ToastMSS("Hãy chọn size trước !", "INFO");
                toast.Show();
                return;
            }
            //if (!btnChecked.Visible)
            //{
            //    btnChecked.Visible = true;
            //    pnChecked.BorderColor = Color.Tomato;
            //}
            //else
            //{
            //    ItemControl_Load(sender, e);
            //}
        }

        private void btnSizeS_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(DonGia_S) != 0.0m)
            {
                if (!btnSizeS.Checked)
                {
                    if (btnSizeM.Checked == false && btnSizeL.Checked == false)
                    {
                        ItemControl_Load(sender, e);
                    }
                }
                else
                {
                    btnChecked.Visible = true;
                    pnChecked.BorderColor = Color.Tomato;
                }
            }
            else
            {
                btnSizeS.Checked = false;
            }
        }

        private void btnSizeM_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(DonGia_M) != 0.0m)
            {
                if (!btnSizeM.Checked)
                {
                    if (btnSizeS.Checked == false && btnSizeL.Checked == false)
                    {
                        ItemControl_Load(sender, e);
                    }
                }
                else
                {
                    btnChecked.Visible = true;
                    pnChecked.BorderColor = Color.Tomato;
                }
            }
            else
            {
                btnSizeM.Checked = false;
            }
        }

        private void btnSizeL_Click(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(DonGia_L) != 0.0m)
            {
                if (!btnSizeL.Checked)
                {
                    if (btnSizeS.Checked == false && btnSizeM.Checked == false)
                    {
                        ItemControl_Load(sender, e);
                    }
                }
                else
                {
                    btnChecked.Visible = true;
                    pnChecked.BorderColor = Color.Tomato;
                }
            }
            else
            {
                btnSizeL.Checked = false;
            }
        }


    }
}
