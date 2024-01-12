using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dependancy_injection.Models;

namespace dependancy_injection.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IScopeMessage scopemessage;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }
    public HomeController(IScopeMessage _scopemessage)
    {
    scopemessage =_scopemessage ;
    
    
    }
   
    public IActionResult Index()
    {
       
        return View();
       
    }

    public IActionResult Privacy()
    {
        ViewBag.ScopeMessage = scopemessage.Companyname;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
