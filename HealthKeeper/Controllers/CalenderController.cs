using HealthKeeper.Models.Views;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

[Authorize]
[Route("[controller]")]
public class CalenderController : Controller
{

    private static List<PostCalenderEntry> _postCalenderEntries = new();

    [HttpGet]
    public ActionResult Index()
    {
        return View(_postCalenderEntries);
    }


    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Index(PostCalenderEntry body, IdentityUser user)
    {
        _postCalenderEntries.Add(body);
        return View(_postCalenderEntries);
    }
}
