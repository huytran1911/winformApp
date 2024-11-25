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
            dgv_listBan.Columns[0].HeaderText = "Mã bàn";
            dgv_listBan.Columns[1].HeaderText = "Tên bàn";
            dgv_listBan.Columns[2].HeaderText = "Mã khu vực";
            dgv_listBan.Columns[3].HeaderText = "Tên khu vực";
            dgv_listBan.Columns[4].HeaderText = "Ghi chú";
            dgv_listBan.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            BanDTO ban = new BanDTO
            {
                MaBan = tbMaBan.Text,
                TenBan = tbTenBan.Text,
                MaKhuVuc = tbMaKhuVuc.Text
            };
            banBLL.Add(ban);
            LoadData();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            BanDTO ban = new BanDTO
            {
                MaBan = tbMaBan.Text,
                TenBan = tbTenBan.Text,
                MaKhuVuc = tbMaKhuVuc.Text
            };
            banBLL.Update(ban);
            LoadData();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            banBLL.Delete(tbMaBan.Text);
            LoadData();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            dgv_listBan.DataSource = banBLL.Search(tb_find.Text);
        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ban_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
