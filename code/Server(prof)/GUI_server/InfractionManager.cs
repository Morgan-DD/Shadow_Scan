using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_server
{
    internal class InfractionManager
    {
        int _NextConversationId;
        public InfractionManager() { }

        public void ShowMessage(string title, string message1, string message2) 
        {
            new ToastContentBuilder()
            .AddText(title)
            .AddText(message1)
            .AddText(message2)
            .Show();
        }

        public void ReportInfraction(byte infractionType, List<string> infractions, int pcId, string user, UserControl_List pcParent)
        {
            string title = "";
            string message1 = "";
            string message2 = "";

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

            message1 = "L'utilisateur [" + user + "] sur le poste [" + pcParent._pcList[pcId]._pcName + "] a effectué une action interdite";

            message2 = "Ressources bannies accedées: " + String.Join(", ", infractions);

            pcParent._pcList[pcId].AlertMod(true);

            pcParent._pcList[pcId]._PcLogs.Add(pcParent.formatLog(message2));

            ShowMessage(title, message1, message2);
        }
    }
}
