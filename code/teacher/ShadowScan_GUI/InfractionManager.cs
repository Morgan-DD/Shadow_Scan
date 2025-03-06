using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowScan_GUI
{
    internal class InfractionManager
    {
        // pc scanned
        UserControl_PC _pcScanned;

        // now if the popup will be showed
        bool _showNotification;

        public InfractionManager(UserControl_PC pcScanned,bool showNotification) 
        {
            _pcScanned = pcScanned;
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
        /// <param name="infractions">list of string namming the ressource used</param>
        /// <param name="pcId">id of the pc where this infraction happend</param>
        /// <param name="user">name of the user</param>
        /// <param name="pcParent">UserControl_List where the pc is in, used to change the color of the pc</param>
        public void ReportInfraction(byte infractionType, List<string> infractions, int pcId, string user, UserControl_List pcParent)
        {
            // set the values for the notification
            string title = "";
            string message1 = "";
            string message2 = "";

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
            message1 = "L'utilisateur [" + user + "] sur le poste [" + pcParent._pcList[pcId]._pcName + "] a effectué une action interdite";

            message2 = "Ressources bannies accedées: " + String.Join(", ", infractions);

            // set the pc to "AlertMod", become red on the pc list page
            pcParent._pcList[pcId].AlertMod(true);

            // add the the log of the pc what happend
            pcParent._pcList[pcId]._PcLogs.Add(pcParent.formatLog(message2));

            // show the notification
            ShowMessage(title, message1, message2);
        }

        public void StartScan()
        {

        }
    }
}
