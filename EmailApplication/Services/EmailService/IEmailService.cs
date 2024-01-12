
using MimeKit;
using System.Net.Mail;
using MailKit.Security;
using MailKit.Net.Smtp;

using EmailApplication.Models;

namespace EmailApplication.Services.EmailService
{
    public interface IEmailService
    {
       void SendEmail(EmailDto request);
    }
}