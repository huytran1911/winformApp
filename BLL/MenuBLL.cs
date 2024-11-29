using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class MenuBLL
    {
        private MenuDAL menuDAL = new MenuDAL();

        public DataTable GetAllMenus()
        {
            return menuDAL.LoadMenu();
        }

        public bool AddMenu(MenuDTO menu)
        {
            return menuDAL.InsertMenu(menu);
        }

        public bool DeleteMenu(string maThucDon)
        {
            return menuDAL.DeleteMenu(maThucDon);
        }

        public bool UpdateMenu(MenuDTO menu)
        {
            return menuDAL.UpdateMenu(menu);
        }
    }
}