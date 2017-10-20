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
    public void CheckStringForWords_CompareStrings_True()
    {
      //Arrange
      WordCounterCS newCount = new WordCounterCS();

      //Action
      var result = newCount.SearchCount("word", "word");
      var expected = "1";

      //Assert
      Assert.AreEqual(expected, result);
    }
  }
}
