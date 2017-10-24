using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _searchWord;
    private string _checkPhrase;
    public int wordCountTotal = 0;

    public RepeatCounter(string searchWord, string checkPhrase)
    {
      _searchWord = searchWord;
      _checkPhrase = checkPhrase;
    }

    public string CountRepeats()
    {
      _searchWord = _searchWord.ToLower();
      _checkPhrase = _checkPhrase.ToLower();

      char[] dividers = { ' ', ',', '.', ':', '!', '?', '&' };

      string[] dividedPhrase = _checkPhrase.Split(dividers);

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
