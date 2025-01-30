using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        UserControl_main _userControlMain = new UserControl_main();
        UserControl_List _userControlList = new UserControl_List();
        UserControl_Settings _userControlSettings = new UserControl_Settings();

        List<Control> _userContolList = new List<Control>();

        List<Bitmap> _maximizePictures = new List<Bitmap>();


        public Form_main()
        {
            InitializeComponent();

            _userControlMain.Dock = DockStyle.Fill;
            panel_main.Controls.Add(_userControlMain);

            _userControlList.Dock = DockStyle.Fill;
            panel_main.Controls.Add(_userControlList);
            _userControlList.Visible = false;

            _userControlSettings.Dock = DockStyle.Fill;
            panel_main.Controls.Add(_userControlSettings);
            _userControlSettings.Visible = false;

            FormBorderStyle = FormBorderStyle.None;


            _userContolList.Add(_userControlMain);
            _userContolList.Add(_userControlList);
            _userContolList.Add(_userControlSettings);

            _maximizePictures.Add(new Bitmap(Properties.Resources.expand_icon));
            _maximizePictures.Add(new Bitmap(Properties.Resources.minimize_icon));
        }

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

        private void hidePanelControls(Panel _panel, byte idToShow)
        {
            byte id = 0;
            foreach (Control control in _panel.Controls)
            {
                if(id == idToShow)
                {
                    control.Visible = true;
                }else
                    control.Visible = false;
                id += 1;
            }
        }

        private void Button_Main_Click(object sender, EventArgs e)
        {
            hidePanelControls(panel_main, Convert.ToByte((sender as Button).Tag.ToString()));
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            hidePanelControls(panel_main, Convert.ToByte((sender as Button).Tag.ToString()));
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            hidePanelControls(panel_main, Convert.ToByte((sender as Button).Tag.ToString()));
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pictureBox_Enter(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.LightGray;
        }

        private void pictureBox_Leave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = Color.Transparent;
        }

        private void pictureBox_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_Maximize_Click(object sender, EventArgs e)
        {
            bool windowVisible = this.WindowState == FormWindowState.Maximized;
            (sender as PictureBox).Image = _maximizePictures[Convert.ToInt16(!windowVisible)];
            if (windowVisible)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
