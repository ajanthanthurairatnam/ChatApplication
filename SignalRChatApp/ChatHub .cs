using Microsoft.AspNet.SignalR;

namespace SignalRChatApp
{
    public class ChatHub : Hub
    {
        public void Send1(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}