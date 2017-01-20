using System.Threading.Tasks;

namespace NewJoiner.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
