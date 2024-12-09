﻿using BLL;
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
    public partial class GiaoDien : Form
    {
        public DangNhapDTO NguoiDungDangNhap { get; set; } // Đối tượng lưu thông tin người dùng đăng nhập

        
        private double tongtien = 0;
        DAL.BanDAL banDAL = new BanDAL();
        DataTable dataTable;
        DataTable danhSachMonHT;
        Dictionary<string, DataTable> danhSachMon = new Dictionary<string, DataTable>();
        Dictionary<string, Button> danhSachBan = new Dictionary<string, Button>();
        Dictionary<string, DataRow> table = new Dictionary<string, DataRow>();
        Dictionary<string, string> tenKhachHang = new Dictionary<string, string>();
        Button button;
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        private int SLB;
        private string userRole;
        public GiaoDien(string role)
        {
            InitializeComponent();
            userRole = role;
        }
        public GiaoDien()
        {
            InitializeComponent();

        }
        private void HienBan()
        {
            danhSachMon = new Dictionary<string, DataTable>();
            danhSachBan = new Dictionary<string, Button>();
            table = new Dictionary<string, DataRow>();
            panelBan.Controls.Clear();
            dataTable = banDAL.LoadBan();
            SLB = dataTable.Rows.Count;
            for (int i = 0; i < SLB; i++)
            {
                Button ban;
                DataTable mon;
                ban = new Button();
                mon = new DataTable();
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
                mon.Columns.Add(stt);
                mon.Columns.Add(thucDon);
                mon.Columns.Add(tenMon);
                mon.Columns.Add(sL);
                mon.Columns.Add(ghiChu);
                ban.Click += banso;
                ban.BackColor = Color.FloralWhite;
                ban.Text = (dataTable.Rows[i]["TenBan"]).ToString();
                ban.Width = 180;
                ban.Height = 110;
                ban.Image = new Bitmap("BanTrong.png");
                ban.TextImageRelation = TextImageRelation.ImageAboveText;

                panelBan.Controls.Add(ban);

                // Prevent duplicate keys
                if (!danhSachBan.ContainsKey(ban.Text))
                {
                    danhSachBan.Add(ban.Text, ban);
                }

                if (!danhSachMon.ContainsKey(ban.Text))
                {
                    danhSachMon.Add(ban.Text, mon);
                }

                if (!tenKhachHang.ContainsKey(ban.Text))
                {
                    tenKhachHang.Add(ban.Text, "");
                }

                if (!table.ContainsKey(ban.Text))
                {
                    table.Add(ban.Text, dataTable.Rows[i]);
                }
            }
        }
        private void PhanQuyenNguoiDung()
        {
            if (userRole == "NV")
            {
                // Ẩn các chức năng chỉ dành cho Admin
                danhSáchNhânViênToolStripMenuItem.Visible = false; // Ví dụ menu chỉ dành cho Admin
                menuToolStripMenuItem.Visible = false;
            }
            else if (userRole == "Admin")
            {
                danhSáchNhânViênToolStripMenuItem.Visible = true; // Ví dụ menu chỉ dành cho Admin
                menuToolStripMenuItem.Visible = true;
            }
        }

        private void HienThiThongTinNhanVien()
        {
            if (NguoiDungDangNhap != null)
            {
                tbNhanVien.Text = NguoiDungDangNhap.HoTen; // Hiển thị tên nhân viên

            }
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            HienThiThongTinNhanVien();
            PhanQuyenNguoiDung();
            HienBan();
            HoaDonDAL hoaDonDAL = new HoaDonDAL();
            List<HoaDonDTO> hoaDonList = hoaDonBLL.GetAllHoaDon();
            foreach (var item in hoaDonList)
            {
                MessageBox.Show($"Tên khách hàng: {item.TenKhachHang},Mã thực đơn {item.MaThucDon}, Thành tiền: {item.ThanhTien}");
            }

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



        }
        private void banso(object sender, EventArgs e)
        {
            try
            {
                button = (Button)sender;
                lbBan01.Text = button.Text;
                dgvThucDon.DataSource = danhSachMon[lbBan01.Text];
                danhSachMonHT = danhSachMon[lbBan01.Text];
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["TenBan"].ToString() == button.Text)
                    {
                        tbMaBan.Text = row["MaBan"].ToString();
                        break;
                    }
                }
                tbKhachHang.Text = tenKhachHang[button.Text];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xử lý bàn: " + ex.Message);
            }
        }
        private void tatca_click(object sender, EventArgs e)
        {
            panelBan.Controls.Clear();
            foreach (var button in danhSachBan)
            {
                panelBan.Controls.Add(button.Value);
            }

        }
        private void tangtret_click(object sender, EventArgs e)
        {
            panelBan.Controls.Clear();
            foreach (var button in danhSachBan)
            {
                if (table[button.Key]["MaKhuVuc"].ToString() == "KV01")
                {
                    panelBan.Controls.Add(danhSachBan[button.Key]);
                }
            }
        }
        private void tang1_click(object sender, EventArgs e)
        {
            panelBan.Controls.Clear();
            foreach (var button in danhSachBan)
            {
                if (table[button.Key]["MaKhuVuc"].ToString() == "KV02")
                {
                    panelBan.Controls.Add(danhSachBan[button.Key]);
                }
            }
        }
        private void tang2_click(object sender, EventArgs e)
        {
            panelBan.Controls.Clear();
            foreach (var button in danhSachBan)
            {
                if (table[button.Key]["MaKhuVuc"].ToString() == "KV03")
                {
                    panelBan.Controls.Add(danhSachBan[button.Key]);
                }
            }

        }
        private void btChonmon_Click(object sender, EventArgs e)
        {
            FrmChonMon frmChonMon = new FrmChonMon();
            frmChonMon.danhSachMon = danhSachMonHT;
            if(frmChonMon.ShowDialog()== DialogResult.OK)
            {
                button.Image = new Bitmap("hinh.png");
                TinhThanhTien();
                LuuThongTin();
            }
                    
        }

        private void btChinhsua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvThucDon.CurrentRow; // Lấy dòng hiện tại
                if (row == null) return;

                ThucDonBLL thucDon = new ThucDonBLL(
                    row.Cells[1].Value.ToString(),
                    int.Parse(row.Cells[3].Value.ToString()),
                    row.Cells[4].Value?.ToString() ?? ""
                );

                FrmChinhSuaThucDon frmChinhSuaThucDon = new FrmChinhSuaThucDon(thucDon);
                if (frmChinhSuaThucDon.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật giá trị trong DataGridView
                    row.Cells[3].Value = thucDon.SoLuong;
                    row.Cells[4].Value = thucDon.GhiChu;
                    TinhThanhTien();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉnh sửa lỗi: " + ex.Message);
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xóa không", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvThucDon.SelectedRows)
                {
                    dgvThucDon.Rows.Remove(row);
                }               
                if (dgvThucDon.Rows.Count == 1) {
                    button.Image = new Bitmap("BanTrong.png");
                }
                TinhThanhTien();
            }
        }
        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ban ban = new Ban();
            ban.ShowDialog();
            HienBan();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLMenu menu = new QLMenu();
            menu.ShowDialog();
        }
        public int TinhThanhTien()
        {
            int tongTien = 0;
            foreach (DataRow row in danhSachMonHT.Rows)
            {
                tongTien += int.Parse(row["SL"].ToString()) * int.Parse(row["Đơn Giá"].ToString());
            }
            tbThanhTien.Text = tongTien.ToString();
            return tongTien;
        }
        private void nhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbGiamGia_TextChanged(object sender, EventArgs e)
        {
            double giamGia;
            if (tbThanhTien.Text != "")
            {
                giamGia = double.Parse(tbThanhTien.Text) - (double.Parse(tbThanhTien.Text) * double.Parse(tbGiamGia.Text) / 100);
                tbThanhTien.Text = giamGia.ToString();

            }
        }

        private void tbPhuThu_TextChanged(object sender, EventArgs e)
        {
            double phuThu;
            if(tbThanhTien.Text != "")
            {
                phuThu = double.Parse(tbThanhTien.Text) + (double.Parse(tbThanhTien.Text) * double.Parse(tbGiamGia.Text) / 100);
                tbThanhTien.Text = phuThu.ToString();

            }
            
        }

        private void btThanhtoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var hoaDonDTO = new HoaDonDTO
                {
                    NgayVao = dtpNgayVao.Value,  // Đảm bảo dtpNgayVao là DateTimePicker
                    TenKhachHang = tbKhachHang.Text,  // Lấy tên khách hàng từ TextBox
                    MaNhanVien = tbNhanVien.Text,  // Lấy mã nhân viên từ TextBox
                    PhuThuTheoPhanTram = tbPhuThu.Text == "Phần trăm (%)",  // Kiểm tra nếu là "Phần trăm (%)"
                    GiamGiaTheoPhanTram = tbGiamGia.Text == "Phần trăm (%)",  // Kiểm tra nếu là "Phần trăm (%)"
                    NgayThanhToan = DateTime.Now,  // Ngày thanh toán là thời gian hiện tại
                    ThanhTien = decimal.TryParse(tbThanhTien.Text, out decimal thanhTien) ? thanhTien : 0,  // Kiểm tra giá trị thanh tiền và gán
                    DaThanhToan = true,  // Đã thanh toán
                    MaBan = int.Parse(tbMaBan.Text),
                };

                // Gọi BLL để xử lý thanh toán
                HoaDonBLL hoaDonBLL = new HoaDonBLL();
                bool result = hoaDonBLL.ThanhToan(hoaDonDTO);
                
                if (result)
                {
                    DataTable mon = new DataTable();
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                    mon.Columns.Add(stt);
                    mon.Columns.Add(thucDon);
                    mon.Columns.Add(tenMon);
                    mon.Columns.Add(sL);
                    mon.Columns.Add(ghiChu);

                    danhSachMon[lbBan01.Text] = mon;
                    dgvThucDon.DataSource = mon;
                    tbThanhTien.Text = "";
                    tbKhachHang.Text = "";
                    tenKhachHang[button.Text] =" ";
                    tbPhuThu.Text = "";
                    tbGiamGia.Text = "";
                    button.Image = new Bitmap("BanTrong.png");
                }
                else
                {
                    MessageBox.Show(hoaDonDTO.DaThanhToan.ToString());
                }

            }
        }
        private void LuuThongTin()
        {
            var hoaDonDTO = new HoaDonDTO
            {
                NgayVao = dtpNgayVao.Value,  // Đảm bảo dtpNgayVao là DateTimePicker
                TenKhachHang = tbKhachHang.Text,  // Lấy tên khách hàng từ TextBox
                MaNhanVien = tbNhanVien.Text,  // Lấy mã nhân viên từ TextBox
                PhuThuTheoPhanTram = tbPhuThu.Text == "Phần trăm (%)",  // Kiểm tra nếu là "Phần trăm (%)"
                GiamGiaTheoPhanTram = tbGiamGia.Text == "Phần trăm (%)",  // Kiểm tra nếu là "Phần trăm (%)"
                NgayThanhToan = DateTime.Now,  // Ngày thanh toán là thời gian hiện tại
                ThanhTien = decimal.TryParse(tbThanhTien.Text, out decimal thanhTien) ? thanhTien : 0,  // Kiểm tra giá trị thanh tiền và gán
                DaThanhToan = false,  // Chưa thanh toán
                MaBan = int.Parse(tbMaBan.Text),
            };
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            bool result = hoaDonBLL.ThanhToan(hoaDonDTO);

        }
        private void tbKhachHang_TextChanged(object sender, EventArgs e)
        {
            tenKhachHang[button.Text]=tbKhachHang.Text;
        }
    }
}
