using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);
            
            for (int Count = 1; ; Count++)
            {
                string GuessedNumber, response;

                Console.Write("Insert number: ");
                GuessedNumber = Console.ReadLine();

                int GuessedInt = int.Parse(GuessedNumber);

                if (GuessedInt > 30 || GuessedInt < 0)
                {
                    response = $"Numbers must be between 0 and 30. Try again.";
                    Console.WriteLine(response);
                    continue;
                }

                if (GuessedInt > numberToGuess)
                {
                    response = $"The hidden number is lower than {GuessedInt}. Try Again.";
                    Console.WriteLine(response);
                    continue;
                }

                if (GuessedInt < numberToGuess)
                {
                    response = $"The hidden number is higher than {GuessedInt}. Try Again.";
                    Console.WriteLine(response);
                    continue;
                }

                if (GuessedInt == numberToGuess)
                {
                    response = $"You found the hidden number {numberToGuess} after {Count} tries.";
                    Console.WriteLine(response);
                    break;
                }
            }
        }
    }
}
