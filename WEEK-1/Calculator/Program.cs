using System;

Console.WriteLine("-----------------------------------");
Console.WriteLine("    Modern .NET Calculator App     ");
Console.WriteLine("-----------------------------------\n");

while (true)
{
    // 1. Get the first number
    Console.Write("Enter the first number: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    // 2. Get the operator
    Console.Write("Enter an operator (+, -, *, /) or 'q' to quit: ");
    string op = Console.ReadLine()?.Trim().ToLower();

    if (op == "q")
    {
        Console.WriteLine("Thanks for using the calculator! Goodbye.");
        break;
    }

    // 3. Get the second number
    Console.Write("Enter the second number: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    // 4. Perform the calculation
    double result = 0;
    bool validOperation = true;

    switch (op)
    {
        case "+":
            result = num1 + num2;
            break;
        case "-":
            result = num1 - num2;
            break;
        case "*":
            result = num1 * num2;
            break;
        case "/":
            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                validOperation = false;
            }
            else
            {
                result = num1 / num2;
            }
            break;
        default:
            Console.WriteLine("Invalid operator selected.");
            validOperation = false;
            break;
    }

    // 5. Display the result
    if (validOperation)
    {
        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }

    Console.WriteLine("\n-----------------------------------\n");
}