// See https://aka.ms/new-console-template for more information
Console.WriteLine("Omar & Michael");

#region Hide Number
int myGuess = 8;
#endregion

Console.WriteLine("What is the number you guess, guess a number between 1-10?");
int guessNumber = Convert.ToInt32(Console.ReadLine());
if (guessNumber == myGuess)
{
    Console.WriteLine("That is Right");
}
else if (guessNumber != myGuess)
{
    Console.WriteLine("You chose poorly");
}
if (guessNumber > 10 || guessNumber < 1)
{
    Console.WriteLine("Please pick numbers between 1-10");
}
Console.WriteLine("Made minor change to check username");

