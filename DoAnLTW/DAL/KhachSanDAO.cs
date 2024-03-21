using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnLTW.DTO;

namespace DoAnLTW.DAL
{
    public class KhachSanDAO : DbConnection
    {
        public KhachSan LayThongTinRieng(KhachSan ks)
        {
            OpenConnection();
            string query = "SELECT KhachSanID, TenKhachSan, DiaChi, TongQuan, Sao, TienNghi, HinhAnh, HinhThucThanhToan FROM KhachSan WHERE KhachSanID = @Id";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Id", ks.KhachSanID);              
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ks = new KhachSan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), 
                            reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));                                        
                    }
                }
            }
            CloseConnection();
            return ks;
        }

        public List<KhachSan> LayThongTinChung()
        {
            OpenConnection();
            string query = "SELECT KhachSanID, TenKhachSan, DiaChi, TongQuan, Sao, TienNghi, HinhAnh, HinhThucThanhToan FROM KhachSan";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<KhachSan> results = new List<KhachSan>();

                    while (reader.Read())
                    {
                        KhachSan ks = new KhachSan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                        results.Add(ks);
                    }
                    CloseConnection();
                    return results;
                }
            }
        }
        public List<KhachSan> TimKS(string key)
        {
            OpenConnection();
            List<KhachSan> list = new List<KhachSan>();
            string query = "SELECT * FROM KhachSan Where TenKhachSan LIKE @TenKhachSan";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@TenKhachSan", key + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    KhachSan ks = new KhachSan(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                    list.Add(ks);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            CloseConnection();
            return list;
        }
    }
}
