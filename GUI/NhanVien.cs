using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class NhanVien : Form
    {
        DAL.NhanVien nhanVienDAL = new DAL.NhanVien();
        BLL.NhanVien nhanVienBLL = new BLL.NhanVien();
        public NhanVien()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgvDanhSachNhanVien.DataSource = nhanVienDAL.LayDanhSachNhanVien();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        private void LoadNhanVien()
        {
            dgvDanhSachNhanVien.DataSource = nhanVienBLL.GetAllNhanVien();
            dgvDanhSachNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvDanhSachNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvDanhSachNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dgvDanhSachNhanVien.Columns[3].HeaderText = "Email";
            dgvDanhSachNhanVien.Columns[4].HeaderText = "Tên đăng nhập";
            dgvDanhSachNhanVien.Columns[5].HeaderText = "Mật khẩu";
            dgvDanhSachNhanVien.Columns[6].HeaderText = "Mã quyền";
        }
        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSachNhanVien.Rows[e.RowIndex];
            tbMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
            tbTenNhanVien.Text = row.Cells["TenNV"].Value.ToString();
            tbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            tbSDT.Text = row.Cells["SDT"].Value.ToString();
            tbEmail.Text = row.Cells["Email"].Value.ToString();
            tbDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
            tbMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            tbMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            tbMaQuyen.Text = row.Cells["MaQuyen"].Value.ToString();
        }
        private void ResetTextBoxes()
        {
            // Giả sử bạn có các TextBox: txtMaThucDon, txtTenThucDon, txtGia
            tbMaNhanVien.Clear();  
            tbTenNhanVien.Clear(); 
            tbDiaChi.Clear();
            tbSDT.Clear();
            tbEmail.Clear();
            tbDangNhap.Clear();
            tbMatKhau.Clear();
            tbMaQuyen.Clear();
        }
        private void bt_clear_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachNhanVien.CurrentRow != null)
                {
                    string maNV = dgvDanhSachNhanVien.CurrentRow.Cells["MaNhanVien"].Value?.ToString() ?? string.Empty;
                    if (nhanVienDAL.XoaNhanVien(maNV))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        LoadData();
                        ResetTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên.");
                    }
                }
            }
            catch { }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = tbMaNhanVien.Text;
                string tenNV = tbTenNhanVien.Text;
                string diaChi = tbDiaChi.Text;
                string sdt = tbSDT.Text;
                string email = tbEmail.Text;
                string dangNhap = tbDangNhap.Text;
                string matKhau = tbMatKhau.Text;
                string maQuyen = tbMaQuyen.Text;

                if (nhanVienBLL.KiemTraThongTinHopLe(tenNV, diaChi, sdt, email, dangNhap, matKhau, maQuyen))
                {
                    if (nhanVienDAL.ThemNhanVien(maNV, tenNV, diaChi, sdt, email, dangNhap, matKhau, maQuyen))
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");
                        LoadData();
                        ResetTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm nhân viên.");
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachNhanVien.CurrentRow != null)
                {


                    // Lấy các giá trị khác từ giao diện
                    string tenNV = tbTenNhanVien.Text;
                    string diaChi = tbDiaChi.Text;
                    string sdt = tbSDT.Text;
                    string email = tbEmail.Text;
                    string dangNhap = tbDangNhap.Text;
                    string matKhau = tbMatKhau.Text;
                    string maQuyen = tbMaQuyen.Text;

                    // Kiểm tra thông tin hợp lệ
                    if (nhanVienBLL.KiemTraThongTinHopLe(tenNV, diaChi, sdt, email, dangNhap, matKhau, maQuyen))
                    {
                        // Lấy mã nhân viên từ DataGridView
                        string maNVBanDau = dgvDanhSachNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString() ?? string.Empty;
                        string maNVHienTai = tbMaNhanVien.Text;

                        // Kiểm tra nếu mã nhân viên đã bị thay đổi
                        if (maNVBanDau != maNVHienTai)
                        {
                            MessageBox.Show("Mã nhân viên không được thay đổi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // Thực hiện cập nhật thông tin nhân viên
                        if (nhanVienDAL.SuaNhanVien(maNVBanDau, tenNV, diaChi, sdt, email, dangNhap, matKhau, maQuyen))
                        {
                            MessageBox.Show("Sửa nhân viên thành công!");
                            LoadData();
                            ResetTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi sửa nhân viên.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin không hợp lệ.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            string maNV = tbTimKiem.Text.Trim(); // Lấy từ khóa người dùng nhập
            string tenNV = tbTimKiem.Text.Trim();
            try
            {
                DataTable dt = nhanVienBLL.TimNhanVien(maNV, tenNV); // Gọi phương thức BLL để tìm kiếm
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvDanhSachNhanVien.DataSource = dt; // Hiển thị kết quả tìm kiếm trên DataGridView
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp!");
                    dgvDanhSachNhanVien.DataSource = null; // Xóa kết quả nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
