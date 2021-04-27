using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_ChuongTrinhQuanLyTiemSach.DTO
{
    public class Staff
    {
        int Id_Staff { get; set; }
        string Name_Staff { get; set; }
        DateTime BirthDate { get; set; }
        string PhoneNumber { get; set; }
        string Adress { get; set; }
        int Id_Department { get; set; }
        string NameAccount { get; set; }
        string Password { get; set; }

    }
}
