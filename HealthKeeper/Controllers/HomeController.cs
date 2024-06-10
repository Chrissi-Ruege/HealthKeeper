using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HealthKeeper.Models;
using Microsoft.AspNetCore.Authorization;
using HealthKeeper.Models.Views;

namespace HealthKeeper.Controllers;

[Authorize]
[Route("[controller]")]
public class HomeController : Controller
{

    [HttpGet("/")]
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Statistics");
    }

    [HttpGet("/Privacy")]
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { Error = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
