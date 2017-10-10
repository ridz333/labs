using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle Rectangle = new rectangle(5, 4);
            square Square = new square(5);
            circle Circle = new circle(5);

            Rectangle.Print();
            Square.Print();
            Circle.Print();

            Console.ReadLine();
        }
    }
}
