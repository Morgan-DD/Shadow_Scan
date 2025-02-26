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
    public partial class UserControl_loading : UserControl
    {
        public UserControl_loading()
        {
            InitializeComponent();
        }

        public void displayMessage(string message)
        {
            textBox_Message.Text = message;
            showTextBoxMessage(true);
        }

        public void showTextBoxMessage(bool status)
        {
            textBox_Message.Visible=status;
        }
    }
}
