using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
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
    public partial class UserControl_RessourcesList : UserControl
    {
        JsonManager _jsonManager;

        List<UserControl_PcCheckBox> _PcCheckBoxList = new List<UserControl_PcCheckBox>();

        List<List<UserControl_PcCheckBox>> _PcCheckBoxSubLists = new List<List<UserControl_PcCheckBox>>();
        byte _idSubList = 0;

        public UserControl_RessourcesList(JsonManager jsonManager)
        {
            InitializeComponent();
            _jsonManager = jsonManager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayMainList();
        }

        private void displayMainList()
        {
            foreach(Resource resource in _jsonManager.Ressources)
            {
                UserControl_PcCheckBox tempRessource = new UserControl_PcCheckBox(resource.pathUrl);
                //tempRessource.Dock = DockStyle.Fill;
                tempRessource.Visible = true;
                tempRessource.Size = new Size(flowLayoutPanel_MainList.Width-25, tempRessource.Height);
                switch (resource.type)
                {
                    case "0": // website
                        tempRessource.BackColor = Color.FromArgb(100, 125,151,171);
                        tempRessource.setTextBoxColor(Color.FromArgb(255, 106, 128, 145));
                        break;
                    case "1": // app
                        tempRessource.BackColor = Color.FromArgb(100, 151, 125, 171);
                        tempRessource.setTextBoxColor(Color.FromArgb(255, 117, 107, 125));
                        break;
                    case "2": // file
                        tempRessource.BackColor = Color.FromArgb(100, 172, 125, 125);
                        tempRessource.setTextBoxColor(Color.FromArgb(255, 145, 106, 106));
                        break;
                }

                flowLayoutPanel_MainList.Controls.Add(tempRessource);
                _PcCheckBoxList.Add(tempRessource);

                flowLayoutPanel_MainList.AutoScroll = true;
                flowLayoutPanel_MainList.VerticalScroll.Value = flowLayoutPanel_MainList.VerticalScroll.Maximum;

                flowLayoutPanel_SubList.AutoScroll = true;
                flowLayoutPanel_SubList.VerticalScroll.Value = flowLayoutPanel_SubList.VerticalScroll.Maximum;
            }
        }

        private void button_moveRight_Click(object sender, EventArgs e)
        {
            addToSubList();
        }

        private void addToSubList()
        {
            List<UserControl_PcCheckBox> tempList = new List<UserControl_PcCheckBox>();

            foreach (UserControl_PcCheckBox userControl_PcCheckBox in _PcCheckBoxList)
            {
                if (userControl_PcCheckBox.isChecked())
                {
                    tempList.Add(userControl_PcCheckBox);
                }
            }

            _PcCheckBoxSubLists.Add(tempList);
            //tempList.Clear();
            if(_idSubList > 0)
                _idSubList += 1;
            displaySubList();
        }

        private void displaySubList()
        {
            flowLayoutPanel_SubList.Controls.Clear();
            foreach (UserControl_PcCheckBox userControl_PcCheckBox in _PcCheckBoxSubLists[_idSubList])
            {
                Debug.WriteLine("Move to sub");
                flowLayoutPanel_SubList.Controls.Add(userControl_PcCheckBox);
            }
        }
    }
}
