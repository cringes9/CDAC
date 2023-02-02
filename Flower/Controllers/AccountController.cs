using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Flower.Models;

namespace Flower.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
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
     public IActionResult Login(String email,String password)
    {
        
        if(email=="vishankrthr@gmail.com"&& password=="vishank")
        {
            Response.Redirect("/orders/index"); //going to orderscontroller index method 
        }
        return View();
    }
 


    [HttpPost]
    public IActionResult Register(string email, string password)
    {
       
        Console.WriteLine(email+""+password);
        return this.RedirectToAction("Login","Account");//AccountController Login method
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
