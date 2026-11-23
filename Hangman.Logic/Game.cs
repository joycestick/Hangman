using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.Logic
{
    public class Game
    {
        private readonly Word _word;
        private int _lives;

        public Game(string word,int lives )
        {
            _word = new Word(word);
            Lives = lives;
        }

        public bool Finished => Lives == 0 || false;

        public int Lives { get => _lives; set => _lives = value; }

        public bool GuessLetter(string letter)
        {
            if (_word.GuessLetter(letter)) return true;
            Lives--;
            return false;
        }

        public string CurrentStatus()
        {
            return _word.Status();
        }
    }
}
