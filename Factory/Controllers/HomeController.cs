using Microsoft.AspNetCore.Mvc;
using Factory.Models;

namespace Factory.Controllers 
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Engineer> engineers = _db.Engineers.ToList();
        List<Machine> machines = _db.Machines.ToList();
        ViewBag.engineers = engineers;
        ViewBag.machines = machines;
        return View();
      }

    }
}