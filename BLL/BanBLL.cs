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
        private BanDAL dal = new BanDAL();
        public DataTable GetAll()
        {
            return dal.GetAll();
        }
        public void Add(BanDTO ban)
        {
            dal.Add(ban);
        }

        public void Delete(string maBan)
        {
            dal.Delete(maBan);
        }

        public void Update(BanDTO ban)
        {
            dal.Update(ban);
        }

        public DataTable Search(string keyword)
        {
            return dal.Search(keyword);
        }
    }
}
