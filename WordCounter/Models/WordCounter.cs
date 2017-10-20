using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class WordCounterCS
  {
    // private string _searchWord;
    // private string _checkPhrase;
    public int wordCountTotal = 0;

    public string SearchCount(string searchWord, string checkPhrase)
    {
      if (searchWord == checkPhrase)
      {
        wordCountTotal += 1;
      }

      return wordCountTotal.ToString();
    }
  }
}
