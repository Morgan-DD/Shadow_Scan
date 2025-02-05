using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_server
{
    public partial class UserControl_PcInfo : UserControl
    {
        public string _Hostname { get; set; }
        public string _IP { get; set; }
        public string _Username_Name { get; set; }
        public string _Username_P { get; set; }
        public string _Status { get; set; }
        public string _Infos { get; set; }

        public UserControl_PcInfo()
        {
            InitializeComponent();
        }

        public void updateInfos(string hostname, string IP, string Username_Name, string Username_P, string Status, string Infos)
        {

            _Hostname = hostname;
            _IP = IP;
            _Username_Name = Username_Name;
            _Username_P = Username_P;
            _Status = Status;
            _Infos = Infos;

            textBox_Hostname.Text = hostname;
            textBox_IP.Text = IP;
            textBox_Username_Name.Text = Username_Name;
            textBox_Username_P.Text = Username_P;
            textBox_Status.Text = Status;
            textbox_infos.Text = Infos;
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
