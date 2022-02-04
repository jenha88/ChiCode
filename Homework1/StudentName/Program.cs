using System;

namespace StudentName
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[35];
            string answer = string.Empty;
            string name = string.Empty;
            int j = 0;

            do
            {
                Console.WriteLine("Enter in names");
                name = Console.ReadLine();
                studentNames[j] = name;

                Console.WriteLine("Continue yah or -1");
                answer = Console.ReadLine();

                j++;
            } while (answer != "-1");

            if (studentNames.Length == 0)
            {
                Console.WriteLine("There are no students.");
            }
            else
            {
                for (int i = 0; i < studentNames.Length; i++)
                {
                    Console.WriteLine(studentNames[i].ToString());
                }
            }
        }
    }
}
