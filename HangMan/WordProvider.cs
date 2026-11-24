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
            var words = new List<string> { "Welcome", "Hangman", "Ollie", "Loser", "Idea", "Well", "Joke", "Hold", "Joining", "Rook" };
            var randomIndex = r.Next(words.Count);
            return words[randomIndex];
        }

    }

}





            

        

    

