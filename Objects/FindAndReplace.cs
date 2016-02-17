using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace FindAndReplace.Objects
{
  public class FindAndReplaceWord
  {
    private string _input1;
    private string _input2;
    private string _input3;

    public FindAndReplaceWord(string myInput1, string myInput2, string myInput3)
    {
      _input1 = myInput1;
      _input2 = myInput2;
      _input3 = myInput3;
    }

    public string GetResults()
    {
      string[] phraseArray = _input1.Split(' ');
      for(var i = 0; i < phraseArray.Length; i++)
      {
        if(phraseArray[i].ToLower() == _input2.ToLower())
        {
          phraseArray[i] = _input3;
        }
      }
      string results = string.Join(" ", phraseArray);
      return results;
    }
  }
}
