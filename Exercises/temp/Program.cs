﻿using System;
using Exercises;

class Program
{
    static void Main(string[] args)
    {
        // Variable to store user choice
        int choice = -1;

        // Start the Loop that will keep showing the options until user exits the program.

        while (choice != 0)
        {
            Console.WriteLine("-------------------------------------------"); // visible line break
            // Define the available options in a string array
            string[] options = {
            "0 - Exit",
            "1 - ASCII Art with 'L'",
            "2 - Reversing Numbers",
            "3 - Water Pouring",
            "4 - Box Arrangement"
        };

            // Display the options to the user
            Console.WriteLine("Choose an option:");
            foreach (var option in options)
            {
                Console.WriteLine(option);
            }



            // Read user input
            string input = Console.ReadLine();
            Console.WriteLine("-------------------------------------------"); // visible line break
            // Try to convert the input to an integer
            if (int.TryParse(input, out choice))
            {
                // Use a switch statement to handle different cases based on user input
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting the Program...");
                        break;
                    case 1:
                        ASCIIArtPrompt();
                        break;
                    case 2:
                        ReverseNumberPrompt();
                        break;
                    case 3:
                        WaterPourPrompt();
                        break;
                    case 4:
                        BoxArrangmentPrompt();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter a valid number.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    // Solution 1: ASCII Art with 'L'
    static void ASCIIArtPrompt()
    {
        Console.WriteLine("Please Enter an Integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int N))
        {
            ASCII.solution(N);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    // Solution 2: Reversing Numbers
    static void ReverseNumberPrompt()
    {
        // Read user input
        Console.Write("Enter a Number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int N))
        {
            // Call the solution method
            ReverseNumber.solution(N);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    // Solution 3: Another solution
    static void WaterPourPrompt()
    {
        // Read user input
        Console.Write("Enter two numbers separated by a space.\n The First number is number of glasses,\n the second number is amount of water.: ");
        string input = Console.ReadLine();

        // Split the input based on spaces
        string[] parts = input.Split(' ');

        // Check if exactly two parts are provided
        if (parts.Length == 2 &&
            int.TryParse(parts[0], out int N) &&
            int.TryParse(parts[1], out int K))
        {
            // Both numbers parsed successfully, now call the solution method
            int result = WaterPour.solution(N, K);
            if ( result != -1)
            {
                Console.WriteLine($"You used {result} glass/es to pour {K} liters.");
            }
            else
            {
                Console.WriteLine($"It is not possible to pour {K} liters into {N} cup/s.");
            }

        }
        else
        {
            // Provide feedback if parsing fails
            Console.WriteLine("Invalid input. Please enter two valid integers separated by a space.");
        }
    }

    static void BoxArrangmentPrompt()
    {
        Console.WriteLine("Please enter an array of numbers seperated by commas (e.g 1,2,3,4,5): ");
        string input = Console.ReadLine();

        // Split input string into an arrray of strings
        string[] parts = input.Split(',');

        // Create an integer array of the same length
        int[] A = new int[parts.Length];

        // Parse each part into the integer array
        for (int i = 0; i < parts.Length; i++)
        {
            if (int.TryParse(parts[i].Trim(), out int num)) // Trim to remove any extra spaces
            {
                A[i] = num;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter vaild integers.");
                return; ///Exit the method if invaild input.
            }
        }

        int moves = BoxArrangement.solution(A);
        Console.WriteLine($"Total moves required: {moves}");


    }
}

