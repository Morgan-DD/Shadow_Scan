using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_server
{
    public partial class UserControl_main : UserControl
    {
        // ref to the main form
        Form_main _mainForm;

        // list of the name of the pcs
        List<UserControl_PcCheckBox> _pcNames = new List<UserControl_PcCheckBox>();
        // number of pcs on the classroom
        byte _defaultPcNumbers;

        string _defaultPcName = "INF-{0}-M2";

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        const uint WM_SETREDRAW = 0x000B;

        public UserControl_main(byte defaultPcNumbers, Form_main mainForm)
        {
            InitializeComponent();
            // set the default number of pcs
            _defaultPcNumbers = defaultPcNumbers;
            _mainForm = mainForm;
        }

        private void generatePcName(string ClassName)
        {
            // generate all the pc names
            for (int i = 1; i <= _defaultPcNumbers; i++)
            {
                string pcName = string.Format(_defaultPcName, ClassName.ToUpper()) + i.ToString("00");
                _pcNames.Add(new UserControl_PcCheckBox(pcName));
                flowLayoutPanel_pcList.Controls.Add(_pcNames[_pcNames.Count() - 1]);
            }
        }

        private void button_validateClassName_Click(object sender, EventArgs e)
        {
            if (_pcNames.Count() == 0 && textBox_ClassName.Text != String.Empty)
            {
                generatePcName(textBox_ClassName.Text);
                panel_modifyClassName.Visible = true;
                button_startScan.Enabled = true;
            }
            else if (textBox_ClassName.Text != String.Empty)
            {
                modifyPcNames(string.Format(_defaultPcName, textBox_ClassName.Text));
            }
        }

        private void modifyPcNames(string basePcName)
        {
            int index = 1;
            foreach(UserControl_PcCheckBox pc in _pcNames)
            {
                pc.changeName(basePcName + index.ToString("00"));
                index++;
            }
        }

        private void button_modifyClass_Click(object sender, EventArgs e)
        {
            modifyPcNames(textBox_NewPcName.Text);
        }

        private List<string> getPcToScan()
        {
            List<string> PcHostname = new List<string>();
            foreach (UserControl_PcCheckBox pc in _pcNames)
            {
                if (pc.isChecked())
                {
                    PcHostname.Add(pc._pcName);
                }
            }

            return PcHostname;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // TODO: Faire le scna (StartScan) dans un thread séparé pour permettre l'affichage de la page de chargment durant le scan
        private void button_startScan_Click(object sender, EventArgs e)
        {
            _mainForm.ShowPanelControl(3);
            //StartRedraw(_mainForm);
            StartScan();
        }

        //
        void StartRedraw(Control control)
        {
            SendMessage(control.Handle, WM_SETREDRAW, new IntPtr(1), IntPtr.Zero);
            control.Invalidate();
        }

        private void StartScan()
        {
            List<string> pcHostnames = getPcToScan();
            if (pcHostnames.Count() > 0)
            {
                _mainForm.startScan(pcHostnames);
                resetToZero();
            }
            else
            {
                MessageBox.Show("Vous devez au moins selectionner un pc");
            }
        }

        private void resetToZero()
        {
            button_startScan.Enabled = false;
            panel_modifyClassName.Visible = false;
            foreach (UserControl_PcCheckBox pc in _pcNames)
            {
                flowLayoutPanel_pcList.Controls.Remove(pc);
            }
            textBox_ClassName.Text = String.Empty;
            textBox_NewPcName.Text = String.Empty;
            _pcNames.Clear();
        }
    }
}
