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
        public DataTable GetAll()
        {
            return banDAL.LoadBan();
        }
        public bool Add(BanDTO ban)
        {
            if (banDAL.CheckTenBan(ban.TenBan))
            {
                throw new Exception("Tên bàn đã tồn tại!");
            }

            return banDAL.Add(ban);
        }

        public bool Delete(string maBan)
        {
            return banDAL.Delete(maBan);
        }

        public bool Update(BanDTO ban)
        {
            return banDAL.Update(ban);
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
