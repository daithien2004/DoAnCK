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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new UCUserAdmin());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new UCHotelAdmin());
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new UCDashboardAdmin());
        }
    }
}
