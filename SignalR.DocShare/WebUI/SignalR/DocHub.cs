using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace WebUI.SignalR
{

    [HubName("docHub")]
    public class DocHub : Hub
    {
        /// <summary>
        /// This method is called from the SignalR client
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="sessnId">The session id.</param>
        public void Send(string message, string sessnId)
        {
            Clients.addMessage(message, sessnId);
        }
    }

}