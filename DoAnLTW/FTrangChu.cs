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
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
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

        private void btnDondat_Click(object sender, EventArgs e)
        {
            FThongTinDatPhong fthongtindatphong = new FThongTinDatPhong();
            fthongtindatphong.Show();
            this.Hide();
        }

        private void btnCanhan_Click(object sender, EventArgs e)
        {
            if (!bunifuCards4.Visible) bunifuTransition1.ShowSync(bunifuCards4);
            else bunifuTransition1.HideSync(bunifuCards4);
        }

        private void btnChonkhachsan_Click(object sender, EventArgs e)
        {
            FKhachSan fkhachsan = new FKhachSan();
            fkhachsan.Show();
            this.Hide();
        }
    }
}
