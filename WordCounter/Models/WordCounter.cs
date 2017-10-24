using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class WordCounterCS
  {
    private string _searchWord;
    private string _checkPhrase;
    public int wordCountTotal = 0;

    public string SearchCount(string searchWord, string checkPhrase)
    {
      _searchWord = searchWord.ToLower();
      _checkPhrase = checkPhrase.ToLower();

      if (_searchWord == _checkPhrase)
      {
        wordCountTotal += 1;
      }

      return wordCountTotal.ToString();
    }
  }
}
