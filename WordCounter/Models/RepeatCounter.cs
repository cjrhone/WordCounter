using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _phrase;
        // private int _counter;

        public RepeatCounter(string word, string phrase)
        {
            _word = word;
            _phrase = phrase;
            // _counter = counter;
        }

        public string GetWord()
        {
            return _word;
        }

        public string GetPhrase()
        {
            return _phrase;
        }

        // public int GetCounter()
        // {
        //     return _counter;
        // }

        public bool WordCheck()
        {

            if (_phrase.ToUpper().Contains(_word.ToUpper()))
            {
              return true;
            }
            else
            {


            }

          return false;
        }

  //This is where I failed. Wasn't sure how to count each word within a phrase
        public int CounterCheck()
        {
            int _counter = 0;

            for (int i = 0; i <= _phrase.Length; i++)
            {
                  foreach(var word in _phrase.ToUpper())
                  {

                      if ( _phrase.ToUpper().Contains(_word.ToUpper()))
                      {
                        _counter += 1;
                      }
                      else
                      {

                      }
                  }
            }

          return _counter;
        }
    //This is where I failed. Wasn't sure how to count each word within a phrase without the word parameter being a "Char" type
    //I think maybe two for loops, one looping a phrase.Length, and another looping word.Length could work -- but I didn't know how to apply that.
    }
}
