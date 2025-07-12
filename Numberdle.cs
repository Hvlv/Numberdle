using System;
using System.Collections.Generic;
using System.Linq;

class Numberle
{
    static void Main(string[] args)
    {
        string secretCode = null;
        int attempts = 10;

        //Command line
        for (int i = 0; i < args.Length - 1; i++)
        {
            if (args[i] == "-c")
                secretCode = args[i + 1];
            else if (args[i] == "-t")
                int.TryParse(args[i + 1], out attempts);
        }

        //Generates a random code if the player didnt write any
        if (string.IsNullOrEmpty(secretCode))
            secretCode = RandomCode();

        Console.WriteLine("Can you break the code? Enter a valid guess.");

        //Loop
        for (int attempt = 1; attempt <= attempts; attempt++)
        {
            Console.Write($"Attempt {attempt}/{attempts}: ");
            string guess = Console.ReadLine();

            
            if (guess == null)
                return;

            //Checks if the guess is correct
            if (!CorrectGuess(guess))
            {
                Console.WriteLine("Invalid guess. Please enter 4 distinct digits between 0 and 8.");
                attempt--; // Don't count invalid guess as an attempt
                continue;
            }

            //if the player got the code right
            if (guess == secretCode)
            {
                Console.WriteLine("Congratz! You did it!");
                return;
            }

            //Counts the placement of numbers
            int wellPlaced = 0;
            int misplaced = 0;

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == secretCode[i])
                    wellPlaced++;
            }

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] != secretCode[i] && secretCode.Contains(guess[i]))
                    misplaced++;
            }

            Console.WriteLine($"Well-placed pieces: {wellPlaced}");
            Console.WriteLine($"Misplaced pieces: {misplaced}");
        }

        Console.WriteLine("You lost! The code was: " + secretCode);
    }

    //Generates a random code with 4 digits
    static string RandomCode()
    {
        List<char> digits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
        Random rand = new Random();
        return new string(digits.OrderBy(x => rand.Next()).Take(4).ToArray());
    }

    static bool CorrectGuess(string guess)
    {
        return guess.Length == 4 && guess.All(char.IsDigit) && guess.All(c => c >= '0' && c <= '8') && guess.Distinct().Count() == 4;
    }
}
