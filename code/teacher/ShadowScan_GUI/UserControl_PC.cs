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

namespace ShadowScan_GUI
{
    public partial class UserControl_PC : UserControl
    {
        // def of all info used
        public byte _ID { get; set; }
        public string _pcName { get; set; }
        public string _pcIp { get; set; }

        // 0 if turn of or unreachable
        // 1 if on but wihtout the client side started
        // 2 if everything is started
        public byte _pcStatus { get; set; }
        public string _user_Name { get; set; }

        // logs des action du pc
        public List<string> _PcLogs { get; set; } = new List<string>();

        // parent Control (custom User control)
        UserControl_List _Parent;

        // color of the background
        Color _color;

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
        /// <summary>
        /// init
        /// </summary>
        /// <param name="PcName">hostname of the pc</param>
        /// <param name="PcIp">Ip of the pc</param>
        /// <param name="PcStatus">status of the pc</param>
        /// <param name="UserName">username of the person using the pc</param>
        /// <param name="iD">id of the pc (for display)</param>
        /// <param name="Parent">parent control of the pc</param>
        public UserControl_PC(string PcName, string PcIp, byte PcStatus, string UserName, byte iD, UserControl_List Parent)
        {
            InitializeComponent();
            // set the values into local variables
            _ID = iD;
            _Parent = Parent;

            _pcName = PcName;
            _pcIp = PcIp;
            _pcStatus = PcStatus;
            _user_Name = UserName;

            // set the text into the label and textbox
            label_PcName.Text = _pcName;
            textBox_User.Text = _user_Name;
            textBox_User.Width = label_PcName.Width;
            textBox_User.Location = new Point(label_PcName.Location.X+4, textBox_User.Location.Y);

            // set the icon based on the status
            switch (_pcStatus)
            {
                case 0:
                    pictureBox_dot.Image = Properties.Resources.dot_red_icon;
                    label_status.Text = "Offline";
                    break;
                case 1:
                    pictureBox_dot.Image = Properties.Resources.dot_yellow_icon;
                    label_status.Text = "Turn on";
                    break;
                case 2:
                    pictureBox_dot.Image = Properties.Resources.dot_green_icon;
                    label_status.Text = "Online";
                    break;
            }
            _PcLogs.Add(_Parent.formatLog("Start Scan, status: " + label_status.Text.ToString()));

            this.Width = label_PcName.Width + 20;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            _color = this.BackColor;
        }

        public void FocusUserPanel(bool state)
        {
            this.BackColor = state ? Color.LightGray : Color.Gray;
            
        }

        public void AlertMod(bool state)
        {
            this.BackColor = state ? Color.FromArgb(128, 255, 192, 192) : Color.Gray;
        }

        private void Click_Event(Object sender, EventArgs e)
        {
            _Parent.FocusWindow(_ID);
        }

        public void changeId(byte newId)
        {
            _ID = newId;
        }

        public string getStatusString()
        {
            return label_status.Text;
        }

        public void setToAlertMod(bool type)
        {
            if (type) this.BackColor = Color.Red;
            else this.BackColor = Color.Gray;
        }
    }
}
