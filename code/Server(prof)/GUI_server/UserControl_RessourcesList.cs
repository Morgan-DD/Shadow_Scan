using GUI_server.Properties;
using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.Activation;
using Windows.UI.StartScreen;
using Windows.UI.Xaml.Shapes;

namespace GUI_server
{
    public partial class UserControl_RessourcesList : UserControl
    {
        // used to get the infos from the json
        JsonManager _jsonManager;

        // main list of banned ressources
        List<UserControl_PcCheckBox> _PcCheckBoxList = new List<UserControl_PcCheckBox>();
        // list of list of banned ressources (list of sublists)
        List<List<UserControl_PcCheckBox>> _PcCheckBoxSubLists = new List<List<UserControl_PcCheckBox>>();
        // id of the actual sublist
        byte _idSubList = 0;
        // name of the json file for the sublists
        string _subListJsonFileName = "RessourcesConfig_SubList.json";

        public UserControl_RessourcesList(JsonManager jsonManager)
        {
            InitializeComponent();
            _jsonManager = jsonManager;
            // create a sublist at the begining
            createNewSubList();
        }

        // display the main list
        public void displayMainList()
        {
            // go on all the ressources
            foreach(Resource resource in _jsonManager.Ressources)
            {
                // create a temp ressource
                UserControl_PcCheckBox tempRessource = new UserControl_PcCheckBox(resource.pathUrl);
                // set her settings
                tempRessource.Visible = true;
                tempRessource.Size = new Size(flowLayoutPanel_MainList.Width-25, tempRessource.Height);
                // change the color based on the type
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
                tempRessource.Tag = resource.type;
                tempRessource.changeCheckBoxStatus(false);
                // add the ressource to a flowLayoutPanel
                flowLayoutPanel_MainList.Controls.Add(tempRessource);
                _PcCheckBoxList.Add(tempRessource);

                // configure the layout panels so they can have a scroll bar if there is a lot of resources
                flowLayoutPanel_MainList.AutoScroll = true;
                flowLayoutPanel_MainList.VerticalScroll.Value = flowLayoutPanel_MainList.VerticalScroll.Maximum;
                flowLayoutPanel_SubList.AutoScroll = true;
                flowLayoutPanel_SubList.VerticalScroll.Value = flowLayoutPanel_SubList.VerticalScroll.Maximum;
            }
        }


        private void button_moveRight_Click(object sender, EventArgs e)
        {
            // add the marked ressources into the sublist
            addToSubList();
        }

        /// <summary>
        /// add from main list to the sublist
        /// </summary>
        private void addToSubList()
        {
            // templist of the element that will be added (not used every times)
            List<UserControl_PcCheckBox> tempList = new List<UserControl_PcCheckBox>();
            
            // check all ressources on the mainlist
            foreach (UserControl_PcCheckBox userControl_PcCheckBox in _PcCheckBoxList)
            {
                // if the ressource is checked (will go to the sublist)
                if (userControl_PcCheckBox.isChecked())
                {
                    // uncheck the textbox
                    userControl_PcCheckBox.changeCheckBoxStatus(false);
                    // create a new ressource (graphical)
                    UserControl_PcCheckBox tempUserControl = new UserControl_PcCheckBox(userControl_PcCheckBox._pcName);
                    // set the parameters (tag is used for display part)
                    tempUserControl.Tag = userControl_PcCheckBox.Tag;
                    // if that's the first sublist
                    if(_PcCheckBoxSubLists.Count() == 0)
                    {
                        tempList.Add(tempUserControl);
                    }
                    else
                    {
                        // if the sublist is empty
                        if (_PcCheckBoxSubLists.Count() <= _idSubList)
                            tempList.Add(tempUserControl);
                        else
                            _PcCheckBoxSubLists[_idSubList].Add(tempUserControl);
                    }
                }
            }
            //
            if (_PcCheckBoxSubLists.Count() == 0)
            {
                _PcCheckBoxSubLists.Add(tempList);
            }
            else
            {
                if (_PcCheckBoxSubLists.Count() <= _idSubList)
                {
                    _PcCheckBoxSubLists.Add(tempList);
                }
            }
            displaySubList();
        }

