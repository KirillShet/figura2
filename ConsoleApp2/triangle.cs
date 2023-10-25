using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class triangle1: circle1
    {
        private float p;
        protected float c;
        private float s; 
        private float d;
        private float x;

        public void info5()
        {
            do
            {
                d = 0;
                Console.WriteLine("Введите сторону фигуры.");
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                c = float.Parse(Console.ReadLine());
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("Вы ввели не то число.");
                    d++;
                }
            } while (d == 1);
            if (a > b)
            {
                if (a > c)
                { x = a; a = c; c = x; }
            }
            else if (b > a)
            {
                if (b > c)
                { x = b; b = c; c = x; }
            }
        }
        private void type()
        {
            if (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            if (Math.Pow(c, 2) > (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                Console.WriteLine("Треугольник тупоугольный");
            }
            if (Math.Pow(c, 2) < (Math.Pow(a, 2) + Math.Pow(b, 2)))
            {
                Console.WriteLine("Треугольник остроугольный");
            }
            if (a != c && a != b && b != c)
            {
                Console.WriteLine("Треугольник разносторонний");
            }
            if (a == b && a == c && c == b)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
        }
        protected override void perimeter()
        {
            Console.WriteLine(a + b + c);
        }
        protected override void Square()
        {
            p = (a + b + c) / 2;
            s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(s);
        }
        public void out_info3()
        {
            Console.Write("Периметр фигуры: "); perimeter();
            Console.Write("Площадь фигуры: "); Square();
            type();
        }
    }
}