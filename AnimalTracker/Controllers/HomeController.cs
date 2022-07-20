using Microsoft.AspNetCore.Mvc;

namespace AnimalTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}