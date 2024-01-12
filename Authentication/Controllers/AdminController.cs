using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Authentication.Models;
using Microsoft.AspNetCore.Authorization;

namespace Authentication.Models
{

     public class AdminController : Controller
     {

     
    [Authorize (Roles = "Admin")]
    public IActionResult Index()
    {
        return View();
    }
     }
}