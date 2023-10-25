using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class rectangle1 : square1
    {
        protected float b;
        public override void info5()
        {
            do
            {
                d = 0;
                Console.WriteLine("Введите сторону фигуры.");
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                if (a <= 0 || b <= 0)
                {
                    Console.WriteLine("Вы ввели не то число.");
                    d++;
                }
            } while (d == 1);
        }
        protected override void perimeter()
        {
            Console.WriteLine(a * 2 + this.b * 2);
        }
        protected override void Square()
        {
            Console.WriteLine(a * this.b);
        }
        public void out_info2()
        {
            Console.Write("Периметр фигуры: "); perimeter();
            Console.Write("Площадь фигуры: ");  Square();
        }
    }
}