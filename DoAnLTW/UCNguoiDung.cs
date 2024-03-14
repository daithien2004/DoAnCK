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
    public partial class UCNguoiDung : UserControl
    {
        public UCNguoiDung()
        {
            InitializeComponent();
        }

        private void UCNguoiDung_Click(object sender, EventArgs e)
        {
            FSuaNguoiDung form = new FSuaNguoiDung();
            form.ShowDialog();
        }

        private void UCNguoiDung_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UCNguoiDung_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }
    }
}
