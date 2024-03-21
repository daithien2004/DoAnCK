﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLTW.DTO;
using DoAnLTW.DAL;

namespace DoAnLTW
{
    public partial class UCTimKS : UserControl
    {
        KhachSanDAO khachSanDAO = new KhachSanDAO();
        public UCTimKS()
        {
            InitializeComponent();
        }

        public void ChiTiet(KhachSan ks)
        {
            lblTenKS.Text = ks.TenKhachSan;
            lblDiaChi.Text = ks.DiaChi;
        }
        public List<UCTimKS> TimKS(string key)
        {
            List<UCTimKS> listucKS = new List<UCTimKS>();
            List<KhachSan> ks = khachSanDAO.TimKS(key);
            foreach (KhachSan ks2 in ks)
            {
                UCTimKS ucKS = new UCTimKS();
                ucKS.lblTenKS.Text = ks2.TenKhachSan;
                ucKS.lblDiaChi.Text = ks2.DiaChi;
                listucKS.Add(ucKS);
            }       
            return listucKS;
        }

        private void UCTimKS_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }

        private void UCTimKS_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}