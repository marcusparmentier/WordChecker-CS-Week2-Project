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
  }
}
