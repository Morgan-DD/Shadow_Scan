using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI_server
{
    public partial class Form_main : Form
    {
        // code to allow to move the window via the top bar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // users control for the pages, they go into the main panel (panel_main)
        UserControl_main _userControlMain = new UserControl_main();
        UserControl_List _userControlList = new UserControl_List();
        UserControl_Settings _userControlSettings = new UserControl_Settings();

        // list of these control panels
        List<Control> _userContolList = new List<Control>();

        // list of picture for the maximize button
        List<Bitmap> _maximizePictures = new List<Bitmap>();

        byte _actualUserControl = 0;

        public Form_main()
        {
            InitializeComponent();

            // add the users control into the main panel
            _userControlMain.Dock = DockStyle.Fill;
            panel_main.Controls.Add(_userControlMain);
            _userControlMain.Location = new Point(0, 0);

            _userControlList.Dock = DockStyle.Fill;
            panel_main.Controls.Add(_userControlList);
            _userControlList.Visible = false;
            _userControlList.Location = new Point(0, 0);

            _userControlSettings.Dock = DockStyle.Fill;
            panel_main.Controls.Add(_userControlSettings);
            _userControlSettings.Visible = false;
            _userControlSettings.Location = new Point(0, 0);

            _userContolList.Add(_userControlMain);
            _userContolList.Add(_userControlList);
            _userContolList.Add(_userControlSettings);

            // add the pictures into picture array used for topbar icons
            _maximizePictures.Add(new Bitmap(Properties.Resources.expand_icon));
            _maximizePictures.Add(new Bitmap(Properties.Resources.minimize_icon));
        }

        // methode to resize the window
        // finded in stackoverflow:
        // https://stackoverflow.com/questions/29024910/how-to-design-a-custom-close-minimize-and-maximize-button-in-windows-form-appli
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17; //HTBOTTOMRIGHT
                    return;
                }
                else if (cursorPosition.X <= resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)16; //HTBOTTOMLEFT
                    return;
                }
                else if (cursorPosition.X <= resizeArea)
                {
                    m.Result = (IntPtr)10; //HTLEFT
                    return;
                }
                else if (cursorPosition.X >= ClientSize.Width - resizeArea)
                {
                    m.Result = (IntPtr)11; //HTRIGHT
                    return;
                }
                else if (cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)15; //HTBOTTOM
                    return;
                }
            }

            base.WndProc(ref m);
        }

        // used to show the usercontrol that we want into the main panel
        private void hidePanelControls(Panel _panel, byte idToShow)
        {
            byte id = 0;
            // check all userpanels
            foreach (Control control in _panel.Controls)
            {
                // if its the one that we want to show
                if(id == idToShow)
                    // show the panel
                    control.Visible = true;
                else
                    // hide the panel (all exept one)
                    control.Visible = false;
                id += 1;
            }
        }

        // action of the buttons to change page (userpanels)

        private void Button_MenuClick(object sender, EventArgs e)
        {
            hidePanelControls(panel_main, Convert.ToByte((sender as Button).Tag.ToString()));
            _actualUserControl = Convert.ToByte((sender as Button).Tag.ToString());
        }

        // methode used to move the windows when holding click on the topbar
        // find on stackoverflow:
        // https://stackoverflow.com/questions/29024910/how-to-design-a-custom-close-minimize-and-maximize-button-in-windows-form-appli
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        // use to change topbar icon backgroud color when hover
        private void pictureBox_Enter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.LightGray;
        }

        // use to reset topbar icon backgroud color when leaved
        private void pictureBox_Leave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Transparent;
        }

        // action to minimize the window (topbar button)
        private void pictureBox_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // action to maximize the window (topbar button)
        private void pictureBox_Maximize_Click(object sender, EventArgs e)
        {
            // window state
            bool windowVisible = this.WindowState == FormWindowState.Maximized;
            // set the icon based on the window state
            (sender as PictureBox).Image = _maximizePictures[Convert.ToInt16(!windowVisible)];
            // maximize the window if not 
            if (windowVisible)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        // close the app (topbar button)
        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Test_Click(object sender, EventArgs e)
        {
            if(_actualUserControl == 1)
            {
                var dictionary1 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M201" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "2" },
                };
                var dictionary2 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M202" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "0" },
                };
                var dictionary3 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M203" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "2" },
                };
                var dictionary4 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M204" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "2" },
                };
                var dictionary5 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M205" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "1" },
                };
                var dictionary6 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M206" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "2" },
                };
                var dictionary7 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M207" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "2" },
                };
                var dictionary8 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M208" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "0" },
                };
                var dictionary9 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M209" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "0" },
                };
                var dictionary10 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M210" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "1" },
                };
                var dictionary11 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M211" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "1" },
                };
                var dictionary12 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M212" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "1" },
                };
                var dictionary13 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M213" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" }
                    ,
                    { "status", "1" },
                };
                var dictionary14 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M214" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "1" },
                };
                var dictionary15 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M215" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "1" },
                };
                var dictionary16 = new Dictionary<string, string>
                {
                    { "hostname", "INF-A11-M216" },
                    { "ip", "8.8.8.8" },
                    { "user_name", "pg66hua" },
                    { "status", "1" },
                };
                List<Dictionary<string, string>> pcList = new List<Dictionary<string, string>>();
                pcList.Add(dictionary1);

                _userControlList.DisplayPc(dictionary1);
                _userControlList.DisplayPc(dictionary2);
                _userControlList.DisplayPc(dictionary3);
                _userControlList.DisplayPc(dictionary4);
                _userControlList.DisplayPc(dictionary5);
                _userControlList.DisplayPc(dictionary6);
                _userControlList.DisplayPc(dictionary7);
                _userControlList.DisplayPc(dictionary8);
                _userControlList.DisplayPc(dictionary9);
                _userControlList.DisplayPc(dictionary10);
                _userControlList.DisplayPc(dictionary11);
                _userControlList.DisplayPc(dictionary12);
                _userControlList.DisplayPc(dictionary13);
                _userControlList.DisplayPc(dictionary14);
                _userControlList.DisplayPc(dictionary15);
                _userControlList.DisplayPc(dictionary16);
            }
        }

        private void Form_main_Resize(object sender, EventArgs e)
        {
            label_size.Text = this.Size.ToString();
        }
    }
}
