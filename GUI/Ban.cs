using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public partial class Ban : Form
    {
        private BanBLL banBLL = new BanBLL();
        private BanDAL banDAL = new BanDAL();
        public Ban()
        {
            InitializeComponent();
            LoadData();

        }
        private void LoadData()
        {
            dgv_listBan.DataSource = banDAL.LayDanhSachBan();
        }
        private void Ban_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgv_listBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_listBan.Rows[e.RowIndex];
            tbTenBan.Text = row.Cells["TenBan"].Value.ToString();
            tbMaKhuVuc.Text = row.Cells["MaKhuVuc"].Value.ToString();
        }
        private void bt_add_Click(object sender, EventArgs e)
        {


            string tenBan = tbTenBan.Text;
            string maKhuVuc = tbMaKhuVuc.Text;
            
            if (banBLL.KiemTraThongTin(tenBan, maKhuVuc))
            {
                if (banDAL.ThemBan(tenBan, maKhuVuc))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ.");
            }


        }
            


        

        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_listBan.CurrentRow != null)
                {

                    // Lấy các giá trị khác từ giao diện
                    string tenBan = tbTenBan.Text;
                    string maKhuVuc = tbMaKhuVuc.Text;

                    // Kiểm tra thông tin hợp lệ
                    if (banBLL.KiemTraThongTin(tenBan, maKhuVuc))
                    {
                        // Lấy mã nhân viên từ DataGridView
                        string tenBanBD = dgv_listBan.CurrentRow.Cells["TenBan"].Value.ToString() ?? string.Empty;
                        string tenBanHT = tbTenBan.Text;

                        // Kiểm tra nếu mã nhân viên đã bị thay đổi
                        if (tenBanBD != tenBanHT)
                        {
                            MessageBox.Show("Tên bàn không được thay đổi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // Thực hiện cập nhật thông tin nhân viên
                        if (banDAL.SuaBan(tenBan, maKhuVuc))
                        {
                            MessageBox.Show("Sửa nhân bàn thành công!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi sửa bàn.");
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

        private void bt_clear_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_listBan.CurrentRow != null)
                {
                    string tenBan = dgv_listBan.CurrentRow.Cells["TenBan"].Value?.ToString() ?? string.Empty;
                    if (banDAL.XoaBan(tenBan))
                    {
                        MessageBox.Show("Xóa bàn thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa bàn.");
                    }
                }
            }
            catch 
            {
                
            }
        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            string tenBan = tb_find.Text.Trim(); // Lấy từ khóa người dùng nhập
            try
            {
                DataTable dt = banBLL.TimBan(tenBan); // Gọi phương thức BLL để tìm kiếm
                if (dt != null && dt.Rows.Count > 0)
                {
                    dgv_listBan.DataSource = dt; // Hiển thị kết quả tìm kiếm trên DataGridView
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn phù hợp!");
                    dgv_listBan.DataSource = null; // Xóa kết quả nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
