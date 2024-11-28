using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            pnDK.Visible = false;
            pnDN.Visible = true;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            pnDK.Visible = true;
            pnDN.Visible = false;
        }

        private void btnDK1_Click(object sender, EventArgs e)
        {
            pnDK.Visible = true;
            pnDN.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnDK.Visible = false;
            pnDN.Visible = true;
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            pnDK.Visible = false;
            pnDN.Visible = true;
        }
    }
}
