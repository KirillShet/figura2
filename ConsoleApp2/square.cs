using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class square1
    {
        protected float a;
        protected float d;
        public virtual void info5()
        {
            do
            {
                d = 0;
                Console.WriteLine("Введите число.");
                this.a = float.Parse(Console.ReadLine());
                if (this.a <= 0)
                {
                    Console.WriteLine("Вы ввели не то число.");
                    d++;
                }
            } while (d == 1);
        }
        protected virtual void perimeter()
        {
            Console.WriteLine(a * 4);
        }
        protected virtual void Square()
        {
            Console.WriteLine(a * a);
        }
        public void out_info()
        {
            Console.Write("Периметр фигуры: "); perimeter();
            Console.Write("Площадь фигуры: "); Square();
        }
    }
}