using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

[AllowAnonymous]
[Route("[controller]")]
public class SportController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}