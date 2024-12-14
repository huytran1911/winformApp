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
            string query = "SELECT MaBan, TenBan, MaKhuVuc, (SELECT TenKhuVuc FROM KhuVuc WHERE KHUVUC.MaKhuVuc = Ban.MaKhuVuc) AS TenKhuVuc FROM Ban";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            adapter.Dispose();
            return table;
        }
        public DataTable LayDanhSachBan()
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Ban", DB.connectionString);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable TimBan(string tenBan)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString)) // Sử dụng phương thức kết nối từ lớp DB
            {
                try
                {
                    string TimKiem = " SELECT * FROM Ban WHERE TenBan = @TenBan ";
                    SqlCommand command = new SqlCommand(TimKiem, connection);

                    command.Parameters.AddWithValue("@TenBan", tenBan);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Console.WriteLine(dt.ToString());
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi tìm kiếm bàn " + ex.Message);
                    return null;
                }
            }
        }
        public bool ThemBan(string tenBan, string maKhuVuc)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                string query = "INSERT INTO  VALUES ( @TenBan, @MaKhuVuc)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenBan", tenBan);
                cmd.Parameters.AddWithValue("@MaKhuVuc", maKhuVuc);
                connection.Open();
                return cmd.ExecuteNonQuery() > 0;

            }
        }
        public bool SuaBan(string tenBan, string maKhuVuc)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                string query = "UPDATE Ban SET TenBan = @TenBan, MaKhuVuc = @MaKhuVuc WHERE MaBan = @MaBan";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenBan", tenBan);
                cmd.Parameters.AddWithValue("@MaKhuVuc", maKhuVuc);




                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }

        }
        

        public bool CheckTenBan(string tenBan)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                string query = "SELECT COUNT(*) FROM Ban WHERE TenBan = @TenBan";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenBan", tenBan);

                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public bool XoaBan(string tenBan)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                string query = "DELETE FROM Ban WHERE TenBan = @TenBan";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenBan", tenBan);


                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }

        }
    }
}
