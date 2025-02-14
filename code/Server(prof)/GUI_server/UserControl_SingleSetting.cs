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
    public partial class UserControl_SingleSetting : UserControl
    {
        // name of the setting
        public string _SettingName;
        // value of the setting
        public string _SettingValue;

        public UserControl_SingleSetting(string settingName, string settingValue)
        {
            InitializeComponent();
            _SettingName = settingName;
            _SettingValue = settingValue;

            // display the stats
            label_SettingName.Text = settingName;
            textBox_SettingValue.Text = settingValue;
        }

        private void textBox_SettingValue_TextChanged(object sender, EventArgs e)
        {
            _SettingValue = textBox_SettingValue.Text;
        }
    }
}
