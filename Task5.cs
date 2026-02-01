using System;

class Task5
{
    static void Main()
    {
        Console.Write("Enter Total Students : ");
        int totalStudents;

        while (!int.TryParse(Console.ReadLine(), out totalStudents) || totalStudents <= 0)
        {
            Console.Write("Invalid input. Enter a valid number of students: ");
        }

        string[,] students = new string[totalStudents, 5];

        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine("\n*********************************************");
            Console.Write("Enter Student Name : ");
            students[i, 0] = Console.ReadLine();

            int english = ReadMarks("Enter English Marks (Out Of 100) : ");
            int math = ReadMarks("Enter Math Marks (Out Of 100) : ");
            int computer = ReadMarks("Enter Computer Marks (Out Of 100) : ");

            int total = english + math + computer;

            students[i, 1] = english.ToString();
            students[i, 2] = math.ToString();
            students[i, 3] = computer.ToString();
            students[i, 4] = total.ToString();
        }

        for (int i = 0; i < totalStudents - 1; i++)
        {
            for (int j = i + 1; j < totalStudents; j++)
            {
                if (int.Parse(students[i, 4]) < int.Parse(students[j, 4]))
                {
                    for (int k = 0; k < 5; k++)
                    {
                        string temp = students[i, k];
                        students[i, k] = students[j, k];
                        students[j, k] = temp;
                    }
                }
            }
        }

        Console.WriteLine("\n****************Report Card*******************");

        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine(
                $"Student Name: {students[i, 0]}, Position: {i + 1}, Total:\n{students[i, 4]}/300"
            );
        }

        Console.WriteLine("****************************************");
        Console.ReadKey();
    }

    static int ReadMarks(string message)
    {
        int marks;
        Console.Write(message);

        while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
        {
            Console.Write("Invalid marks. Enter a value between 0 and 100: ");
        }

        return marks;
    }
}
