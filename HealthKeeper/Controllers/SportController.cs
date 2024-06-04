using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

[Route("[controller]")]
public class SportController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}