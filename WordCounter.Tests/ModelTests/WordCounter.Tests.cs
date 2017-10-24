using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {

    [TestMethod]
    public void CountRepeats_CompareStrings_String()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter();
      var expected = "1";

      //Action
      var result = newCount.CountRepeats("word", "word");

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CountRepeatsLowerCase_CompareStrings_String()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter();
      var expected = "1";

      //Action
      var result = newCount.CountRepeats("Word", "worD");

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CountRepeatsDivide_CompareStrings_String()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter();
      var expected = "1";

      //Action
      var result = newCount.CountRepeats("wordS", "Words to check");

      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void CountRepeatsDivide2_CompareStrings_String()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter();
      var expected = "4";

      //Action
      var result = newCount.CountRepeats("Word", "word Word woRd wOrD");

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CountRepeatsDivideSpecialChars_CompareStrings_String()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter();
      var expected = "3";

      //Action
      var result = newCount.CountRepeats("word", "Word, words. woRd: WORDS & WORD!");

      //Assert
      Assert.AreEqual(expected, result);
    }
  }
}
