using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

public class LoginController:Controller{
    public ActionResult Index(){
        return View("Login");
    }
    public ActionResult Register(){
        return View();
    }
}