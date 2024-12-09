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
        public List<HoaDonDTO> GetHoaDonList()
        {
            List<HoaDonDTO> hoaDonList = new List<HoaDonDTO>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        HoaDon.NgayVao, 
                        HoaDon.TenKhachHang, 
                        HoaDon.MaNhanVien, 
                        HoaDon.PhuThuTheoPhanTram, 
                        HoaDon.GiamGiaTheoPhanTram, 
                        HoaDon.NgayThanhToan, 
                        HoaDon.ThanhTien, 
                        HoaDon.DaThanhToan, 
                        HoaDon.MaBan,
                        Mon.MaBill,
                        Mon.MaThucDon,
                        Mon.MaHoaDon,
                        Mon.SL,
                        Mon.GhiChu
                    FROM HoaDon,Mon
                    WHERE HoaDon.MaHoaDon = Mon.MaHoaDon
                    ";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HoaDonDTO hoaDon = new HoaDonDTO
                        {
                            NgayVao = reader.GetDateTime(reader.GetOrdinal("NgayVao")),
                            TenKhachHang = reader.GetString(reader.GetOrdinal("TenKhachHang")),
                            MaNhanVien = reader.GetString(reader.GetOrdinal("MaNhanVien")),
                            PhuThuTheoPhanTram = reader.GetBoolean(reader.GetOrdinal("PhuThuTheoPhanTram")),
                            GiamGiaTheoPhanTram = reader.GetBoolean(reader.GetOrdinal("GiamGiaTheoPhanTram")),
                            NgayThanhToan = reader.GetDateTime(reader.GetOrdinal("NgayThanhToan")),
                            ThanhTien = reader.GetDecimal(reader.GetOrdinal("ThanhTien")),
                            DaThanhToan = reader.GetBoolean(reader.GetOrdinal("DaThanhToan")),
                            MaBan = reader.GetInt32(reader.GetOrdinal("MaBan")),
                            MaBill = reader.GetInt32(reader.GetOrdinal("MaBill")),
                            MaThucDon = reader.GetString(reader.GetOrdinal("MaThucDon")),
                            MaHoaDon = reader.GetInt32(reader.GetOrdinal("MaHoaDon")),
                            SL = reader.GetInt32(reader.GetOrdinal("SL")),
                            GhiChu = reader.GetString(reader.GetOrdinal("GhiChu")),
                        };
                        hoaDonList.Add(hoaDon);
                    }
                }
            }
            return hoaDonList;
        }


    }
}
