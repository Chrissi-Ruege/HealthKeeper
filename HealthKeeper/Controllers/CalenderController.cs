using Microsoft.AspNetCore.Mvc;
namespace HealthKeeper.Controllers;

public class CalenderController:Controller{
    public ActionResult Index(){
        return View();
    }
}
