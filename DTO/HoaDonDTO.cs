using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public Guid MaHD { get; set; } // uniqueidentifier
        public DateTime NgayVao { get; set; } // Ngày vào
        public string TenKhachHang { get; set; } // Tên khách hàng
        public string MaNhanVien { get; set; } // Mã nhân viên
        public decimal PhuThu { get; set; } // Phụ thu
        public bool PhuThuTheoPhanTram { get; set; } // Phụ thu theo phần trăm
        public decimal GiamGia { get; set; } // Giảm giá
        public bool GiamGiaTheoPhanTram { get; set; } // Giảm giá theo phần trăm
        public DateTime NgayThanhToan { get; set; } // Ngày thanh toán
        public decimal ThanhTien { get; set; } // Thành tiền
        public bool DaThanhToan { get; set; } // Đã thanh toán
        public int MaBan { get; set; } // Mã bàn


    }
}
