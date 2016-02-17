using System;
using FindAndReplace.Objects;
using Nancy;
using System.Collections.Generic;

namespace FindAndReplace.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        string result = "";
        return View["index.cshtml", result];
      };
      Post["/"] = _ => {
        FindAndReplaceWord newFindAndReplaceWord = new FindAndReplaceWord(Request.Form["input1"], Request.Form["input2"], Request.Form["input3"]);
        string result = newFindAndReplaceWord.GetResults();
        return View["index.cshtml", result];
      };
    }
  }
}
