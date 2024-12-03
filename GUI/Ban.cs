using BLL;
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
        public Ban()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgv_listBan.DataSource = banBLL.GetAll();
            dgv_listBan.Columns[1].HeaderText = "Tên bàn";
            dgv_listBan.Columns[2].HeaderText = "Mã khu vực";
            dgv_listBan.Columns[3].HeaderText = "Tên khu vực";
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
            BanDTO ban = new BanDTO(tbTenBan.Text, tbMaKhuVuc.Text);
            if(banBLL.Add(ban))
            {
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");

            }
            
            LoadData();


        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            BanDTO ban = new BanDTO(tbTenBan.Text, tbMaKhuVuc.Text);
            if (banBLL.Update(ban))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất công");
            }

            LoadData();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            if (banBLL.Delete(tbTenBan.Text))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            LoadData();
        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        
    }
}
