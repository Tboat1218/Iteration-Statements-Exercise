using System;

namespace ChallengesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Running all challenge methods ===\n");

            // LukeWarm Section
            PrintNumbersThousandToMinusThousand();
            PrintNumbersByThree();

            Console.Write("Enter the first integer: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckIfNumbersAreEqual(firstNumber, secondNumber)
                ? "The numbers are equal."
                : "The numbers are not equal.");

            Console.Write("Enter a number to check if it is even or odd: ");
            int numberForEven = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckIfNumberIsEven(numberForEven)
                ? $"{numberForEven} is even."
                : $"{numberForEven} is odd.");

            Console.Write("Enter a number to check if it is positive or negative: ");
            int numberForPositive = int.Parse(Console.ReadLine());
            if (numberForPositive == 0)
                Console.WriteLine("Zero is neither positive nor negative.");
            else
                Console.WriteLine(CheckIfNumberIsPositive(numberForPositive)
                    ? $"{numberForPositive} is positive."
                    : $"{numberForPositive} is negative.");

            Console.Write("Enter your age to check voting eligibility: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckVotingEligibility(age)
                ? "You may vote."
                : "Looks like you're too young this time!");

            // Heating Up Section
            Console.Write("Enter a number to check if it's in range -10 to 10: ");
            int numberForRange = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckIfNumberIsInRange(numberForRange)
                ? $"{numberForRange} is in the range -10 to 10."
                : $"{numberForRange} is not in the range -10 to 10.");

            Console.Write("Enter a number to display its multiplication table: ");
            int numberForTable = int.Parse(Console.ReadLine());
            DisplayMultiplicationTableForUser(numberForTable);

            Console.WriteLine("\n=== Program complete. ===");
        }

        // --- LukeWarm Section ---
        public static void PrintNumbersThousandToMinusThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintNumbersByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static bool CheckIfNumbersAreEqual(int firstNumber, int secondNumber)
        {
            return firstNumber == secondNumber;
        }

        public static bool CheckIfNumberIsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool CheckIfNumberIsPositive(int number)
        {
            return number > 0;
        }

        public static bool CheckVotingEligibility(int age)
        {
            return age >= 18;
        }

        // --- Heating Up Section ---
        public static bool CheckIfNumberIsInRange(int number)
        {
            return number >= -10 && number <= 10;
        }

        public static void DisplayMultiplicationTableForUser(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
