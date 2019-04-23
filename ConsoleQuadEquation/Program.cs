using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuadEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            Console.WriteLine("Введiть значення a:");
            bool checkA = Double.TryParse(Console.ReadLine(), out a);
            while (!checkA || Convert.ToInt32(a) == a|| a==0)
            {
                Console.WriteLine("Введiть коректне значення a:");
                checkA = Double.TryParse(Console.ReadLine(), out a);
            }
            Console.WriteLine("Введiть значення b:");
            bool checkB = Double.TryParse(Console.ReadLine(), out b);
            while (!checkB || Convert.ToInt32(b) == b||b==0)
            {
                Console.WriteLine("Введiть коректне значення b:");
                checkB = Double.TryParse(Console.ReadLine(), out b);
            }
            Console.WriteLine("Введiть значення с:");
            bool checkС = Double.TryParse(Console.ReadLine(), out c);
            while (!checkС || Convert.ToInt32(c) == c||c==0)
            {
                Console.WriteLine("Введiть коректне значення с:");
                checkС = Double.TryParse(Console.ReadLine(), out c);
            }
            double d = b * b - 4 * a * c;
            if (d == 0)
            {
                double x = -1 * (b / (2 * a));
                Console.WriteLine("D = {0}, x = {1}.", d, x);
            }
            else if (d > 0)
            {
                double x1 = -1 * ((b + Math.Sqrt(d)) / (2 * a));
                double x2 = -1 * ((b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("D = {0}, x1 = {1}, x2 = {2}.", d, x1, x2);
            }
            else
            {
                Console.WriteLine("Розв'язкв немає.");
            }
        }
    }
}
