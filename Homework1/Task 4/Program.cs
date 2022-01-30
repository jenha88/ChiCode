using System;

namespace Task_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(LineValueForY());
            Factorial();
          
            
        }
 
        public static double LineValueForY(double m, double x, double b)
        {
            Console.WriteLine("Please type in the slope (m)");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please type in the x-value:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please type in the y-value:");
            b = Convert.ToDouble(Console.ReadLine());

            double answer = m * x + b;

            return answer;
        }
        public  double Factoiral(int num)
        {
            double result = 1;
            while (num != 1)
            {
                result = result * num;
                num = num - 1;
            }
            return result;
        }
    }
}
