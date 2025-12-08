using System;

class Task3
{
    static void Main()
    {
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

        Console.Write("Enter a number to search for: ");
        int target = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine($"Number found at position {i}!");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Number was not found in the list.");
        }
    }
}
