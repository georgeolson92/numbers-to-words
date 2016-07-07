using System.Collections.Generic;
using System;

namespace NumberToWords.Objects
{
  public class NumberWords
  {
    public string input;
    public int number;
    public string word;

    public Dictionary<string, string> NumberTranslatorOnes = new Dictionary<string, string>()
    {
      {"1", "one"},
      {"2", "two"},
      {"3", "three"},
      {"4", "four"},
      {"5", "five"},
      {"6", "six"},
      {"7", "seven"},
      {"8", "eight"},
      {"9", "nine"},
      {"0", "zero"},
      {"11", "eleven"},
      {"12", "twelve"},
      {"13", "thirteen"},
      {"14", "fourteen"},
      {"15", "fifteen"},
      {"16", "sixteen"},
      {"17", "seventeen"},
      {"18", "eighteen"},
      {"19", "nineteen"}
    };

    public Dictionary<string, string> NumberTranslatorTens = new Dictionary<string, string>()
    {
      {"10", "ten"},
      {"20", "twenty"},
      {"30", "thirty"},
      {"40", "fourty"},
      {"50", "fifty"},
      {"60", "sixty"},
      {"70", "seventy"},
      {"80", "eighty"},
      {"90", "ninety"}
    };

    public Dictionary<string, string> NumberTranslatorHundreds = new Dictionary<string, string>()
    {
      {"100", "one hundred"},
      {"200", "two hundred"},
      {"300", "three hundred"},
      {"400", "four hundred"},
      {"500", "five hundred"},
      {"600", "six hundred"},
      {"700", "seven hundred"},
      {"800", "eight hundred"},
      {"900", "nine hundred"}
    };

    public string NumberTranslator(string input)
    {
      string digits = input.Length.ToString();
      // double digits = Math.Floor(Math.Log10(input) + 1);
      Console.WriteLine(input);
      Console.WriteLine(digits);

      string value;

      if (digits == "3")
      {
        value = NumberTranslatorHundreds[input];
        Console.WriteLine(value);
        return NumberTranslatorHundreds[input];
      }
      else if (digits == "2")
      {
        value = NumberTranslatorTens[input];
        Console.WriteLine(value);
        return NumberTranslatorTens[input];
      }
      else if (digits == "1")
      {
        value = NumberTranslatorOnes[input];
        Console.WriteLine(value);
        return NumberTranslatorOnes[input];
      }
      else
      {
        return "nothing!";
      }
    }


  }
}
