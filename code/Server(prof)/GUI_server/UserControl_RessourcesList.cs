using GUI_server.Properties;
using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        JsonManager_MainList _JsonManager_MainList;

        // used to get the infos from the json
        List<JsonManager_SubList> _JsonManager_SubList;

        // main list of banned ressources
        List<UserControl_PcCheckBox> _PcCheckBoxList = new List<UserControl_PcCheckBox>();
        // list of list of banned ressources (list of sublists)
        List<List<UserControl_PcCheckBox>> _PcCheckBoxSubLists = new List<List<UserControl_PcCheckBox>>();
        // id of the actual sublist
        byte _idSubList = 0;
        // name of the json file for the sublists
        string _subListJsonFileName = ConfigurationSettings.AppSettings["JsonFilePath_Sublist"];

        public UserControl_RessourcesList(JsonManager_MainList jsonManager, List<JsonManager_SubList> jsonManagerSub)
        {
            InitializeComponent();
            _JsonManager_MainList = jsonManager;
            _JsonManager_SubList = jsonManagerSub;
            // create a sublist at the begining
            if (jsonManagerSub.Count == 0) 
            {
                createNewSubList();
            }
        }

        // display the main list
        public void displayMainList()
        {
            // go on all the ressources
            foreach(Ressource_MainList resource in _JsonManager_MainList.Ressources)
            {
                // create a temp ressource
                UserControl_PcCheckBox tempRessource = new UserControl_PcCheckBox(resource.PathUrl);
                // set her settings
                tempRessource.Visible = true;
                tempRessource.Size = new Size(flowLayoutPanel_MainList.Width-25, tempRessource.Height);
                // change the color based on the type
                switch (resource.Type)
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
                tempRessource.Tag = resource.Type;
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

            byte tesstID = 0;
            foreach(JsonManager_SubList subList in _JsonManager_SubList)
            {
                createNewSubList();
                comboBox_SubList.Items[comboBox_SubList.Items.Count - 1] = subList.Category;
                List<UserControl_PcCheckBox> tempList = new List<UserControl_PcCheckBox>();
                foreach (Item_SubList item in subList.Items)
                {
                    UserControl_PcCheckBox tempItem = new UserControl_PcCheckBox(item.PathUrl);

                    switch (item.Type)
                    {
                        case "0": // website
                            tempItem.BackColor = Color.FromArgb(100, 125, 151, 171);
                            tempItem.setTextBoxColor(Color.FromArgb(255, 106, 128, 145));
                            break;
                        case "1": // app
                            tempItem.BackColor = Color.FromArgb(100, 151, 125, 171);
                            tempItem.setTextBoxColor(Color.FromArgb(255, 117, 107, 125));
                            break;
                        case "2": // file
                            tempItem.BackColor = Color.FromArgb(100, 172, 125, 125);
                            tempItem.setTextBoxColor(Color.FromArgb(255, 145, 106, 106));
                            break;
                    }
                    tempItem.Size = new Size(flowLayoutPanel_SubList.Width - 25, tempItem.Height);
                    tempItem.Tag = item.Type;
                    tempItem.changeCheckBoxStatus(false);
                    tempList.Add(tempItem);
                }
 
                _PcCheckBoxSubLists.Add(tempList);
                tesstID++;
            }
            changeSubList(0);
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
                    // uncheck the checkbox
                    tempUserControl.changeCheckBoxStatus(false);
                    // if that's the first sublist
                    if (_PcCheckBoxSubLists.Count() == 0)
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
                comboBox_SubList.SelectedIndex = _idSubList;
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
            saveSubList();
        }

        private void createNewSubList()
        {
            if(_PcCheckBoxSubLists.Count() > 0)
                _idSubList = Convert.ToByte(comboBox_SubList.Items.Count);
            flowLayoutPanel_SubList.Controls.Clear();
            comboBox_SubList.Items.Add(("Sans titre " + (comboBox_SubList.Items.Count + 1)));
            comboBox_SubList.SelectedIndex = _idSubList;
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
            string savePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), _subListJsonFileName);
            var list = new List<object>();
            int id = 0;
            foreach (List<UserControl_PcCheckBox> userControl_PcCheckBoxList in _PcCheckBoxSubLists)
            {
                if (userControl_PcCheckBoxList.Count > 0)
                {
                    var categoryObject = new
                    {
                        Category = comboBox_SubList.Items[id].ToString(),
                        Items = userControl_PcCheckBoxList.Select(userControl_PcCheckBox => new
                        {
                            type = userControl_PcCheckBox.Tag,
                            pathUrl = userControl_PcCheckBox._pcName
                        }).ToList()
                    };

                    list.Add(categoryObject);
                }
                id++;
            }
            var json = JsonConvert.SerializeObject(list);
            //File.WriteAllText(json, savePath);
            File.WriteAllText(savePath, json);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveSubList();
        }

        private void removeFromActualSubList()
        {
            List<UserControl_PcCheckBox> tempList = new List<UserControl_PcCheckBox>();

            foreach (Control userControl_PcCheckBox in flowLayoutPanel_SubList.Controls)
            {
                if (!(userControl_PcCheckBox as UserControl_PcCheckBox).isChecked())
                {
                    tempList.Add((userControl_PcCheckBox as UserControl_PcCheckBox));
                }
            }

            _PcCheckBoxSubLists[_idSubList] = tempList;

            displaySubList();
        }

        private void deletSubList(byte id)
        {
            _PcCheckBoxSubLists.Remove(_PcCheckBoxSubLists[id]);
            comboBox_SubList.Items.RemoveAt(id);
            changeSubList(0);
            displaySubList();
        }

        private void button_removeSubList_Click(object sender, EventArgs e)
        {
            removeFromActualSubList();
        }

        private void button_DeletSubList_Click(object sender, EventArgs e)
        {
            deletSubList(_idSubList);
        }
    }
}
