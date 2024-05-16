using Microsoft.AspNetCore.Mvc;

namespace HealthKeeper.Controllers;

[Route("[controller]")]
public class AccountController : Controller
{

    private DatabaseContext _ctx;

    public AccountController(DatabaseContext ctx)
    {
        _ctx = ctx;
    }

    [HttpGet("Login")]
    public ActionResult Login()
    {
        return View();
    }
}