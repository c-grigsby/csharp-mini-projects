using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola From Program.cs!");
            //ExploreIf();

            //While Loop
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"While Loop: The counter is {counter}");
                counter++;
            }
            // Do/While Loop
            int counter2 = 0;
            do
            {
                Console.WriteLine($"Do/While Loop: The counter is {counter}");
                counter2++;
            } while (counter2 < 10);

            // For Loop
            for (int index = 0; index < 10; index++)
            {
                System.Console.WriteLine($"For Loop: The index is {index}");
            }

            // Nested Loop
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }

        }//main

        static void ExploreIf()
        {
            Console.WriteLine("--------BranchesAndLoops----------");
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is less than 10.");
            }
            Console.WriteLine("------------------");
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
            Console.WriteLine("------------------");
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }//ExploreIf()
    }
}
