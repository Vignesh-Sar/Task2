using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dataannotations.Models;
using Microsoft.AspNetCore.Authorization;

namespace dataannotations.Models
{
    public class AdminController:Controller
    {
        [Authorize(Roles="Admin")]
        public IActionResult Project()
        {
            return View();
        }
    }
}