using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using DTO;
using DAL;

namespace BLL
{
    public class FrmChonMonBLL
    {
        private DAL.FrmChonMonDAL frmChonMonDAL;
        public FrmChonMonBLL()
        {
            frmChonMonDAL = new FrmChonMonDAL();
        }
        public DataTable GetMenu()
        {
            return frmChonMonDAL.GetMenu();
        }
    }
}
