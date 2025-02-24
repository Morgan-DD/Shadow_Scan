using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_server
{
    internal class MessagesManager
    {

        public MessagesManager() { }

        public void ShowMessage(string message) 
        {
            new ToastContentBuilder()
            .AddArgument("action", "viewConversation")
            .AddArgument("conversationId", 9813)
            .AddText("Andrew sent you a picture")
            .AddText(message)
            .AddText("a")
            .Show();
        }
    }
}
