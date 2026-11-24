namespace Hangman.Logic
{
    public class Game
    {
        private readonly Word _word;
        private int _lives;
        private readonly Dictionary<char, bool> _guessedLetters;
        
        public Game(string word, int lives)
        {
            _word = new Word(word);
            _lives = lives;
            _guessedLetters = new Dictionary<char, bool>();
        }
        public string Answer => _word.Answer;
        public bool OutOfLives => Lives == 0;
        public int Lives => _lives; 
        public bool Won => !_word.Status().Contains("_") && Lives > 0;

        public GuessResponse GuessLetter(char letter)
        {
            if (_guessedLetters.ContainsKey(letter)) return GuessResponse.AlreadyGuessed;
            _guessedLetters.Add(letter, false);
            if (_word.GuessLetter(letter)) return GuessResponse.Correct;
            _lives--;
            return GuessResponse.Incorrect;
        }

        public string CurrentStatus()
        {
            return _word.Status();
        }
    }
}
