using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
    return View();
    }
    [HttpPost("/result")]
    public ActionResult Result()
    {
      RepeatCounter newCounter = new RepeatCounter(Request.Form["wordcheck"], Request.Form["phrasecheck"]);
      return View("result", newCounter);
    }
  }
}
