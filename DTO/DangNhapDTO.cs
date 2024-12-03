namespace DTO
{
    public class DangNhapDTO
    {
        public string TenDangNhap { get; set; } // Tên đăng nhập của người dùng
        public string MatKhau { get; set; }     // Mật khẩu của người dùng
        public string MaQuyen { get; set; }    // Quyền truy cập (Admin, NV, ...)

        public DangNhapDTO(string tenDangNhap, string matKhau, string maQuyen)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            MaQuyen = maQuyen;
        }

        // Constructor chỉ có tên đăng nhập và mật khẩu (nếu không cần quyền)
        public DangNhapDTO(string tenDangNhap, string matKhau)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }

        // Constructor mặc định
        public DangNhapDTO() { }
    }
}
