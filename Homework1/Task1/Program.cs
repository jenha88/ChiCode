using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double avg = 0;
            double grade = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter in your exam grade:");
                grade = Convert.ToDouble(Console.ReadLine());
                avg = grade / 3;
            }
   
            Console.WriteLine($"The average for the exams: {avg}");






        }
    }
}
