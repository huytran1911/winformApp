using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MenuDTO
    {
        public string MaThucDon { get; set; }
        public string TenThucDon { get; set; }
        public float Gia { get; set; }

        public MenuDTO(string maThucDon, string tenThucDon, float gia)
        {
            MaThucDon = maThucDon;
            TenThucDon = tenThucDon;
            Gia = gia;
        }
    }
}
