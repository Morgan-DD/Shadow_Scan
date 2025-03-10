﻿using System;
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
    public partial class UserControl_PcCheckBox : UserControl
    {
        public string _pcName { get; set; }

        public UserControl_PcCheckBox(string pcName)
        {
            InitializeComponent();
            _pcName = pcName;
            textBox.Text = _pcName;
        }

        public void changeName(string newName)
        {
            _pcName = newName;
            textBox.Text = newName;
        }

        public bool isChecked()
        {
            return checkBox.Checked;
        }

        public void changeCheckBoxStatus(bool status)
        {
            checkBox.Checked = status;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            _pcName = textBox.Text;
        }

        public void setTextBoxColor(Color color)
        {
            textBox.BackColor = color;
            textBox.BorderStyle = BorderStyle.None;
        }

        private void UserControl_PcCheckBox_Click(object sender, EventArgs e)
        {
            checkBox.Checked = !checkBox.Checked;
        }
    }
}
