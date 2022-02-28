using Microsoft.AspNetCore.Mvc;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Madlib() { return View(); }
    [Route("/story")]
    public ActionResult Story() { return View(); }
  }
}