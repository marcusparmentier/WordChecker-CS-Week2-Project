using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/result")]
    public ActionResult Result()
    {
      RepeatCounter newCountCheck = new RepeatCounter(Request.Form["searchWordInput"], Request.Form["checkPhraseInput"]);
      return View(newCountCheck);
    }

  }
}
