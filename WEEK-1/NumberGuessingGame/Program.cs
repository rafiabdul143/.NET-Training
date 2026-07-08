using System;

Console.WriteLine("=========================================");
Console.WriteLine("       Welcome to the Guessing Game!     ");
Console.WriteLine("=========================================\n");

// 1. Generate a random number between 1 and 100
Random randomGenerator = new Random();
int targetNumber = randomGenerator.Next(1, 101);
Console.WriteLine(targetNumber);

int totalAttempts = 0;
bool hasWon = false;

Console.WriteLine("I have chosen a hidden number between 1 and 100.");
Console.WriteLine("Can you guess what it is?\n");

// 2. Loop until the player wins
while (hasWon == false)
{
    // Ask for the player's guess
    Console.Write("Enter your guess: ");
    string userInput = Console.ReadLine();
    int playerGuess = Convert.ToInt32(userInput);
    
    // Increase attempt counter by 1
    totalAttempts = totalAttempts + 1;

    // 3. Compare the guess using basic IF conditions
    if (playerGuess == targetNumber)
    {
        hasWon = true; // This will break the while loop on the next turn
        
        Console.WriteLine("\n=========================================");
        Console.WriteLine("        🎉 CONGRATULATIONS! 🎉          ");
        Console.WriteLine("=========================================");
        Console.WriteLine($"You guessed the correct number: {targetNumber}");
        Console.WriteLine($"It took you {totalAttempts} total attempts.");
        Console.WriteLine("=========================================");
    }
    else if (playerGuess > targetNumber)
    {
        Console.WriteLine("Too high! Try a lower number.\n");
    }
    else
    {
        Console.WriteLine("Too low! Try a higher number.\n");
    }
}