using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace ShadowScan_GUI
{
    public partial class UserControl_Settings : UserControl
    {
        private List<UserControl_SingleSetting> _SettingsList = new List<UserControl_SingleSetting>();

        //Configuration

        public UserControl_Settings()
        {
            InitializeComponent();

            foreach(string KeyName in ConfigurationSettings.AppSettings)
            {
                UserControl_SingleSetting tempUserControl = new UserControl_SingleSetting(KeyName, ConfigurationSettings.AppSettings[KeyName]);
                flowLayoutPanel_SettingsList.Controls.Add(tempUserControl);
                _SettingsList.Add(tempUserControl);
                flowLayoutPanel_SettingsList.AutoScroll = true;
                flowLayoutPanel_SettingsList.VerticalScroll.Value = flowLayoutPanel_SettingsList.VerticalScroll.Maximum;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Configuration configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection confCollection = configManager.AppSettings.Settings;

            foreach(UserControl_SingleSetting tempUserControl in _SettingsList)
            {
                //ConfigurationSettings.AppSettings[tempUserControl._SettingName].
                confCollection[tempUserControl._SettingName].Value = tempUserControl._SettingValue;
                tempUserControl.Save();
            }

            configManager.Save(ConfigurationSaveMode.Modified);
        }
    }
}
