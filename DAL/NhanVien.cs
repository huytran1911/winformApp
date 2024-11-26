using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace DAL
{
    public class NhanVien
    {  
        public DataTable LayDanhSachNhanVien()
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM NhanVien", DB.connectionString);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            } 
        }
        public DataTable TimNhanVien(string maNV, string tenNV)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString)) // Sử dụng phương thức kết nối từ lớp DB
            {
                try
                {
                    string TimKiem = " SELECT * FROM NhanVien WHERE MaNhanVien = @MaNhanVien OR TenNV LIKE '%' + @TenNV + '%'";
                    SqlCommand command = new SqlCommand(TimKiem, connection);

                    command.Parameters.AddWithValue("@MaNhanVien", maNV );
                    command.Parameters.AddWithValue("@TenNV",  tenNV);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Console.WriteLine(dt.ToString());
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi tìm kiếm nhân viên: " + ex.Message);
                    return null;
                }
            }
        }
        public bool ThemNhanVien(string maNV,string tenNV, string diaChi, string sdt, string email, string dangNhap, string matKhau,string maQuyen)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                string query = "INSERT INTO NhanVien VALUES (@MaNhanVien,@TenNV, @DiaChi, @SDT, @Email, @TenDangNhap, @MatKhau, @MaQuyen)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNhanVien", maNV);
                command.Parameters.AddWithValue("@TenNV", tenNV);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@SDT", sdt);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@TenDangNhap", dangNhap);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                command.Parameters.AddWithValue("@MaQuyen", maQuyen);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            
        } 
        public bool SuaNhanVien(string maNV, string tenNV, string diaChi, string sdt, string email, string dangNhap, string matKhau,string maQuyen)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString)) 
            {
                string query = "UPDATE NhanVien SET TenNV = @TenNV, DiaChi = @DiaChi, SDT = @SDT, Email = @Email, TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, MaQuyen = @MaQuyen WHERE MaNhanVien = @MaNhanVien";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNhanVien", maNV);
                command.Parameters.AddWithValue("@TenNV", tenNV);
                command.Parameters.AddWithValue("@DiaChi", diaChi);
                command.Parameters.AddWithValue("@SDT", sdt);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@TenDangNhap", dangNhap);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                command.Parameters.AddWithValue("@MaQuyen", maQuyen);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
        public bool XoaNhanVien(string maNV)
        {
            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                string query = "DELETE FROM NhanVien WHERE @MaNhanVien = MaNhanVien";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaNhanVien", maNV);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
