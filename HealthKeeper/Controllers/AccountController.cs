using HealthKeeper.Models;
using HealthKeeper.Models.Views;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HealthKeeper.Controllers;

[AllowAnonymous]
[Route("[controller]")]
public class AccountController : Controller
{
    private DatabaseContext _ctx;
    private SignInManager<IdentityUser> _signInManager;
    private UserManager<IdentityUser> _userManager;

    public AccountController(DatabaseContext ctx, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
    {
        _ctx = ctx;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [HttpPost("Login")]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Login(LoginForm form, string? returnUrl)
    {
        if (!ModelState.IsValid)
        {
            return View(new ErrorViewModel("Ungültiger Status."));
        }

        var result = await _signInManager.PasswordSignInAsync(form.UserName, form.Password, true, false);

        if (result == Microsoft.AspNetCore.Identity.SignInResult.Success)
        {
            return Redirect(returnUrl ?? "/");
        }

        return View(new ErrorViewModel("Falscher Nutzername oder Password"));
    }

    [HttpPost("Register")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterForm form)
    {
        if (ModelState.IsValid)
        {
            var user = new IdentityUser { UserName = form.Username, Email = form.Email };
            var result = await _userManager.CreateAsync(user, form.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, true);
                return RedirectToAction("Index", "Home");
            }
            return View(new ErrorViewModel() { Error = result.Errors.First().Description });
        }

        return View(new ErrorViewModel() { Error = "Modell ist ungültig" });
    }

    [HttpGet("Login")]
    public ActionResult Login()
    {
        var vm = new ErrorViewModel()
        {
        };
        return View(vm);
    }

    [HttpGet("Register")]
    public ActionResult Register()
    {
        return View(new ErrorViewModel());
    }
}