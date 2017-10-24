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
      _checkPhrase = checkPhrase;

      char[] dividers = { ' ', ',', '.', ':', '!', '?', '&' };

      string[] dividedPhrase = checkPhrase.ToLower().Split(dividers);

      for(int i = 0; i < dividedPhrase.Length; i++)
      {
        if (_searchWord == dividedPhrase[i])
        {
          wordCountTotal += 1;
        }
      }
      return wordCountTotal.ToString();
    }
  }
}
