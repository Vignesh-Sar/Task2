using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MimeKit;
using System.Net.Mail;
using MailKit.Security;
using MailKit.Net.Smtp;
using EmailApplication.Models;
using Microsoft.AspNetCore.Authorization;

namespace EmailApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class WeatherForecastController : ControllerBase
{
    private readonly IEmailService _emailService;
    public WeatherForecastController(IEmailService emailService)
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
