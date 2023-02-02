using Microsoft.AspNetCore.Mvc;

namespace TFLStore.Controllers;

public class OrdersController : Controller
{
    private readonly ILogger<OrdersController> _logger;

    public OrdersController(ILogger<OrdersController> logger)
    {
        _logger = logger;
    }

    //Action Method
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }


     
     
}
