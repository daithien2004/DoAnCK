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
    public partial class UCUser : UserControl
    {
        public UCUser()
        {
            InitializeComponent();
            this.MouseMove += UCUser_MouseMove;
            this.MouseLeave += UCUser_MouseLeave;
            this.Click += UCUser_Click;
        }

        private void UCUser_Click(object sender, EventArgs e)
        {
            FSuaNguoiDung form = new FSuaNguoiDung();
            form.ShowDialog();
        }

        private void UCUser_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UCUser_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }
    }
}
