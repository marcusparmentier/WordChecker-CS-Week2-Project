using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {

    [TestMethod]
    public void SearchCount_CompareStrings_String()
    {
      //Arrange
      WordCounterCS newCount = new WordCounterCS();
      var expected = "1";

      //Action
      var result = newCount.SearchCount("word", "word");

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void SearchCountLowerCase_CompareStrings_String()
    {
      //Arrange
      WordCounterCS newCount = new WordCounterCS();
      var expected = "1";

      //Action
      var result = newCount.SearchCount("Word", "worD");

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void SearchCountDivide_CompareStrings_String()
    {
      //Arrange
      WordCounterCS newCount = new WordCounterCS();
      var expected = "1";

      //Action
      var result = newCount.SearchCount("wordS", "Words to check");

      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void SearchCountDivide2_CompareStrings_String()
    {
      //Arrange
      WordCounterCS newCount = new WordCounterCS();
      var expected = "4";

      //Action
      var result = newCount.SearchCount("Word", "word Word woRd wOrD");

      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void SearchCountDivideSpecChars_CompareStrings_String()
    {
      //Arrange
      WordCounterCS newCount = new WordCounterCS();
      var expected = "3";

      //Action
      var result = newCount.SearchCount("word", "Word, words. woRd: WORDS & WORD!");

      //Assert
      Assert.AreEqual(expected, result);
    }
  }
}
