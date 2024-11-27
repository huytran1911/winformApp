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
    public class MenuBLL
    {
        private MenuDAL menuDAL = new MenuDAL();

        public DataTable GetAllMenu()
        {
            return menuDAL.LoadMenu();
        }

        public bool AddMenu(MenuDTO menu)
        {
            return menuDAL.InsertMenu(menu);
        }

        public bool EditMenu(MenuDTO menu)
        {
            return menuDAL.UpdateMenu(menu);
        }

        public bool RemoveMenu(string maThucDon)
        {
            return menuDAL.DeleteMenu(maThucDon);
        }
    }
}
