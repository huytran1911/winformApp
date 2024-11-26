using BLL;
using DAL;
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
    public partial class GiaoDien : Form
    {
        private Button[] ban;
        private DataTable[] danhSachMon;
        private double tongtien = 0;
        DAL.BanDAL banDAL = new BanDAL();
        DataTable dataTable;
        DataTable danhSachMonHT;
        private int SLB;
        public GiaoDien()
        {
            InitializeComponent();
        }
        private void GiaoDien_Load(object sender, EventArgs e)
        {
            dataTable = banDAL.GetAll();
            SLB = dataTable.Rows.Count;
            ban = new Button[SLB];
            danhSachMon = new DataTable[SLB];
            Button tatca = new Button();
            tatca.Text = "Tất cả";
            tatca.BackColor = Color.Bisque;
            tatca.Width = 174;
            tatca.Height = 47;
            tatca.Click += tatca_click;
            Button tangtret = new Button();
            tangtret.Text = "Tầng trệt";
            tangtret.BackColor = Color.Bisque;
            tangtret.Width = 174;
            tangtret.Height = 47;
            tangtret.Click += tangtret_click;
            Button tang1 = new Button();
            tang1.Text = "Tầng 1";
            tang1.BackColor = Color.Bisque;
            tang1.Width = 174;
            tang1.Height = 47;
            tang1.Click += tang1_click;
            Button tang2 = new Button();
            tang2.Text = "Tầng 2";
            tang2.BackColor = Color.Bisque;
            tang2.Width = 174;
            tang2.Height = 47;
            tang2.Click += tang2_click;
            panelKhuVuc.Controls.Add(tatca);
            panelKhuVuc.Controls.Add(tangtret);
            panelKhuVuc.Controls.Add(tang1);
            panelKhuVuc.Controls.Add(tang2);

            for (int i = 0; i < ban.Length; i++)
            {
                ban[i] = new Button();
                danhSachMon[i] = new DataTable();
                DataColumn stt = new DataColumn("STT");
                DataColumn thucDon = new DataColumn("Thực Đơn");
                DataColumn tenMon = new DataColumn("Đơn Giá");
                DataColumn sL = new DataColumn("SL");
                DataColumn ghiChu = new DataColumn("Ghi Chú");
                stt.DataType = typeof(int);
                thucDon.DataType = typeof(string);
                tenMon.DataType = typeof(string);
                sL.DataType = typeof(int);
                ghiChu.DataType = typeof(string);
                ban[i].Click += banso;
                ban[i].BackColor = Color.FloralWhite;
                ban[i].Text = "Bàn số " + (i + 1).ToString();
                ban[i].Width = 180;
                ban[i].Height = 110;
                ban[i].Image = new Bitmap("BanTrong.png");
                ban[i].TextImageRelation = TextImageRelation.ImageAboveText;
                danhSachMon[i].Columns.Add(stt);
                danhSachMon[i].Columns.Add(thucDon);
                danhSachMon[i].Columns.Add(tenMon);
                danhSachMon[i].Columns.Add(sL);
                danhSachMon[i].Columns.Add(ghiChu);
                panelBan.Controls.Add(ban[i]);
            }

            cbGiamGia.SelectedIndex = 0;
            cbPhuThu.SelectedIndex = 0;
        }
        private void banso(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            lbBan01.Text = button.Text;
            int soBan = int.Parse(lbBan01.Text.Substring(lbBan01.Text.Length - 1));
            dgvThucDon.DataSource = danhSachMon[soBan - 1];
            danhSachMonHT = danhSachMon[soBan - 1];
        }
        private void tatca_click(object sender, EventArgs e)
        {
            panelBan.Controls.Clear();
            for (int i = 0; i < SLB; i++)
            {
                panelBan.Controls.Add(ban[i]);
            }

        }
        private void tangtret_click(object sender, EventArgs e)
        {
            panelBan.Controls.Clear();
            for (int i = 0; i < SLB; i++)
            {
                if (dataTable.Rows[i]["MaKhuVuc"].ToString() == "KV01")
                {
                    panelBan.Controls.Add(ban[i]);
                }
            }

        }
        private void tang1_click(object sender, EventArgs e)
        {
            panelBan.Controls.Clear();
            for (int i = 0; i < SLB; i++)
            {
                if (dataTable.Rows[i]["MaKhuVuc"].ToString() == "KV02")
                {
                    panelBan.Controls.Add(ban[i]);
                }
            }

        }
        private void tang2_click(object sender, EventArgs e)
        {
            panelBan.Controls.Clear();
            for (int i = 0; i < SLB; i++)
            {
                if (dataTable.Rows[i]["MaKhuVuc"].ToString() == "KV03")
                {
                    panelBan.Controls.Add(ban[i]);

                }
            }

        }
        private void btChonmon_Click(object sender, EventArgs e)
        {
            FrmChonMon frmChonMon = new FrmChonMon();
            frmChonMon.danhSachMon = danhSachMonHT;
            frmChonMon.ShowDialog();
        }

        private void btChinhsua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvThucDon.CurrentRow; // Lấy dòng hiện tại
                if (row == null) return;

                ThucDonBLL thucDon = new ThucDonBLL(
                    row.Cells[2].Value.ToString(),
                    int.Parse(row.Cells[3].Value.ToString()),
                    row.Cells[4].Value?.ToString() ?? ""
                );

                FrmChinhSuaThucDon frmChinhSuaThucDon = new FrmChinhSuaThucDon(thucDon);
                if (frmChinhSuaThucDon.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật giá trị trong DataGridView
                    row.Cells[3].Value = thucDon.SoLuong;
                    row.Cells[4].Value = thucDon.GhiChu;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉnh sửa lỗi: " + ex.Message);
            }
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ban ban = new Ban();
            ban.ShowDialog();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.ShowDialog();
        }
    }
}
