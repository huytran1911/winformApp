using DTO;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuDAL
    {
        private string connectionString = DB.connectionString;

        public DataTable LoadMenu()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Menu";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt); conn.Close();

                da.Dispose();
                return dt;
            }
        }

        public bool InsertMenu(MenuDTO menu)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Menu (MaThucDon, TenThucDon, Gia) VALUES (@MaThucDon, @TenThucDon, @Gia)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaThucDon", menu.MaThucDon);
                cmd.Parameters.AddWithValue("@TenThucDon", menu.TenThucDon);
                cmd.Parameters.AddWithValue("@Gia", menu.Gia);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateMenu(MenuDTO menu)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Menu SET TenThucDon = @TenThucDon, Gia = @Gia WHERE MaThucDon = @MaThucDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaThucDon", menu.MaThucDon);
                cmd.Parameters.AddWithValue("@TenThucDon", menu.TenThucDon);
                cmd.Parameters.AddWithValue("@Gia", menu.Gia);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteMenu(string maThucDon)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Menu WHERE MaThucDon = @MaThucDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}