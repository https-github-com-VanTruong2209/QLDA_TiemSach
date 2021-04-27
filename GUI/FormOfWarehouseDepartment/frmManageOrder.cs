using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Khi nhấn cập nhật:
// - Nếu số lượng tăng lên thì lấy số lượng tăng lên cộng thêm vào số lượng sách đó đã thêm trước vào kho.
// - Nếu số lượng giảm xuống thì kiểm tra nếu số lượng giảm nhiều hơn lượng sách đang có thì không cho cập nhật vì trừ đi
//   thì sẽ bị âm sách
// Khi nhấn xóa:
// - Cũng tương tự

namespace PBL3_ChuongTrinhQuanLyTiemSach
{
    public partial class frmManageOrder : Form
    {
        public frmManageOrder()
        {
            InitializeComponent();
        }
    }
}
