using MizanBro.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace MizanBro.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}