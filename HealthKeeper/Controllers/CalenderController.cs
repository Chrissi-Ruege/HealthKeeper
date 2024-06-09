using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

[Authorize]
[Route("[controller]")]
public class CalenderController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}
