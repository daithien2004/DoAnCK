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
    public partial class FThongTinDatPhong : Form
    {
        public FThongTinDatPhong()
        {
            InitializeComponent();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            FTrangChu fTrangChu = new FTrangChu();
            fTrangChu.Show();
            this.Hide();
        }

        private void btnCanhan_Click(object sender, EventArgs e)
        {
            if (!bunifuCards1.Visible) bunifuTransition1.ShowSync(bunifuCards1);
            else bunifuTransition1.HideSync(bunifuCards1);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FDangNhap fDangnhap = new FDangNhap();
            fDangnhap.Show();
            this.Hide();
        }

        private void btnThongtincanhan_Click(object sender, EventArgs e)
        {
            FThongTinCaNhan fthongtincanhan = new FThongTinCaNhan();
            fthongtincanhan.Show();
            this.Hide();
        }
    }
}
