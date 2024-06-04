using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

[Route("[controller]")]
public class CalenderController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}
