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


        public DataTable LayDanhSachMenu()
        {
            using (SqlConnection conn = new SqlConnection(DB.connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Menu", DB.connectionString);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataRow HangMenu(string maThucDon)
        {
            using (SqlConnection conn = new SqlConnection(DB.connectionString))
            {
         
                string query = "SELECT * FROM Menu WHERE MaThucDon = '" + maThucDon.ToString() +"'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt); conn.Close();

                da.Dispose();
                return dt.Rows[0];
            }
        }
        public DataTable Menu(string tenThucDon)
        {
            using (SqlConnection conn = new SqlConnection(DB.connectionString))
            {
                string query = "SELECT * FROM Menu WHERE TenThucDon = N'" + tenThucDon +"'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt); conn.Close();

                da.Dispose();
                return dt;
            }
        }
        public bool ThemMenu(string maThucDon,string tenThucDon,float gia)
        {
            using (SqlConnection conn = new SqlConnection(DB.connectionString))
            {
                string query = "INSERT INTO Menu (MaThucDon, TenThucDon, Gia) VALUES (@MaThucDon, @TenThucDon, @Gia)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
                cmd.Parameters.AddWithValue("@TenThucDon", tenThucDon);
                cmd.Parameters.AddWithValue("@Gia", gia);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        
        public bool SuaMenu(string maThucDon, string tenThucDon, float gia)
        {
            using (SqlConnection conn = new SqlConnection(DB.connectionString))
            {
                string query = "UPDATE Menu SET TenThucDon = @TenThucDon, Gia = @Gia WHERE MaThucDon = @MaThucDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
                cmd.Parameters.AddWithValue("@TenThucDon", tenThucDon);
                cmd.Parameters.AddWithValue("@Gia", gia);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        
        public bool XoaMenu(string maThucDon)
        {
            using (SqlConnection conn = new SqlConnection(DB.connectionString))
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