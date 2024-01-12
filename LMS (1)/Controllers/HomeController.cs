using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LMS.Models;
using LMS.Filter;

namespace LMS.Controllers;
[ExceptionLogFilter]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Datadbcontext _db;
   

    public HomeController(ILogger<HomeController> logger,Datadbcontext _db1)
    {
        _logger = logger;
         _db=_db1;
    }
   
    public IActionResult Index()
    {
        string message = TempData["Warning"] as string;
        if(!string.IsNullOrEmpty(message))
        {
          
        
        }
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult welcom()
    {
        return View();
    }
    public IActionResult IndexPage()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(Register Value)
    {
        _db.Employees.Add(Value);//(insert)
        //suppose find method using _db.Employee.Find(Values)
        //Delete _db.Employee.Delete(Values)
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
