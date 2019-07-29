using Microsoft.AspNetCore.Mvc;
using Madlib.Models;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    // [Route("/")]
    // public string Letter() { return "Our virtual postcard will go here soon!"; }


    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }
    
    [Route("/madlibCard")]
    public ActionResult MadlibCard(string reader, string suspect, string item1, string item2, string victim1, string day)
    {
      MadlibVariable myMadlibVariable = new MadlibVariable();
      myMadlibVariable.Reader = reader;
      myMadlibVariable.Suspect = suspect;
      myMadlibVariable.Item1 = item1;
      myMadlibVariable.Item2 = item2;
      myMadlibVariable.Victim1 = victim1;
      myMadlibVariable.Day = day;
      return View(myMadlibVariable);
    }
  }
}
