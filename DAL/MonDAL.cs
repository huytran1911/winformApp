using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class MonDAL
    {
        private string connectionString = DB.connectionString;

        public DataTable LoadMenu()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Mon";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt); conn.Close();

                da.Dispose();
                return dt;
            }
        }
        public bool InsertMon(MonDTO mon)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Mon (MaThucDon,MaHoaDon,SL,GhiChu) VALUES (@MaThucDon,@MaHoaDon,@SL,@GhiChu)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaThucDon", mon.MaThucDon);
                cmd.Parameters.AddWithValue("@MaHoaDon", mon.MaHoaDon);
                cmd.Parameters.AddWithValue("@SL", mon.SL);
                cmd.Parameters.AddWithValue("@GhiChu", mon.GhiChu);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool UpdateMon(MonDTO mon)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Mon SET MaThucDon = @MaThucDon,MaHoaDon =@MaHoaDon,SL= @SL,GhiChu=@GhiChu WHERE MaHoaDon = @MaHoaDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaThucDon", mon.MaThucDon);
                cmd.Parameters.AddWithValue("@MaHoaDon", mon.MaHoaDon);
                cmd.Parameters.AddWithValue("@SL", mon.SL);
                cmd.Parameters.AddWithValue("@GhiChu", mon.GhiChu);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool DeleteMon(int maHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Mon WHERE MaHoaDon = @MaHoaDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
