using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_server
{
    public partial class UserControl_List : UserControl
    {
        List<UserControl_PC> _pcList = new List<UserControl_PC>();

        byte _focusedPc = 0;

        byte _NextId = 0;

        public UserControl_List()
        {
            InitializeComponent();
        }

        public void DisplayPc(Dictionary<string, string> Settings)
        {
            // Debug.WriteLine(Settings["hostname"] + " | " + Settings["ip"] + " | " + Settings["user_name"] + " | " + Settings["status"]);
            UserControl_PC NewPc = new UserControl_PC(Settings["hostname"], Settings["ip"], Convert.ToByte(Settings["status"]), Settings["user_name"], _NextId, this);

            _pcList.Add(NewPc);
            NewPc.Visible = true;
            Panel.Controls.Add(NewPc);

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Delet");
            cm.MenuItems[0].Click += ContextmenuAction_item1;
            cm.MenuItems[0].Tag = _NextId;

            NewPc.ContextMenu = cm;

            _NextId += 1;
        }

        private void removePC(byte pcID)
        {
            Debug.WriteLine("Deleting pc, ID:" + pcID.ToString());
            for(int i = pcID; i < _pcList.Count(); i++)
            {
                _pcList[i]._ID -= 1;
            }
            _pcList[pcID].Visible = false;
            this.Controls.Remove(_pcList[pcID]);
            _pcList.Remove(_pcList[pcID]);
        }

        public void FocusWindow(byte id)
        {
            _pcList[id].FocusUserPanel(true);
            _pcList[_focusedPc].FocusUserPanel(false);
            _focusedPc = Convert.ToByte(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            FocusWindow(Convert.ToByte(rnd.Next(1, _pcList.Count()-1)));
        }

        private void ContextmenuAction_item1(object sender, EventArgs e)
        {
            //Debug.WriteLine((sender as MenuItem).Container);
            removePC(Convert.ToByte((sender as MenuItem).Tag.ToString()));
        }
    }
}
