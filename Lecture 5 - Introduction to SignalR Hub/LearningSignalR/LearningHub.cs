using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace LearningSignalR
{
    public class LearningHub  : Hub
    {
        public Task BroadcastMessage(string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
