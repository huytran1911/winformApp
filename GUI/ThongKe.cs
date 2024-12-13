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

namespace GUI
{
    using BLL;
    using DTO;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class ThongKe : Form
    {

        public ThongKe()
        {
            InitializeComponent();
        }
        private ThongKeBLL thongkeBLL = new ThongKeBLL();

        private void LoadThongKe()
        {
            dgvThongKe.DataSource = thongkeBLL.GetAllThongKe();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
        }
    }

}
