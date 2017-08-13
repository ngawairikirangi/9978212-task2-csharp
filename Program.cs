using System;

namespace cstask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, sum, avg;

            Console.WriteLine("Please enter 10 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());
            num6 = Convert.ToInt32(Console.ReadLine());
            num7 = Convert.ToInt32(Console.ReadLine());
            num8 = Convert.ToInt32(Console.ReadLine());
            num9 = Convert.ToInt32(Console.ReadLine());
            num10 = Convert.ToInt32(Console.ReadLine());

            sum=(num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10);
            avg = (sum / 10);

            Console.WriteLine("The total sum is:"+sum);
            Console.WriteLine("The Average is:" + avg);

            Console.ReadLine();
            
        }
    }
}
