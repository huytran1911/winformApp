using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        private ThongKeDAL thongkeDAL = new ThongKeDAL();

        public DataTable GetAllThongKe()
        {
            {
                return thongkeDAL.LoadThongKe();
            }

        }
        public DataTable FilterThongKeByDate(DateTime startDate, DateTime endDate)
        {
            return thongkeDAL.FilterThongKeByDate(startDate, endDate);
        }
        public decimal GetTotalRevenueByMonth(DateTime date)
        {
            return thongkeDAL.CalculateTotalRevenueByMonth(date);
        }
        public decimal GetTotalRevenueByDay(DateTime date)
        {
            return thongkeDAL.CalculateTotalRevenueByDay(date);
        }
        public decimal GetPreviousRevenueByMonth(DateTime date)
        {
            return thongkeDAL.CalculateTotalRevenueByMonth(date);
        }


    }


}
