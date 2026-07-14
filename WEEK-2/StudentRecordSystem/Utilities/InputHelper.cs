using System;

namespace StudentRecordSystem.Utilities
{
    public static class InputHelper
    {
        // Read Integer
        public static int ReadInt(string message)
        {
            int value;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter a valid integer.");
                Console.ResetColor();
            }
        }

        // Read Double
        public static double ReadDouble(string message)
        {
            double value;

            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter a valid number.");
                Console.ResetColor();
            }
        }

        // Read String
        public static string ReadString(string message)
        {
            while (true)
            {
                Console.Write(message);

                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input cannot be empty.");
                Console.ResetColor();
            }
        }

        // Read Email
        public static string ReadEmail(string message)
        {
            while (true)
            {
                Console.Write(message);

                string email = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(email) &&
                    email.Contains("@") &&
                    email.Contains("."))
                {
                    return email.Trim();
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid email address.");
                Console.ResetColor();
            }
        }

        // Read Phone Number
        public static string ReadPhone(string message)
        {
            while (true)
            {
                Console.Write(message);

                string phone = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(phone) &&
                    phone.Length == 10 &&
                    long.TryParse(phone, out _))
                {
                    return phone;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Phone number must contain exactly 10 digits.");
                Console.ResetColor();
            }
        }

        // Pause Screen
        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}