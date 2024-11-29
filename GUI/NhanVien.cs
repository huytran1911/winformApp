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

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string maNV = tbMaNhanVien.Text;
            string tenNV = tbTenNhanVien.Text;
            string diaChi = tbDiaChi.Text;
            string sdt = tbSDT.Text;
            string email = tbEmail.Text;
            string dangNhap = tbDangNhap.Text;
            string matKhau = tbMatKhau.Text;
            string maQuyen = tbMaQuyen.Text;

            if (nhanVienBLL.KiemTraThongTinHopLe(tenNV, diaChi, sdt, email, dangNhap, matKhau))
            {
                if (nhanVienDAL.ThemNhanVien(maNV, tenNV, diaChi, sdt, email, dangNhap, matKhau, maQuyen))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadData();
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
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachNhanVien.CurrentRow != null)
            {
                string maNV = dgvDanhSachNhanVien.CurrentRow.Cells["MaNhanVien"].Value?.ToString() ?? string.Empty;
                if (nhanVienDAL.XoaNhanVien(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên.");
                }
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachNhanVien.CurrentRow != null)
            {
                string maNV = dgvDanhSachNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString() ?? string.Empty;
                string tenNV = tbTenNhanVien.Text;
                string diaChi = tbDiaChi.Text;
                string sdt = tbSDT.Text;
                string email = tbEmail.Text;
                string dangNhap = tbDangNhap.Text;
                string matKhau = tbMatKhau.Text;
                string maQuyen = tbMaQuyen.Text;
                if (nhanVienBLL.KiemTraThongTinHopLe(tenNV, diaChi, sdt, email, dangNhap, matKhau))
                {
                    if (nhanVienDAL.SuaNhanVien(maNV, tenNV, diaChi, sdt, email, dangNhap, matKhau, maQuyen))
                    {
                        MessageBox.Show("Sửa nhân viên thành công!");
                        LoadData();
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
        private void btTimKiem_Click(object sender, EventArgs e)
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
        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvDanhSachNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = 0;
            i = dgvDanhSachNhanVien.CurrentRow.Index;
            tbMaNhanVien.Text = dgvDanhSachNhanVien.Rows[i].Cells[0].Value.ToString();
            tbTenNhanVien.Text = dgvDanhSachNhanVien.Rows[i].Cells[1].Value.ToString();
            tbDiaChi.Text = dgvDanhSachNhanVien.Rows[i].Cells[2].Value.ToString();
            tbSDT.Text = dgvDanhSachNhanVien.Rows[i].Cells[3].Value.ToString();
            tbEmail.Text = dgvDanhSachNhanVien.Rows[i].Cells[4].Value.ToString();
            tbDangNhap.Text = dgvDanhSachNhanVien.Rows[i].Cells[5].Value.ToString();
            tbMatKhau.Text = dgvDanhSachNhanVien.Rows[i].Cells[6].Value.ToString();
            tbMaQuyen.Text = dgvDanhSachNhanVien.Rows[i].Cells[7].Value.ToString();
        }

    }
}
