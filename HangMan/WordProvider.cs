using System;

using System.Collections.Generic;

using System.Security.Cryptography;

using System.Text;



namespace HangMan

{

    internal interface IWordProvider

    {

        string GetRandomWord();

    }



    internal class RandomWebWordProvider : IWordProvider

    {

        public string GetRandomWord() => "";

    }



    internal class WordProvider : IWordProvider

    {

        public string GetRandomWord()

        {

            var r = new Random();

            return (int)(r.NextDouble() * 6) switch

            {

                0 => "Welcome",

                1 => "Hangman",

                2 => "Ollie",

                3 => "Loser",

                4 => "Idea",

                5 => "Well",

                _ => throw new IndexOutOfRangeException()

            };

        }

    }

}
