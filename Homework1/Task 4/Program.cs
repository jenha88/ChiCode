using System;

namespace Task_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            double slope;
            double Xvalue;
            double B;
            int num;
         

            Console.WriteLine("Please type in the slope (m)");
            slope = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please type in the x-value:");
            Xvalue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please type in the y-value:");
            B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please type in a number you would like see a factorial for:");
            num = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine($"The answer for the Line Value is:{LineValueForY(slope,Xvalue,B)}");
            Console.WriteLine($"The factorial number for {num} is: {Factorial(num)}");
          
        }
 
        public static double LineValueForY(double m, double x, double b)
        {

            double answer = m * x + b;

            return answer;
        }
        public static double Factorial(int num)
        {
            int answer=num;
            for (int i = num - 1; i > 0; i--)
            {
                num *= i;
            }
            return num;
        }
    }
}
