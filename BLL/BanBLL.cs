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
    public class BanBLL
    {
        private BanDAL banDAL = new BanDAL();

        public bool KiemTraThongTin(string tenBan,string tenKhuVuc)
        {
            if (string.IsNullOrWhiteSpace(tenBan)) return false;
            if (string.IsNullOrWhiteSpace(tenKhuVuc)) return false;
            return true;
        }

        public DataTable GetAllNhanVien()
        {
            return banDAL.LayDanhSachBan();
        }
        public DataTable TimBan(string tenBan)
        {
            if (string.IsNullOrWhiteSpace(tenBan) && string.IsNullOrWhiteSpace(tenBan))
            {
                throw new ArgumentException("Từ khóa tìm kiếm không được để trống!");
            }

            return banDAL.TimBan(tenBan);
        }
    }
}
