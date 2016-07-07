using System.Collections.Generic;
using System;

namespace NumberToWords.Objects
{
  public class NumberWords
  {
    // public int input;
    // public int number;
    // public string word;
    // public string digits;
    // public string output;



    // public static List<string> instances = new List<string> {};
    // public static List<string> wordFromNumbers = new List<string> {};
    //
    // public Dictionary<string, string> NumberTranslatorOnes = new Dictionary<string, string>()
    // {
    //   {"1", "one"},
    //   {"2", "two"},
    //   {"3", "three"},
    //   {"4", "four"},
    //   {"5", "five"},
    //   {"6", "six"},
    //   {"7", "seven"},
    //   {"8", "eight"},
    //   {"9", "nine"},
    //   {"0", "zero"},
    //   {"11", "eleven"},
    //   {"12", "twelve"},
    //   {"13", "thirteen"},
    //   {"14", "fourteen"},
    //   {"15", "fifteen"},
    //   {"16", "sixteen"},
    //   {"17", "seventeen"},
    //   {"18", "eighteen"},
    //   {"19", "nineteen"}
    // };
    //
    // public Dictionary<string, string> NumberTranslatorTens = new Dictionary<string, string>()
    // {
    //   {"1", "ten"},
    //   {"2", "twenty"},
    //   {"3", "thirty"},
    //   {"4", "fourty"},
    //   {"5", "fifty"},
    //   {"6", "sixty"},
    //   {"7", "seventy"},
    //   {"8", "eighty"},
    //   {"9", "ninety"}
    // };
    //
    // public Dictionary<string, string> NumberTranslatorHundreds = new Dictionary<string, string>()
    // {
    //   {"1", "one hundred"},
    //   {"2", "two hundred"},
    //   {"3", "three hundred"},
    //   {"4", "four hundred"},
    //   {"5", "five hundred"},
    //   {"6", "six hundred"},
    //   {"7", "seven hundred"},
    //   {"8", "eight hundred"},
    //   {"9", "nine hundred"}
    // };

    public int input;
    private int[] _numbers = new int[] {0,1,2,3,4,5,6,7,8,9};
    private string[] _ones = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    private string[] _teens = new string[] {"zero", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
    private string[] _tens = new string[] {"zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eightty", "ninety"};
    private string[] _hundreds = new string[] {"zero", "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred"};

    // public static GetNumbers()
    // {
    //   return _numbers;
    // }


    int inputLength = 3;

    public string GetWordNumber(int input)
    {
      if ( inputLength == 1 ){
        return _ones[input / 1];
      }
      else if ( inputLength == 2 && input < 20 ){
        return _teens[input / 10];
      }
      else if ( inputLength == 2 && input > 20 ){
        return _tens[input / 10];
      }
      else if ( inputLength == 3 ){
        return _hundreds[input / 100];
      }
      else
      {
        return "screw you";
      }
    }

    // public string NumberTranslator(int input)
    // {
    //   output = input.ToString();
    //   Console.WriteLine(output);
    //   wordFromNumbers.Add(NumberTranslatorHundreds["1"] + NumberTranslatorTens["2"] + NumberTranslatorOnes["3"]);
    //
    //   if (wordFromNumbers.Count == 3)
    //   {
    //     string result = wordFromNumbers[0] + " " + wordFromNumbers[1] + " " + wordFromNumbers[2];
    //     Console.WriteLine(result);
    //     return result;
    //   }
    //   else
    //   {
    //     string result = wordFromNumbers[0];
    //     Console.WriteLine(result);
    //     return result;
    //   }
    //
    // }
  }
}
