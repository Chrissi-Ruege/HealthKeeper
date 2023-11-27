using Microsoft.AspNetCore.Mvc;
using HealthKeeper.Models;

namespace HealthKeeper.Controllers;

public class FoodJournalController : Controller
{
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
}