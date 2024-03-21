using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnLTW.DTO;
using DoAnLTW.DAL;

namespace DoAnLTW.DAL
{
    public class DatPhongDAO : DbConnection
    {
        public bool DatPhong(Phong phong, DateTime ngayDat, DateTime ngayTra)
        {
            string SQL = string.Format("INSERT INTO DatPhong(DatPhongID , PhongID, NguoiDungID, NgayDat, NgayTra, TrangThai, Gia) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')"
                    , "123", phong.PhongID, "ND001", ngayDat, ngayTra, "Dang cho", "1000");
            return ThucThi(SQL);
        }
    }
}
