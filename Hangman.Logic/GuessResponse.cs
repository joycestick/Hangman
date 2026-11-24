using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.Logic
{
    public enum GuessResponse
    {
        NotSpecified = 0,
        Correct,
        Incorrect,
        AlreadyGuessed,
    }
}
