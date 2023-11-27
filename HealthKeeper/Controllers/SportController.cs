using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

public class SportController:Controller{
    public ActionResult Index(){
        return View();
    }
}