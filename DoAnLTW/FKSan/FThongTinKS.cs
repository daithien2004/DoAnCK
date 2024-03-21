using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLTW.DAL;
using DoAnLTW.DTO;

namespace DoAnLTW
{
    public partial class FThongTinKS : Form
    {
        ResourceManager resourceManager = new ResourceManager("DoAnLTW.Properties.Resources", typeof(DoAnLTW.Properties.Resources).Assembly);
        KhachSanDAO khachSanDAO = new KhachSanDAO();
        PhongDAO phongDAO = new PhongDAO();
        KhachSan ks;
        public FThongTinKS()
        {
            InitializeComponent();
            LayThongTinKS();
            LayThongTinPhong();
        }

        public void LayThongTinKS()
        {
            // Lấy thông tin khách sạn
            ks = khachSanDAO.LayThongTinRieng(BienDungChung.idKSChon);
            lblTenKS.Text = ks.TenKhachSan;
            lblDiaChi.Text = ks.DiaChi;
            lblTienNghi.Text = ks.TienNghi;
            lblTongQuan.Text = ks.TongQuan;
            string[] listAnhs = ks.HinhAnh.Split(',');
            // Thêm vào imagelist
            foreach (string listAnh in listAnhs)
            {
                Image image = (Image)resourceManager.GetObject(listAnh);
                ilKS.Images.Add(image);
            }
        }
        List<UCDatPhong> listUCKS = new List<UCDatPhong>();
        public void LayThongTinPhong()
        {
            foreach (Phong phong in phongDAO.LayThongTinChung())
            {
                UCDatPhong uCDatPhong = new UCDatPhong();
                uCDatPhong.lblIDPhong.Text = phong.PhongID;
                uCDatPhong.lblSucChua.Text = phong.SucChua;
                uCDatPhong.lblDienTich.Text = Convert.ToString(phong.DienTich);
                uCDatPhong.lblSoGiuong.Text = phong.SoGiuong;
                uCDatPhong.lblTienNghi.Text = phong.TienNghi;
                listUCKS.Add(uCDatPhong);
                if (phong.KhachSanID == BienDungChung.idKSChon.KhachSanID)
                    pnlPhong.Controls.Add(uCDatPhong);
            }
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbKS.Image = ilKS.Images[count];
            count++;
            if (count > 1)
            {
                count = 0;
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            foreach (UCDatPhong ucDP in listUCKS)
            {
                if (ucDP.cbKS.Checked)
                    BienDungChung.idPhongChon = new Phong(ucDP.lblIDPhong.Text);
            }
            FDatPhong fDatPhong = new FDatPhong();
            fDatPhong.Show();
            this.Hide();
        }
    }
}
