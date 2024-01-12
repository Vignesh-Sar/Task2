using MimeKit;
using MailKit.Security;
using LMS.Models;

namespace LMS.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
           _config = config;
        }
       public void SendEmail(EmailDto request)
        {
            // throw new NotImplementedException();
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
        email.To.Add(MailboxAddress.Parse(request.To));
        email.Subject = request.subject;
        email.Body = new TextPart(MimeKit.Text.TextFormat.Html){Text =request.Body};
        using var smtp = new MailKit.Net.Smtp.SmtpClient();
        smtp.Connect(_config.GetSection("EmailHost").Value,587,SecureSocketOptions.StartTls);
        smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
        smtp.Send(email);
        smtp.Disconnect(true);
        }

        
    }
}