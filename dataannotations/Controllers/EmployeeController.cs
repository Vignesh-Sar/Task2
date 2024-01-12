using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dataannotations.Models;
using Microsoft.AspNetCore.Authorization;

namespace dataannotations.Models
{
    public class EmployeeController:Controller
    {
        [Authorize(Roles="Employee")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles="Employee,Admin")]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}