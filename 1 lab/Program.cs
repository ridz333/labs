using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, discrem;
            double x1, x2;
            do
            {
                Console.Write("\nВведите коэф A,B,C. \n");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0) do { Console.Write("\n коэф А не может быть равен 0, введите его повторно\n"); a = Convert.ToInt32(Console.ReadLine()); } while (a == 0);
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                discrem = b * b - 4 * a * c;
                if (discrem < 0) { Console.Write("\n Дискрименант из этих коэф. меньше 0\n Введите значения коэф. заного\n"); }
            } while (discrem < 0);

            if (discrem == 0)
            {
                x1 = (-b / (2 * a));
                Console.Write("\n D= " + discrem + "   Корень = " + x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(discrem)) / (2 * a);
                x2 = (-b - Math.Sqrt(discrem)) / (2 * a);
                Console.Write("\n D= " + discrem + "\n  Корень1 = " + x1 + "\n Корень 2 = " + x2);
            }
            Console.ReadKey();
        }
    }
}