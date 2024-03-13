using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTW
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (cbNguoidung.Checked)
            {
                FTrangChu ftrangchu = new FTrangChu();
                ftrangchu.Show();
                this.Hide();
            }    
            if (cbKhachsan.Checked)
            {
                FChuKhachSan ftrangchu = new FChuKhachSan();
                ftrangchu.Show();
                this.Hide();
            }
            if (cbAdmin.Checked)
            {
                FQuanLyChung ftrangchu = new FQuanLyChung();
                ftrangchu.Show();
                this.Hide();
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            FTaoTaiKhoan fCreateAccount = new FTaoTaiKhoan();
            fCreateAccount.Show();
            this.Hide();
        }
    }
}
