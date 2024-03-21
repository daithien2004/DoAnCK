using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLTW.DAL;
using DoAnLTW.DTO;

namespace DoAnLTW
{
    public partial class FDatPhong : Form
    {
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        public FDatPhong()
        {
            InitializeComponent();
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            datPhongDAO.DatPhong(BienDungChung.idPhongChon, dtNgayDat.Value, dtNgayTra.Value);
        }
    }
}