        private void changeSubList(byte id)
        {
            flowLayoutPanel_SubList.Controls.Clear();
            _idSubList = id;
            textBox_SubListName.Text = comboBox_SubList.Items[id].ToString();
            displaySubList();
        }

        private void displaySubList()
        {
            flowLayoutPanel_SubList.Controls.Clear();
            try
            {

                foreach (UserControl_PcCheckBox userControl_PcCheckBox in _PcCheckBoxSubLists[_idSubList])
                {
                    userControl_PcCheckBox.Visible = true;
                    userControl_PcCheckBox.Size = new Size(flowLayoutPanel_MainList.Width - 25, userControl_PcCheckBox.Height);
                    switch (userControl_PcCheckBox.Tag)
                    {
                        case "0": // website
                            userControl_PcCheckBox.BackColor = Color.FromArgb(100, 125, 151, 171);
                            userControl_PcCheckBox.setTextBoxColor(Color.FromArgb(255, 106, 128, 145));
                            break;
                        case "1": // app
                            userControl_PcCheckBox.BackColor = Color.FromArgb(100, 151, 125, 171);
                            userControl_PcCheckBox.setTextBoxColor(Color.FromArgb(255, 117, 107, 125));
                            break;
                        case "2": // file
                            userControl_PcCheckBox.BackColor = Color.FromArgb(100, 172, 125, 125);
                            userControl_PcCheckBox.setTextBoxColor(Color.FromArgb(255, 145, 106, 106));
                            break;
                    }
                    flowLayoutPanel_SubList.Controls.Add(userControl_PcCheckBox);
                }
                if (_PcCheckBoxSubLists[_idSubList].Count > 0)
                {
                    textBox_SubListName.Enabled = true;
                }
            }
            catch (Exception ex) { }
        }

        private void clearSubList()
        {
            flowLayoutPanel_SubList.Controls.Clear();
            _PcCheckBoxSubLists[_idSubList].Clear();
        }

        private void button_clearSubList_Click(object sender, EventArgs e)
        {
            clearSubList();
        }

        private void comboBox_SubList_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSubList(Convert.ToByte((sender as ComboBox).SelectedIndex));
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            comboBox_SubList.Items[_idSubList] = textBox_SubListName.Text;
        }

        private void createNewSubList()
        {
            if(_PcCheckBoxSubLists.Count() > 0)
                _idSubList += 1;
            flowLayoutPanel_SubList.Controls.Clear();
            comboBox_SubList.Items.Add(("Sans titre " + (comboBox_SubList.Items.Count + 1)));
            textBox_SubListName.Text = comboBox_SubList.Items[_idSubList].ToString();
        }

        private void button_NewSubList_Click(object sender, EventArgs e)
        {
            createNewSubList();
        }

        private void textBox_SubListName_TextChanged(object sender, EventArgs e)
        {
            if((sender as TextBox).Text == "")
                button_NewSubList.Enabled = false;
            else
                button_NewSubList.Enabled = true;

        }

        public void saveSubList()
        {
            var list = new List<dynamic>();
            foreach (List<UserControl_PcCheckBox> userControl_PcCheckBoxList in _PcCheckBoxSubLists)
            {
                if(userControl_PcCheckBoxList.Count() > 0)
                {
                    foreach (UserControl_PcCheckBox userControl_PcCheckBox in userControl_PcCheckBoxList)
                    {
                        list.Add(new {
                            type = userControl_PcCheckBox.Tag,
                            pathUrl = userControl_PcCheckBox._pcName
                        });
                    }
                }
            }
            var json = JsonConvert.SerializeObject(list);

            if (File.Exists(_subListJsonFileName))
            {
                Debug.WriteLine("File already exist");
            }
            else
            {
                string savePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), _subListJsonFileName);
                //File.WriteAllText(json, savePath);
                using (StreamWriter sw = File.AppendText(savePath))
                {
                    sw.WriteLine(json);
                }
                Debug.WriteLine($"{savePath}");
            }

            Debug.WriteLine(json);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveSubList();
        }
    }
}
