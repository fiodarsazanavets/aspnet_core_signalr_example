using System.Threading.Tasks;

namespace LearningSignalR
{
    public interface ILearningHubClient
    {
        Task ReceiveMessage(string message);
    }
}
