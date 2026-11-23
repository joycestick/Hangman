using Hangman.Logic;
using HangMan;


var game = new Game(WordProvider.GetRandomWord(), 6);

while (!game.Finished)
{
    Console.WriteLine("Guess a letter...");
    var letter = Console.ReadLine() ?? "";
    if (game.GuessLetter(letter))
    {
        Console.WriteLine("correct");
    }
    else
    {
        Console.WriteLine("wrong");
    }
    Console.WriteLine(game.CurrentStatus());
    Console.WriteLine(game.Lives + " Lives Remaning");  
}
