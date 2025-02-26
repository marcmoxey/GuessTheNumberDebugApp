
using GuessTheNumberDebug;




/*
 * 
 * Create a number-guessing game where the program generates a random number, and the user has
 * to guess it. Use breakpoints to debug the logic and track the game's state.
 * 
 * Steps:
 * Generate a random number between 1 and 100.
 * Ask the user to guess the number.
 * Use breakpoints to inspect the random number and the user's input.
 * Add logic to provide hints (e.g., "Too high" or "Too low") and use breakpoints to debug this
 * logic.
 * Track the number of attempts and use breakpoints to verify the count.
 */

var rand = new Random();
int randNum = rand.Next(1, 101);
int numAttempts = 0;
int userGuess;



do
{
    Console.Write("Enter and number between 1-100: ");
    string userInput = Console.ReadLine();

    if (!int.TryParse(userInput, out userGuess))
    {
        Console.WriteLine("Invalid input. Please enter a number");
    }
    numAttempts++;

    int difference = Math.Abs(randNum - userGuess);


    if (userGuess < randNum)
    {
        Console.WriteLine("To Low!");
    }
    else if (userGuess > randNum)
    {
        Console.WriteLine("Too High");
    }
    else
    {
        Console.WriteLine($"You got it! The number was {randNum} it took you {numAttempts} attempts");
    }

} while (userGuess != randNum);