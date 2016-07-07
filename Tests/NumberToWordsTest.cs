using System;
using System.Collections.Generic;
using Xunit;
using NumberToWords.Objects;

namespace NumberToWords
{
  public class NumberToWordsTest
  {
    [Fact]
    public void NumberToWordsFor_OneHundred()
    {
      string wordoutput = "one hundred";
      NumberWords numberWord = new NumberWords();
      string numberinput = numberWord.NumberTranslator("100");
      Assert.Equal(wordoutput, numberinput);
    }

    [Fact]
    public void NumberToWordsFor_Ten()
    {
      string wordoutput = "ten";
      NumberWords numberWord = new NumberWords();
      string numberinput = numberWord.NumberTranslator("10");
      Assert.Equal(wordoutput, numberinput);
    }

    [Fact]
    public void NumberToWordsFor_One()
    {
      string wordoutput = "one";
      NumberWords numberWord = new NumberWords();
      string numberinput = numberWord.NumberTranslator("1");
      Assert.Equal(wordoutput, numberinput);
    }

    [Fact]
    public void NumberToWordsFor_OneHundredTwentyThree()
    {
      string wordoutput = "one hundred twenty three";
      NumberWords numberWord = new NumberWords();
      string numberinput = numberWord.NumberTranslator("123");
      Assert.Equal(wordoutput, numberinput);
    }
  }
}
