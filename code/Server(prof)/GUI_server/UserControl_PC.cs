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
        public byte _ID { get; set; }

        string _pcName;
        string _pcIp;
        byte _pcStatus;
        string _user_Name;

        bool _focused = false;

        UserControl_List _Parent;

        public UserControl_PC(string PcName, string PcIp, byte PcStatus, string UserName, byte iD, UserControl_List Parent)
        {
            InitializeComponent();
            _ID = iD;

            _Parent = Parent;

            _pcName = PcName;
            _pcIp = PcIp;
            _pcStatus = PcStatus;
            _user_Name = UserName;

            label_PcName.Text = _pcName;
            textBox_User.Text = _user_Name;

            switch (_pcStatus)
            {
                case 0:
                    pictureBox_dot.Image = Properties.Resources.dot_red_icon;
                    break;
                case 1:
                    pictureBox_dot.Image = Properties.Resources.dot_yellow_icon;
                    break;
                case 2:
                    pictureBox_dot.Image = Properties.Resources.dot_green_icon;
                    break;
            }

            this.Visible = false;

            this.Width = label_PcName.Width + 20;
        }

        private void label_PcName_TextChanged(object sender, EventArgs e)
        {
            this.Width = label_PcName.Width + 20;
        }

        public void FocusUserPanel(bool state)
        {
            this.BackColor = state ? Color.LightGray : Color.Gray;
        }

        private void Click_Event(Object sender, EventArgs e)
        {
            _Parent.FocusWindow(_ID);
        }
    }
}
