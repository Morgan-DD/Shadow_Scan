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
    public partial class UserControl_loading : UserControl
    {
        int _nbItemsForScrollBar;

        public UserControl_loading(int nbItemsForScrollBar)
        {
            InitializeComponent();
            _nbItemsForScrollBar = nbItemsForScrollBar;
        }

        public void displayMessage(string message)
        {
            textBox_Message.Text = message;
            progressBar.Maximum = _nbItemsForScrollBar;
            showTextBoxMessage(true);
        }

        public void avanceProgressBar()
        {
            progressBar.Value += 1;
        }

        public void showTextBoxMessage(bool status)
        {
            textBox_Message.Visible=status;
            progressBar.Value = 0;
        }
    }
}
