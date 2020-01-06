using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Choices() {return View();}

    [Route("/MadLibs")]
    public ActionResult MadLibs(string verb, string noun, string adj, string pNoun, string game, string verbing, string plant, string bodyPart, string place, int number)
    {
      ChoiceVariable myChoiceVariable = new ChoiceVariable();

      myChoiceVariable.Noun = noun;
      myChoiceVariable.Verb = verb;
      myChoiceVariable.Adjective = adj;
      myChoiceVariable.PNoun = pNoun;
      myChoiceVariable.Game = game;
      myChoiceVariable.Verbing = verbing;
      myChoiceVariable.Plant = plant;
      myChoiceVariable.BodyPart = bodyPart;
      myChoiceVariable.Place = place;
      myChoiceVariable.Number = number;
      
      return View(myChoiceVariable);
    }
  }
}