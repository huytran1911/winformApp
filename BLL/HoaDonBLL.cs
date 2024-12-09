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
        public bool AddHoaDon(HoaDonDTO hoaDonDTO)
        {
            // Add any business rules here if necessary
            return hoaDonDAL.HoaDon(hoaDonDTO);
        }

        public List<HoaDonDTO> GetAllHoaDon()
        {
            // Add any business rules here if necessary
            return hoaDonDAL.GetHoaDonList();
        }
    }
}
