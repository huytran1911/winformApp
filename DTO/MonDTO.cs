using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonDTO
    {
        public int MaBill {  get; set; }
        public string MaThucDon { get; set; }
        public int MaHoaDon { get; set; }
        public int SL { get; set; }
        public string GhiChu { get; set; }

        public MonDTO(int maBill, string maThucDon, int maHoaDon, int sL, string ghiChu )
        {
            MaBill = maBill;
            MaThucDon = maThucDon;
            MaHoaDon = maHoaDon;
            SL = sL;
                
            GhiChu = ghiChu;

        }
    }
   
}
