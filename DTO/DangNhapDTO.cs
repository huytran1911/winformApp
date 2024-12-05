namespace DTO
{
    public class DangNhapDTO
    {
        public string TenDangNhap { get; set; } // Tên đăng nhập của người dùng
        public string MatKhau { get; set; }     // Mật khẩu của người dùng
        public string MaQuyen { get; set; }    // Quyền truy cập (Admin, NV, ...)
        public string HoTen { get; set; }      // Họ tên của người dùng

        public DangNhapDTO(string tenDangNhap, string matKhau, string maQuyen, string hoTen)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            MaQuyen = maQuyen;
            HoTen = hoTen;
        }

        // Constructor chỉ với tên đăng nhập và mật khẩu
        public DangNhapDTO(string tenDangNhap, string matKhau, string maQuyen)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            MaQuyen = maQuyen;
        }

        // Constructor mặc định
        public DangNhapDTO() { }
    }
}
