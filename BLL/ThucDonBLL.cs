using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThucDonBLL
    {
        public string TenMon { get; set; }
        public string GhiChu { get; set; }
        public int SoLuong { get; set; }

        // Constructor để khởi tạo thông tin món ăn
        public ThucDonBLL(string tenMon, int soLuong, string ghiChu)
        {
            TenMon = tenMon;
            SoLuong = soLuong;
            GhiChu = ghiChu;
        }
        public void CapNhatThongTin(string soLuong, string ghiChu)
        {
            if (int.TryParse(soLuong, out int sl))
            {
                SoLuong = sl;
                GhiChu = ghiChu;
            }
            else
            {
                throw new FormatException("Số lượng không hợp lệ.");
            }
        }
    }
}
