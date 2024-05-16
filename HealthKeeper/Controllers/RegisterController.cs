using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

[Route("[controller]")]
public class RegisterController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}