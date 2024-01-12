using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Authentication.Models;
using Microsoft.AspNetCore.Authorization;

namespace Authentication.Models
{
    public class ManagerController:Controller
    {
        [Authorize(Roles="Manager")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles ="Manager")]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}