using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

[Route("[controller]")]
public class LoginController : Controller
{

    private DatabaseContext _ctx;

    public LoginController(DatabaseContext ctx)
    {
        _ctx = ctx;
    }

    public ActionResult Index()
    {
        return View();
    }
}