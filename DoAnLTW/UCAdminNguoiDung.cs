using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace DoAnLTW
{
    public partial class UCAdminNguoiDung : UserControl
    {
        public UCAdminNguoiDung()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                UCNguoiDung uc = new UCNguoiDung();
                panel.Controls.Add(uc);
            }
        }
    }
}
