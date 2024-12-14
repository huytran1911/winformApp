using System.Data;
using System.Text.RegularExpressions;
using DAL;
using DTO;

namespace BLL
{
    public class MenuBLL
    {
        private MenuDAL menuDAL = new MenuDAL();

        public DataTable GetAllMenus()
        {
            return menuDAL.LayDanhSachMenu();
        }
        public bool KiemTraThongTinHopLe(string maThucDon,string tenThucDon,float gia)
        {
            if (string.IsNullOrWhiteSpace(maThucDon)) return false;
            if (string.IsNullOrWhiteSpace(tenThucDon)) return false;
            if (gia <= 0 || float.IsNaN(gia)) return false;

            return true;
        }

    }
}