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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowScan_GUI
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
        UserControl_Settings _userControlSettings = new UserControl_Settings();
        UserControl_List _userControlList;
        UserControl_RessourcesList _userControlRessourceList;

        // list of these control panels
        List<Control> _userContolListAll = new List<Control>();

        // list of picture for the maximize button
        List<Bitmap> _maximizePictures = new List<Bitmap>();

        byte _actualUserControl = 0;

        // logical part
        ShadowScan_Server.Program _shadowScanInstance = new ShadowScan_Server.Program();

        // used to manage the json data for the banned ressources
        JsonManager_MainList _JsonManager_MainList;

        // used to manage the json data from the sublist of banned ressources
        List<JsonManager_SubList> _jsonManager_SubList;

        List<InfractionManager> _infcationManagerList { get; set; }

        public Form_main()
        {
            InitializeComponent();

            // set the color of the top bar
            panel_top.BackColor = Color.FromArgb(80 ,149 ,212);

            // create the infraction manager
            _infcationManagerList = new List<InfractionManager>();

            // create user controls who need special info and need to be created after the init
            _userControlMain = new UserControl_main(Convert.ToByte(ConfigurationSettings.AppSettings["DefaultClassSize"]), this);
            _userControlList = new UserControl_List(this);

            // retrive the info from the json file
            using (StreamReader r = new StreamReader(ConfigurationSettings.AppSettings["JsonFilePath"]))
            {
                string json = r.ReadToEnd().Trim();
                _JsonManager_MainList = JsonConvert.DeserializeObject<JsonManager_MainList>(json);
            }
            string subListJsonFilePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), ConfigurationSettings.AppSettings["JsonFilePath_Sublist"]);
            if(File.Exists(subListJsonFilePath))
            {
                string json = File.ReadAllText(subListJsonFilePath);

                // Deserialize JSON directly into a list of Lists_SubList
                _jsonManager_SubList = JsonConvert.DeserializeObject<List<JsonManager_SubList>>(json);
            }

            // create the user control list and add them into it, they are the page that will be display on the main panel panel_main
            _userControlRessourceList = new UserControl_RessourcesList(_JsonManager_MainList, _jsonManager_SubList);
            _userControlRessourceList.ImportJsonAndDisplay();

            _userContolListAll.Add(_userControlMain);
            panel_main.Controls.Add(_userControlMain);
            _userContolListAll.Add(_userControlList);
            panel_main.Controls.Add(_userControlList);
            _userContolListAll.Add(_userControlSettings);
            panel_main.Controls.Add(_userControlSettings);
            _userContolListAll.Add(_userControlLoading);
            panel_main.Controls.Add(_userControlLoading);
            _userContolListAll.Add(_userControlRessourceList);
            panel_main.Controls.Add(_userControlRessourceList);

            // add the users control into the main panel
            foreach (Control UserControl in _userContolListAll)
            {
                UserControl.Dock = DockStyle.Fill;
                //panel_main.Controls.Add(UserControl);
                UserControl.Visible = false;
                UserControl.Location = new Point(0, 0);
            }

            // add the pictures into picture array used for topbar icons
            _maximizePictures.Add(new Bitmap(Properties.Resources.expand_icon));
            _maximizePictures.Add(new Bitmap(Properties.Resources.minimize_icon));

            try
            {
                ShowPanelControl(Convert.ToInt16(ConfigurationSettings.AppSettings["pageToStart"]));
            }
            catch
            {
                ShowPanelControl(0);
            }


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

        /// <summary>
        /// used to show the usercontrol that we want into the main panel
        /// </summary>
        /// <param name="idToShow">id of the page that will be showed</param>
        public void ShowPanelControl(int idToShow)
        {
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


        /// <summary>
        /// show the loading screen
        /// </summary>
        /// <param name="message">message that will be displayed on the loading page</param>
        public void showLoadingScreen(string message)
        {
            _userControlLoading.displayMessage(message);
            ShowPanelControl(3);
        }

        /// <summary>
        /// action of the buttons to change page (userpanels)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// close the app (topbar button)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// start a scan of the pc with their hostname to check they status:
        /// Off
        /// On + offline
        /// On + online
        /// </summary>
        /// <param name="pcHostnames">List of all the pcs hostname</param>
        /// <param name="ressourcesListName">name of the ressource that will be given to the agents of these pcs</param>
        public async void startScan(List<string> pcHostnames, string ressourcesListName)
        {
            // default message
            string NoInfoMessage = "None";

            // check all the pcs
            foreach (string pcHostname in pcHostnames)
            {
                
                // ping the pc
                (byte status, string ip) = await Task.Run(() => _shadowScanInstance.pingPc(pcHostname));

                // create an array that is used to transfert infos
                var Pc = new Dictionary<string, string>
                {
                    { "hostname", pcHostname }, // hostname
                    { "ip", NoInfoMessage }, //NoInfoMessage value
                    { "user_name", NoInfoMessage },// NoInfoMessage value
                    { "status", status.ToString() },// Status
                };

                // if the pc is reachable, we set his ip
                if (status > 0)
                    Pc["ip"] = ip;

                // add a infraction manager
                _infcationManagerList.Add(new InfractionManager(_userControlList.DisplayPc(Pc), ConfigurationSettings.AppSettings["NotifyTeacher"].ToLower() == "true"));
                _infcationManagerList[_infcationManagerList.Count()-1].StartScan();
                
            }
            // show the list page
            ShowPanelControl(1);
            // unset the message on the loading page
            _userControlLoading.showTextBoxMessage(false);

        }

        /// <summary>
        /// format the log, add the date
        /// </summary>
        /// <param name="logMessage">message to format</param>
        /// <returns>formated entry message</returns>
        public string formatLog(string logMessage)
        {
            logMessage = "[" + DateTime.Now.ToString("MM/dd/yyyy HH:mm") + "] : " + logMessage;
            return logMessage;
        }

        /// <summary>
        /// change the value of a setting
        /// </summary>
        /// <param name="key"></param>
        /// <param name="newValue"></param>
        public void changeConfigVallue(string key, string newValue) 
        {
            ConfigurationSettings.AppSettings[key] = newValue;
        }

        /// <summary>
        /// get the id of the actual sublist used
        /// </summary>
        /// <returns>id of the sublist actualy used</returns>
        public List<string> getActualSubList()
        {
            return _userControlRessourceList.getActualSubList();
        }

        // todo: suppress
        private void Button_Test_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            List<string> temparay = new List<string>();
            temparay.Add("chatgpt.com");
            temparay.Add("google.gemini.com");
            temparay.Add("ia.com");
            // _MessageManager.ReportInfraction(1, temparay, Convert.ToByte(rand.Next(0, _userControlList._pcList.Count())), "pg66hua", _userControlList);
            //_userControlList.ReportInfraction("TEST","INF-A11-M201","User1");
        }

        private void ReportIllegalAction(string action, string pc, string user) 
        {

        }
    }
}
