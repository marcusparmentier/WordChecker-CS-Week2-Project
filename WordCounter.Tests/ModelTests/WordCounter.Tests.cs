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
      RepeatCounter newCount = new RepeatCounter("word", "word");
      var expected = "1";

      //Action
      var result = newCount.CountRepeats();

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CountRepeatsLowerCase_CompareStrings_String()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter("Word", "worD");
      var expected = "1";

      //Action
      var result = newCount.CountRepeats();

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CountRepeatsDivide_CompareStrings_String()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter("wordS", "Words to check");
      var expected = "1";

      //Action
      var result = newCount.CountRepeats();

      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void CountRepeatsDivide2_CompareStrings_String()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter("Word", "word Word woRd wOrD");
      var expected = "4";

      //Action
      var result = newCount.CountRepeats();

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CountRepeatsDivideSpecialChars_CompareStrings_String()
    {
      //Arrange
      RepeatCounter newCount = new RepeatCounter("word", "Word, words. woRd: WORDS & WORD!");
      var expected = "3";

      //Action
      var result = newCount.CountRepeats();

      //Assert
      Assert.AreEqual(expected, result);
    }
  }
}
