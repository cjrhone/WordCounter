using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Models
{
    public class WordCounter
    {
        private string _word;
        private string _phrase;
        private int _counter;

        public WordCounter(string word string phrase int counter)
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

        public int RepeatCounter()
        {

            if (phrase.Contains(word))
            {
              coun
            }


        }
    }
}
