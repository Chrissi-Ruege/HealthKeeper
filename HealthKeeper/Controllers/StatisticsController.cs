using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HealthKeeper.Models;

namespace HealthKeeper.Controllers;

public class StatisticsController : Controller
{
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    protected void calculateBMI(object sender, EventArgs e) {
        
    }


    
}