using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int grade = 0;
            int inputs = 0;
            string answer;
            do
            {
                Console.WriteLine("Please type in your exam score");
                grade = Convert.ToInt32(Console.ReadLine());
                inputs++;

                Console.WriteLine("Do you have another score to input?: yes/no");
                answer = Console.ReadLine().ToLower();
            } while (answer=="yes");

            if (answer=="no")
            {
                Console.WriteLine($"Your total grade entry is {inputs}");
                Console.WriteLine($"The average of your test scores is {grade}");
            }
        }
    }
}
