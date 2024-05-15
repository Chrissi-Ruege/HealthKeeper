using Microsoft.AspNetCore.Mvc;

namespace HealthKeeper.Controllers;

public class FoodController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}