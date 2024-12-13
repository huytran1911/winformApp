using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeDTO
    {
        public int MaHoaDon { get; set; }
        public DateTime NgayVao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public decimal ThanhTien { get; set; }
        public string TenKhachHang { get; set; }
        public int Maban {  get; set; }
        public string MaNhanVien { get; set; }

        public ThongKeDTO() { }

        public ThongKeDTO(int maHoaDon, DateTime ngayVao, DateTime? ngayThanhToan, decimal thanhTien, string tenKhachHang, int maban, string maNhanVien)
        {
            MaHoaDon = maHoaDon;
            NgayVao = ngayVao;
            NgayThanhToan = ngayThanhToan;
            ThanhTien = thanhTien;
            TenKhachHang = tenKhachHang;
            Maban = maban;
            MaNhanVien = maNhanVien;
        }
    }

}
