using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            Console.WriteLine("Введiть значення a:");
            bool checkA = Double.TryParse(Console.ReadLine(), out a);
            while (!checkA||Convert.ToInt32(a)==a)
            {
                Console.WriteLine("Введiть коректне значення a:");
                checkA = Double.TryParse(Console.ReadLine(), out a);
            }
            Console.WriteLine("Введiть значення b:");
            bool checkB = Double.TryParse(Console.ReadLine(), out b);
            while (!checkB || Convert.ToInt32(b) == b)
            {
                Console.WriteLine("Введiть коректне значення b:");
                checkB = Double.TryParse(Console.ReadLine(), out b);
            }
            Console.WriteLine("Введiть значення x:");
            bool checkX = Double.TryParse(Console.ReadLine(), out x);
            while (!checkX || Convert.ToInt32(x) == x)
            {
                Console.WriteLine("Введiть коректне значення x:");
                checkX = Double.TryParse(Console.ReadLine(), out x);
            }
            double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine("y = " + y);
        }
    }
}
