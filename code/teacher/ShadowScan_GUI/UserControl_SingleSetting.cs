using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowScan_GUI
{
    public partial class UserControl_SingleSetting : UserControl
    {
        // name of the setting
        public string _SettingName;
        // value of the setting
        public string _SettingValue;
        // old char
        string _OldChar;

        public UserControl_SingleSetting(string settingName, string settingValue)
        {
            InitializeComponent();
            _SettingName = settingName;
            _SettingValue = settingValue;

            // display the stats
            label_SettingName.Text = settingName;
            textBox_SettingValue.Text = settingValue;

            Save();
        }

        private void textBox_SettingValue_TextChanged(object sender, EventArgs e)
        {
            if(_OldChar == string.Empty)
            {
                _OldChar = _SettingValue;
            }
            _SettingValue = textBox_SettingValue.Text;
            if(!(textBox_SettingValue.Text == _OldChar))
                this.BackColor = Color.White;
            else
                Save();
        }

        public void Save()
        {
            this.BackColor = SystemColors.ControlDark;
            _OldChar = "";
        }
    }
}
