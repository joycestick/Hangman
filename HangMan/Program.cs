using Hangman.Logic;
using HangMan;

var wp = new WordProvider();
var game = new Game(wp.GetRandomWord(), 6);

Console.WriteLine(game.CurrentStatus());

while (!game.Finished)
{
    Console.WriteLine("Guess a letter or press SPACE to quit");
    var input = Console.ReadLine();
    if (input == " ") break;
    switch (game.GuessLetter(input.ToUpperInvariant()[0]))
    {
        case GuessResponse.AlreadyGuessed:
            Console.WriteLine("You already guessed that letter!");
            break;
        case GuessResponse.Correct:
            Console.WriteLine("Correct!");
            break;
        case GuessResponse.Incorrect:
            Console.WriteLine("Wrong! You lose a life.");
            break;
    }
    Console.WriteLine(game.CurrentStatus());
    Console.WriteLine(game.Lives + " Lives Remaining");  
}
