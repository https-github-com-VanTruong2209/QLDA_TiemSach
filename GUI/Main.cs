using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_ChuongTrinhQuanLyTiemSach.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadNoteForButton();
        }

        private void LoadNoteForButton()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnClose, "Thoát");
            toolTip.SetToolTip(btnMinimize, "Thu nhỏ");
        }
    }
}
