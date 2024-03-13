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
    public partial class UCAdminKhachSan : UserControl
    {
        public UCAdminKhachSan()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                panel.Controls.Add(new UCKhachSan());
            }
            UCKhachSan uCHotel = new UCKhachSan();
            panel.Controls.Add(uCHotel);
        }
    }
}
