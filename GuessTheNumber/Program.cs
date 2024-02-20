using System;


namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            int guess = 0;

            Console.WriteLine("Welcome to Guess the Number! Try to guess the randomly generated number. It will be a number between 1 and 10.");
            do
            {
                
                guess = Convert.ToInt32(Console.ReadLine());
                if(guess < randomNumber && guess != randomNumber)
                {
                    Console.WriteLine("Try a higher number!");
                } else if(guess > randomNumber && guess != randomNumber)
                {
                    Console.WriteLine("Try a lower number!");
                }

            } while (guess != randomNumber);

            Console.WriteLine("Congrats! You guessed the number. The number was {0}", randomNumber);
        }
    }
}
