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
    public partial class UCKhachSan : UserControl
    {
        public UCKhachSan()
        {
            InitializeComponent();
        }

        private void UCKhachSan_Click(object sender, EventArgs e)
        {
            FSuaThongTinKS fKS = new FSuaThongTinKS();
            fKS.ShowDialog();
        }

        private void UCKhachSan_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UCKhachSan_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }
    }
}
