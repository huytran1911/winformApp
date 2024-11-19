using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using DTO;
namespace DAL
{
    public class FrmChonMonDAL
    {
        public DataTable GetMenu()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(DB.connectiongString))
            {
                string query = "SELECT * FROM Menu";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public void UpdateThucDon(DTO.FrmChonMonDTO menu)
        {
            // Đảm bảo rằng có dữ liệu trước khi thực hiện cập nhật
            if (menu == null)
            {
                throw new ArgumentException("Món ăn không hợp lệ.");
            }

            using (SqlConnection conn = new SqlConnection(DB.connectiongString))
            {
                string query = "UPDATE ThucDon SET TenMon = @TenMon, Gia = @Gia, SoLuong = @SoLuong, GhiChu = @GhiChu WHERE MaMon = @MaMon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMon", menu.MaMon);
                cmd.Parameters.AddWithValue("@TenMon", menu.TenMon);
                cmd.Parameters.AddWithValue("@Gia", menu.Gia);
                cmd.Parameters.AddWithValue("@SoLuong", menu.SoLuong);
                cmd.Parameters.AddWithValue("@GhiChu", menu.GhiChu);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
