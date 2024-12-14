using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ThongKeDAL
    {
        private string connectionString = DB.connectionString;

        public DataTable LoadThongKe()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = " SELECT MaHoaDon, NgayVao, NgayThanhToan, ThanhTien, TenKhachHang, Maban,MaNhanVien  FROM HoaDon ";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                da.Dispose();

                return dt;
            }


        }
        public DataTable FilterThongKeByDate(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT MaHoaDon, NgayVao, NgayThanhToan, ThanhTien, TenKhachHang, Maban, MaNhanVien
            FROM HoaDon
            WHERE NgayVao >= @StartDate AND NgayThanhToan <= @EndDate";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                da.Dispose();

                return dt;
            }

        }
        public decimal CalculateTotalRevenueByMonth(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT SUM(ThanhTien) AS TotalRevenue
            FROM HoaDon
            WHERE MONTH(NgayThanhToan) = @Month AND YEAR(NgayThanhToan) = @Year";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Month", date.Month);
                cmd.Parameters.AddWithValue("@Year", date.Year);

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }
        public decimal CalculateTotalRevenueByDay(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT SUM(ThanhTien) AS TotalRevenue
            FROM HoaDon
            WHERE CAST(NgayThanhToan AS DATE) = @Date";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", date.Date); // Chỉ lấy phần ngày

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

    }
}

