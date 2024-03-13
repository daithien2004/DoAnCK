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
    public partial class FQuanLyChung : Form
    {
        public FQuanLyChung()
        {
            InitializeComponent();
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new UCAdminKhachSan());
        }

        private void btnKhachSan_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new UCAdminKhachSan());
        }

        private void btnNguoidung_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new UCAdminNguoiDung());
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FDangNhap fchild = new FDangNhap();
            fchild.Show();
            this.Hide();
        }
    }
}
