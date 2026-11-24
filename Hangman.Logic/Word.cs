namespace Hangman.Logic
{
    public class Word
    {
        private readonly string _answer;
        private readonly char[] _status;

        public string Answer => _answer;

        public Word(string answer)
        {
            _answer = answer.ToUpperInvariant();
            _status = new char[_answer.Length];
            for (int i = 0; i < _answer.Length; i++)
            {
                _status[i] = '_';
            }
        }

       public string Status()
        {
            return string.Join(" ", _status);
        }

        public bool GuessLetter(char letter)
        {
            if (_answer.Contains(letter, StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < _answer.Length; i++)
                {
                    if (letter == _answer[i])
                    {
                        _status[i] = _answer[i];
                    }
                }
                return true;
            }
            return false;
        }


    }
}
