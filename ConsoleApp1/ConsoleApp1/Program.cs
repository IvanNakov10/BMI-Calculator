using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your kilograms: ");
            int kg = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height: ");
            int height = int.Parse(Console.ReadLine());

            double BMI = kg / Math.Pow(height, 2);

            if (BMI < 18.5)
            {
                Console.WriteLine("Low");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("High");
            }
        }
    }
}
