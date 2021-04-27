using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_ChuongTrinhQuanLyTiemSach.DTO
{
    public class WarehouseOrder
    {
        int Id_Order { get; set; }
        DateTime Date { get; set; }
        int Cost { get; set; }
        int Id_Staff { get; set; }
    }
}
