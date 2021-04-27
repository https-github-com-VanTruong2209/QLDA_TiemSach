using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_ChuongTrinhQuanLyTiemSach.DTO
{
    public class Customer
    {
        int Id_Customer { get; set; }
        string Name_Customer { get; set; }
        string PhoneNumber { get; set; }
        int TotalPay { get; set; } // Tính tổng tiền tất cả các giao dịch của khách hàng

    }
}
