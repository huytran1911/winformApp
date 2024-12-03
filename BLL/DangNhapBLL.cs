using DAL;

namespace BLL
{
    public class DangNhapBLL
    {
        private DangNhapDAL dangNhapDAL = new DangNhapDAL();

        // Kiểm tra đăng nhập
        public string Login(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                throw new ArgumentException("Tên đăng nhập và mật khẩu không được để trống.");
            }

            // Lấy quyền của người dùng
            string role = dangNhapDAL.GetUserRole(tenDangNhap, matKhau);
            if (role == null)
            {
                throw new UnauthorizedAccessException("Tên đăng nhập hoặc mật khẩu không chính xác.");
            }

            return role; // Trả về quyền: "Admin" hoặc "NV"
        }
    }
}
