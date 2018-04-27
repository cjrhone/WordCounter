using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _phrase;
        private int _counter;

        public RepeatCounter(string word, string phrase, int counter)
        {
            _word = word;
            _phrase = phrase;
            _counter = counter;
        }

        public string GetWord()
        {
            return _word;
        }

        public string GetPhrase()
        {
            return _phrase;
        }

        public int GetCounter()
        {
            return _counter;
        }

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

        public int CounterCheck()
        {
            int _counter = 0;

            for (int i = 0; i <= _phrase.Length; i++)
            {
                  if (_phrase.ToUpper().Contains(_word.ToUpper()))
                  {
                    _counter += 1;
                  }
                  else
                  {

                  }
            }


          return _counter;
        }
    }
}
