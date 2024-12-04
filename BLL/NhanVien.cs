using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using DTO;
using DAL;

namespace BLL
{
    public class NhanVien
    {
        public bool KiemTraThongTinHopLe(string tenNV, string diaChi, string sdt, string email, string dangNhap, string matKhau)
        {
            if(string.IsNullOrWhiteSpace(tenNV)) return false;
            if (!Regex.IsMatch(sdt, @"^0\d{9}$")) return false;
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$")) return false;
            if (matKhau.Length < 6) return false;
            if (string.IsNullOrWhiteSpace(dangNhap) || string.IsNullOrWhiteSpace(matKhau)) return false;

            return true;
        }
        private DAL.NhanVien nhanVienDAL = new DAL.NhanVien();
        public DataTable TimNhanVien(string maNV, string tenNV)
        {
            if (string.IsNullOrWhiteSpace(maNV) && string.IsNullOrWhiteSpace(tenNV))
            {
                throw new ArgumentException("Từ khóa tìm kiếm không được để trống!");
            }

            return nhanVienDAL.TimNhanVien(maNV, tenNV);
        }
    }
}
