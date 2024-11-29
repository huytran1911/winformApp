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
        public DataTable GetAll()
        {
            string query = "SELECT MaBan, TenBan, MaKhuVuc, TenKhuVuc = (SELECT TenKhuVuc FROM KHUVUC WHERE KHUVUC.MaKhuVuc = Ban.MaKhuVuc), '' AS GhiChu FROM Ban";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public void Add(BanDTO ban)
        {
            string query = "INSERT INTO Ban VALUES (@MaBan, @TenBan, @MaKhuVuc)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@MaBan", ban.MaBan);
            cmd.Parameters.AddWithValue("@TenBan", ban.TenBan);
            cmd.Parameters.AddWithValue("@MaKhuVuc", ban.MaKhuVuc);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(string maBan)
        {
            string query = "DELETE FROM Ban WHERE MaBan = @MaBan";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@MaBan", maBan);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(BanDTO ban)
        {
            string query = "UPDATE Ban SET TenBan = @TenBan, MaKhuVuc = @MaKhuVuc WHERE MaBan = @MaBan";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@MaBan", ban.MaBan);
            cmd.Parameters.AddWithValue("@TenBan", ban.TenBan);
            cmd.Parameters.AddWithValue("@MaKhuVuc", ban.MaKhuVuc);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable Search(string keyword)
        {
            string query = "SELECT MaBan, TenBan, MaKhuVuc, TenKhuVuc = (SELECT TenKhuVuc FROM KHUVUC WHERE KHUVUC.MaKhuVuc = BAN.MaKhuVuc), '' AS GhiChu FROM BAN WHERE MaBan LIKE @Keyword OR TenBan LIKE @Keyword OR MaKhuVuc LIKE @Keyword";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
