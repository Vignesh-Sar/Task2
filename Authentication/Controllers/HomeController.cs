using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Authentication.Models;
using Authentication.Datas;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;


namespace Authentication.Controllers;



public class HomeController : Controller
{
    // RoleManager<IdentityRole> _roleManager;
    // public HomeController(RoleManager<IdentityRole> roleManager)
    // {
    //     _roleManager = roleManager;
    // }
    // public IActionResult Index()
    // {
    //     var roles = _roleManager.Roles.ToList();
    //     return View(roles);
    // }
    // public IActionResult Create()
    // {
    //     return View(new IdentityRole());
    // }
    // [HttpPost]
    // public async Task<IActionResult> Create(IdentityRole role)
    // {
    //     await _roleManager.CreateAsync(role);
    //     return RedirectToAction("Index");
    // }
    


    private readonly ApplicationDbContext _db;
    private readonly ILogger<HomeController> _logger;
    
    public List<data> listofData = new List<data>();
    public List<Details> listofTask1 = new List<Details>();

    public HomeController(ILogger<HomeController> logger,  ApplicationDbContext db)
    {
        _logger = logger;
        _db=db;
       
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(data data)
    {
        if(ModelState.IsValid)
        {
            _db.Employeedetails.Add(data);
            _db.SaveChanges();
            //listofData.Add(data);
            Console.WriteLine(listofData);
           
            return View("Privacy");
        }
        return View();
    }
    public IActionResult Record()
    {
        // var user= _db.Employeedetails.ToList();
        // ViewBag.users=user;
        // var request=_db.ProjectStatus.ToList();
        var listofData=_db.Employeedetails.ToList();
        var listofTask1=_db.ProjectStatus.ToList();
        DatasViewModel datasViewModel= new DatasViewModel();
        datasViewModel.DataViewModel=listofData;
        datasViewModel.Task1ViewModel=listofTask1;
        return View(datasViewModel);
    }
    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public IActionResult SigningUp()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SigningUp(Login singup)
    {
        if(ModelState.IsValid)
        {
         _db.Signups.Add(singup);
         _db.SaveChanges();   
         return View("Privacy");
        }
        return View();
    }
    [HttpGet]
    public IActionResult Singin()
    {
        return View();
    }
     [HttpPost]
    public IActionResult Singin(Login login)
    {
        ClaimsIdentity identity=null;
        bool IsAuthenticate=false;
        var role=Repository.Role(login);
        if(Repository.validate(login))
        {
            identity= new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, login.Name),
                new Claim(ClaimTypes.Role,role)
            }, CookieAuthenticationDefaults.AuthenticationScheme);
            IsAuthenticate=true;
        }
        if(IsAuthenticate)
        {
            var principal= new ClaimsPrincipal(identity);
            var login1= HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            return RedirectToAction("Index",$"{role}");
        }
        return View();
    }
    [HttpGet]
    public IActionResult Project()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Project(Task1 task1)
    {
        _db.ProjectStatus.Add(task1);
        _db.SaveChanges();
        listofTask1.Add(task1);
        return View("Privacy");
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

