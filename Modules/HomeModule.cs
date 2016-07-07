using Nancy;
using System;
using System.Collections.Generic;
using NumberToWords.Objects;

namespace NumberToWords
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {

        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        NumberWords numberWord = new NumberWords();
        string numberinput = numberWord.GetWordNumber(Request.Form["numberinput"]);
        return View["index.cshtml", numberinput];
      };
    }
  }
}
