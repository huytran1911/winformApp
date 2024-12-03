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

        public DataTable Search(string keyword)
        {
            return banDAL.Search(keyword);
        }
    }
}
