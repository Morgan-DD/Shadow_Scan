using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_server
{
    public partial class UserControl_PC : UserControl
    {
        public UserControl_PC(string PcName, string PcIp, byte PcStatus, string UserName)
        {
            InitializeComponent();
        }

        private void UserControl_PC_Load(object sender, EventArgs e)
        {

        }
    }
}
