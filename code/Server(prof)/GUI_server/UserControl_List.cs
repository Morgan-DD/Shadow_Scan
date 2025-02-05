using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_server
{
    public partial class UserControl_List : UserControl
    {
        List<UserControl_PC> _pcList = new List<UserControl_PC>();

        byte _focusedPc = 255;

        byte _NextId = 0;

        List<Control> _Panel_rapport_Pages = new List<Control>();

        public UserControl_List()
        {
            InitializeComponent();
        }

        public void DisplayPc(Dictionary<string, string> Settings)
        {
            // Debug.WriteLine(Settings["hostname"] + " | " + Settings["ip"] + " | " + Settings["user_name"] + " | " + Settings["status"]);
            // create a new "PC"
            UserControl_PC NewPc = new UserControl_PC(Settings["hostname"], Settings["ip"], Convert.ToByte(Settings["status"]), Settings["user_name"], _NextId, this);
            
            // add the pc to the pc list
            _pcList.Add(NewPc);
            // make it visible
            Panel.Controls.Add(NewPc);

            // create a conxtext menu for the pc
            ContextMenu cm = new ContextMenu();
            // add the delet option and action for it
            cm.MenuItems.Add("Delete");
            cm.MenuItems[0].Click += ContextmenuAction_item1;
            cm.MenuItems[0].Tag = _NextId;

            // add the context menu to the pc
            NewPc.ContextMenu = cm;

            _NextId += 1;
        }

        /// <summary>
        /// used to remove a pc that is dispayed
        /// </summary>
        /// <param name="pcID">id of the pc to remove</param>
        private void removePC(byte pcID)
        {
            Debug.WriteLine("delete{0}", pcID);
            // to not exclude issues
            _pcList.Remove(_pcList[0]);
            if (pcID > _pcList.Count())
            {
                // go on all the pc that have a higher id than the one deleted
                for (int i = pcID + 1; i < _pcList.Count(); i++)
                {
                    // change id to exclude issues
                    _pcList[i].changeId(Convert.ToByte(_pcList[i]._ID - 1));
                    _pcList[i].ContextMenu.MenuItems[0].Tag = Convert.ToByte(_pcList[i]._ID - 1);
                }
                // if the pc focused is selected or was after the selecter pc
                if (_focusedPc >= pcID)
                {
                    // reset the selection
                    _focusedPc = 0;
                }
                // hide the pc to delet
                _pcList[pcID].Visible = false;
                // delet the pc from the controls
                Panel.Controls.Remove(_pcList[pcID]);
                // remove the pc from the list
                _pcList.Remove(_pcList[pcID]);
            }
        }

        /// <summary>
        /// focus the pc selected
        /// </summary>
        /// <param name="id">Id of the pc to focus</param>
        public void FocusWindow(byte id)
        {
            // focus the pc selected (background light gray)
            _pcList[id].FocusUserPanel(true);
            if(_focusedPc < _pcList.Count())
                _pcList[_focusedPc].FocusUserPanel(false);
            // update the last focused windows (actual one)
            _focusedPc = Convert.ToByte(id);

            if(_pcList.Count() > 0)
            {
                panel_rapport.Visible = true;
                _Panel_rapport_Pages.Add(new UserControl_PcLog());
                _Panel_rapport_Pages.Add(new UserControl_PcLog());
                //_Panel_rapport_Pages.Add(new UserControl_PcInfo());
            }
        }

        private void ContextmenuAction_item1(object sender, EventArgs e)
        {
            //Debug.WriteLine((sender as MenuItem).Container);
            removePC(Convert.ToByte((sender as MenuItem).Tag.ToString()));
        }
    }
}
