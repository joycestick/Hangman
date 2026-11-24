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
            Lives = lives;
            _guessedLetters = new Dictionary<char, bool>();
        }

        public bool Finished => Lives == 0 || !_word.Status().Contains("_");

        public int Lives { get => _lives; set => _lives = value; }
        public bool Won { get; set; }

        public GuessResponse GuessLetter(char letter)
        {
            if (_guessedLetters.ContainsKey(letter)) return GuessResponse.AlreadyGuessed;
            _guessedLetters.Add(letter, false);
            if (_word.GuessLetter(letter)) return GuessResponse.Correct;
            Lives--;
            return GuessResponse.Incorrect;
        }

        public string CurrentStatus()
        {
            return _word.Status();
        }
    }
}
