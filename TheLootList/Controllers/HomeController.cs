using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TriFalcon_Fitness.Models;

namespace TriFalcon_Fitness.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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
    public IActionResult Track()
    {
        return View();
    }
    public IActionResult Settings()
    {
        return View();
    }
    public IActionResult Progress()
    {
        return View();
    }
}