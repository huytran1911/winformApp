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
    public class HoaDonDAL
    {
        private string connectionString = DB.connectionString;

        public bool HoaDon(HoaDonDTO hoaDonDTO)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO HoaDon (NgayVao,TenKhachHang, MaNhanVien, PhuThuTheoPhanTram, GiamGiaTheoPhanTram,NgayThanhToan,ThanhTien,DaThanhToan,MaBan) VALUES ( @NgayVao,@TenKhachHang, @MaNhanVien, @PhuThuTheoPhanTram, @GiamGiaTheoPhanTram,@NgayThanhToan,@ThanhTien,@DaThanhToan,@MaBan)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NgayVao", hoaDonDTO.NgayVao);
                cmd.Parameters.AddWithValue("@TenKhachHang", hoaDonDTO.TenKhachHang);
                cmd.Parameters.AddWithValue("@MaNhanVien", hoaDonDTO.MaNhanVien);
                cmd.Parameters.AddWithValue("@PhuThuTheoPhanTram", hoaDonDTO.PhuThuTheoPhanTram);
                cmd.Parameters.AddWithValue("@GiamGiaTheoPhanTram", hoaDonDTO.GiamGiaTheoPhanTram);
                cmd.Parameters.AddWithValue("@NgayThanhToan", hoaDonDTO.NgayThanhToan);
                cmd.Parameters.AddWithValue("@ThanhTien", hoaDonDTO.ThanhTien);
                cmd.Parameters.AddWithValue("@DaThanhToan", hoaDonDTO.DaThanhToan);
                cmd.Parameters.AddWithValue("@MaBan", hoaDonDTO.MaBan);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
