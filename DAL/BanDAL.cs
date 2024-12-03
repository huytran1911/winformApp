using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class BanDAL
    {
        private SqlConnection connection;
        public BanDAL()
        {
            connection = new SqlConnection(DB.connectionString);
        }
        public DataTable LoadBan()
        {
            string query = "SELECT MaBan, TenBan, MaKhuVuc, (SELECT TenKhuVuc FROM KHUVUC WHERE KHUVUC.MaKhuVuc = Ban.MaKhuVuc) AS TenKhuVuc FROM Ban";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            adapter.Dispose();
            return table;
        }
        public bool Add(BanDTO ban)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                string query = "INSERT INTO Ban (TenBan,MaKhuVuc) VALUES ( @TenBan, @MaKhuVuc)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenBan", ban.TenBan);
                cmd.Parameters.AddWithValue("@MaKhuVuc", ban.MaKhuVuc);

                connection.Open();
                return cmd.ExecuteNonQuery() > 0;

            }


        }
        public bool Delete(string maBan)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                string query = "DELETE FROM Ban WHERE MaBan = @MaBan";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaBan", maBan);
                    

                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            
        }
        public bool Update(BanDTO ban)
        {
            using ( SqlConnection connection  = new SqlConnection(DB.connectionString))
            {
                string query = "UPDATE Ban SET TenBan = @TenBan, MaKhuVuc = @MaKhuVuc WHERE MaBan = @MaBan";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaBan", ban.MaBan);
                cmd.Parameters.AddWithValue("@TenBan", ban.TenBan);
                cmd.Parameters.AddWithValue("@MaKhuVuc", ban.MaKhuVuc);

            


                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            
        }

        public DataTable Search(string keyword)
        {
            string query = "SELECT MaBan, TenBan, MaKhuVuc, (SELECT TenKhuVuc FROM KHUVUC WHERE KHUVUC.MaKhuVuc = BAN.MaKhuVuc) AS TenKhuVuc FROM BAN WHERE MaBan LIKE @Keyword OR TenBan LIKE @Keyword OR MaKhuVuc LIKE @Keyword";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
