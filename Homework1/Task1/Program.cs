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
            double grade2 = 0;
            double grade3 = 0;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Enter in your exam grade:");
                grade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter in your exam 2 grade:");
                grade2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter in your exam 3 grade:");
                grade3 = Convert.ToDouble(Console.ReadLine());
                avg = ((grade + grade2 + grade3) /3)/100;

            }
            
            Console.WriteLine($"The average for the exams: {avg:P2}");






        }
    }
}
