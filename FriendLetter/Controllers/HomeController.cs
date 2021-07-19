using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Letter () 
    { 
      return View(new LetterVariable("Lina", "Jasmine")); 
    }

    [Route("/postcard")]
    public ActionResult Postcard (LetterVariable model)
    {
      return View("Letter", model);
    }

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/form")]
    public ActionResult Form ()
    {
      return View();
    }
  }
}