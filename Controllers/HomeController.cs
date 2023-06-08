using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        string MyString = "Hello World!";
        return View("Index", MyString);
    }

    [HttpGet("int")]
    public IActionResult Int()
    {
        List<int> intList = new List<int>(){1,2,3,4,5};
        return View("Int", intList);
    }

    [HttpGet("user")]
    public IActionResult AUser()
    {
        User Mike = new User()
        {
            Name = "Mike"
        };
        return View("User", Mike);
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
        User Mike = new User()
        {
            Name = "Mike"
        };
        User Cam = new User()
        {
            Name = "Cam"
        };

        User Loafie = new User()
        {
            Name = "Loafie"
        };

        List<User> userList = new List<User>()
        {
            Mike, Cam, Loafie
        };
        return View("Users", userList);
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
