using HangMan;
Console.WriteLine("Welcome to hangman press f5 to start!");
var word=new Word("Hello");
Console.WriteLine(word.Status());
var x = word.GuessLetter("w");



Console.Write("Enter your guess: ");
string answer = Console.ReadLine() ?? "";


 