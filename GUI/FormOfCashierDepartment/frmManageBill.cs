using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ccb loại hóa đơn gồm: hóa đơn đã thanh toán, hóa đơn chưa thanh toán, hóa đơn đã xóa(tìm điều kiện trong sql sao ra select ra đc)
// khi chọn items trong cbb loại hóa đơn thì dgv cũng thay đổi
// tất cả các cbb đều dùng sự kiện thay đổi item trong cbb để cập nhật dữ liệu trong dgv
namespace PBL3_ChuongTrinhQuanLyTiemSach.GUI.FormOfCashierDepartment
{
    public partial class frmManageBill : Form
    {
        public frmManageBill()
        {
            InitializeComponent();
        }
    }
}
