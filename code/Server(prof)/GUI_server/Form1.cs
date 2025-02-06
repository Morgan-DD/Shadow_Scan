using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using ShadowScan_Server;
using System.Net.NetworkInformation;
using System.Threading;

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
        UserControl_main _userControlMain;
        UserControl_loading _userControlLoading = new UserControl_loading();
        UserControl_List _userControlList = new UserControl_List();
        UserControl_Settings _userControlSettings = new UserControl_Settings();

        // list of these control panels
        List<Control> _userContolList = new List<Control>();

        // list of picture for the maximize button
        List<Bitmap> _maximizePictures = new List<Bitmap>();

        byte _actualUserControl = 0;

        ShadowScan_Server.Program _shadowScanInstance = new ShadowScan_Server.Program();

        public Form_main()
        {
            InitializeComponent();

            _userControlMain = new UserControl_main(Convert.ToByte(ConfigurationSettings.AppSettings["DefaultClassSize"]), this);

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

            _userControlLoading.Dock = DockStyle.Fill;
            panel_main.Controls.Add(_userControlLoading);
            _userControlLoading.Visible = false;
            _userControlLoading.Location = new Point(0, 0);

            _userContolList.Add(_userControlMain);
            _userContolList.Add(_userControlList);
            _userContolList.Add(_userControlSettings);
            _userContolList.Add(_userControlLoading);

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
        public void ShowPanelControl(int idToShow)
        {
            Debug.WriteLine("show page No {0}", idToShow);
            byte id = 0;
            if(idToShow >= 0)
            {
                _actualUserControl = Convert.ToByte(idToShow);
            }
            // check all userpanels
            foreach (Control control in panel_main.Controls)
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
            ShowPanelControl(Convert.ToByte((sender as Button).Tag.ToString()));
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
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                //WindowState = FormWindowState.Maximized;
            }
        }

        // close the app (topbar button)
        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_main_Resize(object sender, EventArgs e)
        {
            label_size.Text = this.Size.ToString();
        }

        public void startScan(List<string> pcHostnames)
        {
            string NoInfoMessage = "None";
            Debug.WriteLine("Scan start (main)");
            foreach (string pcHostname in pcHostnames)
            {
                (byte status, string ip) = _shadowScanInstance.pingPc(pcHostname);

                Debug.WriteLine($"hostname: {pcHostname}\nIP: {ip}\nStatus:{status}\n------------------------");
                // byte status = 0;
                var Pc = new Dictionary<string, string>
                {
                    { "hostname", pcHostname },
                    { "ip", NoInfoMessage },
                    { "user_name", NoInfoMessage },
                    { "status", status.ToString() },
                };
                if (status > 0)
                {
                    Pc["ip"] = ip;
                }
                _userControlList.DisplayPc(Pc);
            }
            ShowPanelControl(1);
        }
    }
}
