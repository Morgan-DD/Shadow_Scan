using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );

        public UserControl_PC(string PcName, string PcIp, byte PcStatus, string UserName, byte iD, UserControl_List Parent)
        {
            InitializeComponent();
            _ID = iD;
            changeId(_ID);
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

            this.Width = label_PcName.Width + 20;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void FocusUserPanel(bool state)
        {
            this.BackColor = state ? Color.LightGray : Color.Gray;
        }

        public void AlertMod(bool state)
        {
            this.BackColor = state ? Color.Red : Color.Gray;
        }

        private void Click_Event(Object sender, EventArgs e)
        {
            _Parent.FocusWindow(_ID);
        }

        public void changeId(byte newId)
        {
            _ID = newId;
            id_label.Text = _ID.ToString();
        }
    }
}
