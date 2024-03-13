using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTW
{
    public  class PhongKS
    {
        private string bookingid;
        private string khachid;
        private DateTime ngaydat;
        private DateTime ngayhuy;
        private string gia;
        private string tinhtrang;

        public PhongKS(string bookingid, string khachid, DateTime ngaydat, DateTime ngayhuy, string gia, string tinhtrang)
        {
            this.bookingid = bookingid;
            this.khachid = khachid;
            this.ngaydat = ngaydat;
            this.ngayhuy = ngayhuy;
            this.gia = gia;
            this.tinhtrang = tinhtrang;
        }

        public string Bookingid { get => bookingid; set => bookingid = value; }
        public string Khachid { get => khachid; set => khachid = value; }
        public DateTime Ngaydat { get => ngaydat; set => ngaydat = value; }
        public DateTime Ngayhuy { get => ngayhuy; set => ngayhuy = value; }
        public string Gia { get => gia; set => gia = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
    }
}
