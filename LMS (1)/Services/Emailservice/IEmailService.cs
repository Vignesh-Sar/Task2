
using MimeKit;
using System.Net.Mail;
using MailKit.Security;
using MailKit.Net.Smtp;

using LMS.Models;

namespace LMS.Services.EmailService
{
    public interface IEmailService
    {
       void SendEmail(EmailDto request);
    }
}