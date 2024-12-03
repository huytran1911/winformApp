using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DangNhapDAL
    {
        private string connectionString = DB.connectionString;

        // Kiểm tra đăng nhập và lấy thông tin quyền (Admin hoặc NV)
        public string GetUserRole(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MaQuyen FROM NhanVien WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result?.ToString()?.Trim(); // Trả về MaQuyen hoặc null nếu không tìm thấy
            }
        }
    }
}
