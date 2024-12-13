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
    }
}

