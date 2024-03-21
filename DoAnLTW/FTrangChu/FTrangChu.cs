using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DoAnLTW.DAL;
using DoAnLTW.DTO;

namespace DoAnLTW
{
    public partial class FTrangChu : Form
    {
        List<UCChonKS> listUCKS = new List<UCChonKS>();
        KhachSanDAO khachSanDAO = new KhachSanDAO();
        public FTrangChu()
        {
            InitializeComponent();
            foreach (KhachSan ks in khachSanDAO.LayThongTinChung())
            {
                UCChonKS uCChonKS = new UCChonKS();
                uCChonKS.lblIdKS.Text = ks.KhachSanID;
                uCChonKS.lblTenKS.Text = ks.TenKhachSan;
                listUCKS.Add(uCChonKS);
                pnlKS.Controls.Add(uCChonKS);
            }
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
            foreach (UCChonKS ucKS in listUCKS)
            {
                if (ucKS.cbKS.Checked)
                    BienDungChung.idKSChon = new KhachSan(ucKS.lblIdKS.Text);
            }    
            FKhachSan fkhachsan = new FKhachSan();
            fkhachsan.Show();
            this.Hide();
        }

        private void txtTimKS_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKS.TextLength >= 1)
            {
                UCTimKS uCTimKS = new UCTimKS();
                List<UCTimKS> listucTimKS = uCTimKS.TimKS(txtTimKS.Text);
                pnlKQTim.Controls.Clear();
                foreach (UCTimKS ucKS in listucTimKS)
                {
                    pnlKQTim.Controls.Add(ucKS);
                    pnlKQTim.Height = pnlKQTim.Controls.Count * 49;
                }
            }
            else
            {
                pnlKQTim.Height = 0;
            }
        }
    }
}
