using Microsoft.AspNetCore.Mvc;
using AnimalTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalTracker.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalTrackerContext _db;

    public AnimalsController(AnimalTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animals.ToList();
      return View(model);
    }
  }
}