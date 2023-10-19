using System.Threading.Tasks;

namespace DotnetConf._2022Edition.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
