using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class circle1: rectangle1
    {
        protected float r;
        public override void info5()
        {
            do
            {
                d = 0;
                Console.WriteLine("Введите число.");
                this.r = float.Parse(Console.ReadLine());
                if (this.r <= 0)
                {
                    Console.WriteLine("Вы ввели не то число.");
                    d++;
                }
            } while (d == 1);
        }
        protected override void perimeter()
        {
            Console.WriteLine(2 * (float)Math.PI * r);
        }
        protected override void Square()
        {
            Console.WriteLine((float)Math.PI * (float)Math.Pow(r, 2));
        }
        public void out_info1()
        {
            Console.Write("Периметр фигуры: "); perimeter();
            Console.Write("Площадь фигуры: "); Square();
        }
    } 
}