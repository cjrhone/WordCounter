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

        public bool CounterCheck()
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
    }
}
