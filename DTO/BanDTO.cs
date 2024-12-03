using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanDTO
    {
        public string MaBan { get; set; }
        public string TenBan { get; set; }
        public string MaKhuVuc { get; set; }
        public string TenKhuVuc { get; set; }
        public BanDTO(string tenBan, string maKhuVuc )
        { 
            TenBan = tenBan;
            MaKhuVuc = maKhuVuc;
        }
    }
}
