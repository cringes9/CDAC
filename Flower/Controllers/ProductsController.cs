using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Flower.Models;
using BOL;
using SAL;


namespace Flower.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    //Action Method
    [HttpGet]
    public IActionResult Index()
    {
         List <Product> products = ProductHubServices.GetAllProducts();
         ViewData["products"] = products;
         return View();
       
    }
    [HttpGet]
    public IActionResult Details(int id)
    {
      
        Product P=  ProductHubServices.GetProductById(id);
        Console.WriteLine(P.Title+""+P.ProductId);
             ViewBag.currentProduct=P;
        return View();
    }
}