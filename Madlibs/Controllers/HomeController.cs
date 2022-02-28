using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Madlib() { return View(); }
    [Route("/story")]
    public ActionResult Story(string fastFoodName, string fastFoodItem) 
    { 
      StoryVariable userInput = new StoryVariable();
      userInput.FastFoodName = fastFoodName;
      userInput.FastFoodItem = fastFoodItem;
      return View(userInput); 
    }
  }
}