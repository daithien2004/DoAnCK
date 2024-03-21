using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTW.DTO
{
    public class Phong
    {
        private string phongID;
        private string khachSanID;
        private string thongTinChung;
        private string phanLoai;
        private string tienNghi;
        private int gia;
        private string sucChua;
        private string soGiuong;
        private decimal dienTich;
        private string dSHinhAnh;

        public Phong(string phongID)
        {
            this.phongID = phongID;
        }

        public Phong(string phongID, string khachSanID, string thongTinChung, string phanLoai, string tienNghi, 
            int gia, string sucChua, string soGiuong, decimal dienTich, string dSHinhAnh)
        {
            this.PhongID = phongID;
            this.KhachSanID = khachSanID;
            this.ThongTinChung = thongTinChung;
            this.PhanLoai = phanLoai;
            this.TienNghi = tienNghi;
            this.Gia = gia;
            this.SucChua = sucChua;
            this.SoGiuong = soGiuong;
            this.DienTich = dienTich;
            this.DSHinhAnh = dSHinhAnh;
        }

        public string PhongID { get => phongID; set => phongID = value; }
        public string KhachSanID { get => khachSanID; set => khachSanID = value; }
        public string ThongTinChung { get => thongTinChung; set => thongTinChung = value; }
        public string PhanLoai { get => phanLoai; set => phanLoai = value; }
        public string TienNghi { get => tienNghi; set => tienNghi = value; }
        public int Gia { get => gia; set => gia = value; }
        public string SucChua { get => sucChua; set => sucChua = value; }
        public string SoGiuong { get => soGiuong; set => soGiuong = value; }
        public decimal DienTich { get => dienTich; set => dienTich = value; }
        public string DSHinhAnh { get => dSHinhAnh; set => dSHinhAnh = value; }
    }
}
