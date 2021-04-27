using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_ChuongTrinhQuanLyTiemSach.DTO
{
    public class Bill
    {
        int Id_Bill { get; set; }
        DateTime Date { get; set; }
        int Id_Customer { get; set; }
        int TotalCost { get; set; }
        string Name_Status { get; set; }
        int Id_Staff { get; set; }
    }
}
