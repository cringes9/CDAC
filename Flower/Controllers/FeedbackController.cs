using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Flower.Models;

namespace Flower.Controllers;

public class FeedbackController : Controller
{
    private readonly ILogger<FeedbackController> _logger;

    public FeedbackController(ILogger<FeedbackController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}