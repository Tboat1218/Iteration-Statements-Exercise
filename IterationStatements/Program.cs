using System;

namespace IterationStatements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Iteration Statements Assignment!");
            Console.WriteLine("------------------------------------------------\n");

            PrintNumbers();
            PrintEveryThirdNumber();
            CheckIfNumbersAreEqual();
            CheckIfNumberIsEven();
            CheckIfNumberIsPositive();
            CheckVotingEligibility();
            CheckIfNumberIsInRange();
            DisplayMultiplicationTableForUser();
        }

        // 1. Print numbers 1000 through -1000
        public static void PrintNumbers()
        {
            Console.WriteLine("\nNumbers from 1000 to -1000:");
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Print numbers from 3 to 999, counting by 3
        public static void PrintEveryThirdNumber()
        {
            Console.WriteLine("\nNumbers from 3 to 999 by 3s:");
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Accept two integers and check if equal
        public static void CheckIfNumbersAreEqual()
        {
            Console.Write("\nEnter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
                Console.WriteLine("The numbers are equal.");
            else
                Console.WriteLine("The numbers are not equal.");
        }

        // 4. Check if a number is even or odd
        public static void CheckIfNumberIsEven()
        {
            Console.Write("\nEnter a number to check if it is even or odd: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine($"{number} is even.");
            else
                Console.WriteLine($"{number} is odd.");
        }

        // 5. Check if a number is positive or negative
        public static void CheckIfNumberIsPositive()
        {
            Console.Write("\nEnter a number to check if it is positive or negative: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
                Console.WriteLine($"{number} is positive.");
            else if (number < 0)
                Console.WriteLine($"{number} is negative.");
            else
                Console.WriteLine("The number is zero.");
        }

        // 6. Read age and determine if user can vote
        public static void CheckVotingEligibility()
        {
            Console.Write("\nEnter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age >= 18)
                    Console.WriteLine("You may vote!");
                else
                    Console.WriteLine("Looks like you're too young this time!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        // 7. Check if number is in the range -10 to 10
        public static void CheckIfNumberIsInRange()
        {
            Console.Write("\nEnter a number to check if it is between -10 and 10: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= -10 && number <= 10)
                Console.WriteLine($"{number} is within the range -10 to 10.");
            else
                Console.WriteLine($"{number} is outside the range -10 to 10.");
        }

        // 8. Display multiplication table for a given number
        public static void DisplayMultiplicationTableForUser()
        {
            Console.Write("\nEnter a number to display its multiplication table: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nMultiplication Table for {number}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }
    }
}
