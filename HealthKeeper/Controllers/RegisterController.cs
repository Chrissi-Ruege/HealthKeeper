using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

public class RegisterController:Controller{
    public ActionResult Index(){
        return View();
    }
}