using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnLTW.DTO;

namespace DoAnLTW.DAL
{
    public class PhongDAO : DbConnection
    {
        public List<Phong> LayThongTinChung()
        {
            OpenConnection();
            string query = "SELECT PhongID, KhachSanID, ThongTinChung, PhanLoai, TienNghi, Gia, " +
                "SucChua, SoGiuong DienTich, DSHinhAnh FROM Phong";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Phong> results = new List<Phong>();

                    while (reader.Read())
                    {
                        Phong phong = new Phong(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetString(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7), Convert.ToDecimal(1.2), "123");
                        results.Add(phong);
                    }
                    CloseConnection();
                    return results;
                }
            }
        }
    }
}
