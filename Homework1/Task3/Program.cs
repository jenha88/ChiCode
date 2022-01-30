using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int grade = 0;
            string answer;
            do
            {
                Console.WriteLine("Please type in your exam score");
                grade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Do you have another score to input?: yes/no");
                answer = Console.ReadLine().ToLower();
            } while (answer!="yes");
            if (answer=="no")
            {
                
            }
        }
    }
}
