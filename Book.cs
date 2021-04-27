using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_ChuongTrinhQuanLyTiemSach.DTO
{
    public class Book
    {
        public string Id_Book { get; set; }
        public string Name_Book { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public string Name_Category { get; set; }
        public string Author { get; set; }
        public string Name_Publisher { get; set; }
        public string DatePublish { get; set; }

    }
}
