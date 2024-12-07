using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        private HoaDonDAL hoaDonDAL;
        public HoaDonBLL()
        {
            hoaDonDAL = new HoaDonDAL();
        }
        public bool ThanhToan(HoaDonDTO hoaDonDTO)
        {
            return hoaDonDAL.HoaDon(hoaDonDTO);
        }
    }
}
