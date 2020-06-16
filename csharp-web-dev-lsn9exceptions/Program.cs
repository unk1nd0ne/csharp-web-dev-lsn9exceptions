using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Divisor cannot be 0");
            }
            else
            {
                return x / y;
            }
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            string theGradePoint;
            if (fileName == null || fileName.Length == 0)
            {
                throw new ArgumentNullException("Cannot be empty!");
            }
            else
            {
                theGradePoint = fileName.Split(".")[1];
                if (theGradePoint == "cs")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            Console.WriteLine("In Main");
            try
            {
                double result = Divide(6, 0);
                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (string key in students.Keys)
            {
                try
                {
                    Console.WriteLine($"Name: {key}, Grade: {CheckFileExtension(students[key])}");
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine($"Name: {key}, Error: {e.Message}");
                }
            }
        }
    }
}
