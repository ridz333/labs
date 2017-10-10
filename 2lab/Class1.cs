using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
     abstract class figure
 {
    public abstract double Area(); // вычисление площади

    /// <summary>
    /// Приведение к строке, переопределение метода Object
    /// </summary>
    public override string ToString()
    {
      return this.Area().ToString();       
    }
 }
    
    class rectangle: figure,IPrint
    {
        /// <summary>
        /// Высота
        /// </summary>
        double height;

        /// <summary>
        /// Ширина
        /// </summary>
        double width;


        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double Area()
        {
            double Result = width * height;

            return Result;
        }

        public void Print()
        {
            if (width != height) { Console.WriteLine("Площадь прямоугольника: "); } else { Console.WriteLine("Площадь квадрата: "); }  // выводит сообщение какая это геометрическая фигура;
            Console.WriteLine(this.ToString() );
        }
    }

   
    
    class square : rectangle, IPrint
    {
        public square(double size)
            : base(size, size)
        {
        }
    }

       class circle : figure, IPrint
    {
        /// <summary>
        /// Ширина
        /// </summary>
        double radius;

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="ph">Высота</param>
        /// <param name="pw">Ширина</param>
        public circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            double Result = Math.PI * this.radius * this.radius;
            Console.WriteLine("Площадь круга:");
            return Result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}


