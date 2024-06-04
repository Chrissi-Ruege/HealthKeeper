using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HealthKeeper.Models;
using Microsoft.AspNetCore.Authorization;

namespace HealthKeeper.Controllers;

[Authorize]
[Route("[controller]")]
public class HomeController : Controller
{

    [HttpGet("/")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/Privacy")]
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
