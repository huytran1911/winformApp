using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private int MaNhanVien { get; set; }
        private string TenNV { get; set; }
        private string DiaChi { get; set; }
        private string SDT {  get; set; }
        private string Email { get; set; }
        private string TenDangNhap { get; set; }
        private string MatKhau { get; set; }
        public NhanVien(int maNhanVien, string tenNV, string diaChi, string sDT, string email, string tenDangNhap, string matKhau)
        {
            MaNhanVien = maNhanVien;
            TenNV = tenNV;
            DiaChi = diaChi;
            SDT = sDT;
            Email = email;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }
    }
}
