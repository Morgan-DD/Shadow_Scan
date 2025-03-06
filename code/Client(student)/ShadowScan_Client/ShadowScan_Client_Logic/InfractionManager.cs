using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowScan_Client_Logic
{
    internal class InfractionManager
    {

        // now if the popup will be showed
        public bool _showNotification { get; set; }

        List<string> _DoNotNotify = new List<string>();


        public InfractionManager(bool showNotification) 
        {
            _showNotification = showNotification;
        }

        /// <summary>
        /// show a message when an infraction is made
        /// </summary>
        /// <param name="title">title of the notification</param>
        /// <param name="message1">first line of the notification</param>
        /// <param name="message2">second and last of the notification</param>
        public void ShowMessage(string title, string message1, string message2) 
        {
            // if the display of the notification is allowed
            if (_showNotification)
            {
                // create the notification
                new ToastContentBuilder()
                .AddText(title)
                .AddText(message1)
                .AddText(message2)
                .Show();
            }
        }

        /// <summary>
        /// report the action and the pc will be set to red on the list page and a notification will apear if _showNotification is true
        /// </summary>
        /// <param name="infractionType">type, 0=>site web, 1=>application, 2=>fichier</param>
        /// <param name="website">list of string namming the ressource used</param>
        /// <param name="user">name of the user</param>
        public async void ReportInfraction(byte infractionType, string website, string user)
        {
            if (NotifyOrNot(website))
            {


                // set the values for the notification
                string title = "";
                string message1 = "";
                string message2 = "";


                Task.Run(async () => addToDoNotNotify(website));


                // add the title
                switch (infractionType)
                {
                    case 0:
                        title += "Site Web";
                        break;
                    case 1:
                        title += "Application";
                        break;
                    case 2:
                        title += "Fichier";
                        break;
                }

                // generate the message
                message1 = "Vous avez accédé à une ressource interdite ";

                message2 = "Ressources bannies accedées: " + website;

                // show the notification
                ShowMessage(title, message1, message2);
            }
        }

        private void addToDoNotNotify(string website) 
        {
            _DoNotNotify.Add(website);
            Thread.Sleep(10000);
            _DoNotNotify.Remove(website);
        }

        private bool NotifyOrNot(string website) 
        {
            foreach (string item in _DoNotNotify) 
            {
                if (item == website)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
