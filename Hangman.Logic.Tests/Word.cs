using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.Logic
{
    public class Word
    {
        private readonly string _answer;
        private List<string> _correctlyGuessedLetters = new List<string>();

        public Word(string answer)
        {
            _answer = answer.ToUpperInvariant();
        }

       public string Status()
        {
            var underscores = new string[_answer.Length];
            for (int i = 0; i < underscores.Length; i++)
            {
                underscores[i] = "_";
            }
            return string.Join(" ", underscores);
        }
        public bool GuessLetter (string letter )
        {
            if (_answer.Contains(letter.ToUpperInvariant()))
            {
                _correctlyGuessedLetters.Add(letter);
                return true;
            }
            return false;
        }


    }
}
