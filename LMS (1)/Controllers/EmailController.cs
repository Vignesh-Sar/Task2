using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MimeKit;
using System.Net.Mail;
using MailKit.Security;
using MailKit.Net.Smtp;
using LMS.Models;
using Microsoft.AspNetCore.Authorization;
using LMS.Services.EmailService;

namespace EmailApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class EmailController : ControllerBase
{
    private readonly IEmailService _emailService;
    public EmailController(IEmailService emailService)
    {
        _emailService = emailService;
    }
    [HttpPost]
    public IActionResult SendEmail(EmailDto request)
    {
        _emailService.SendEmail(request);
       
        return Ok();
       
    }
}
