using System.Threading.Tasks;

namespace NewJoiner.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
