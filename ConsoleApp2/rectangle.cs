using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class rectangle1 : square1
    {

        protected float b;
        public void info5(float a5, float b5)
        {
            a = a5; this.b = b5;
        }
        protected override void perimeter()
        {
            Console.WriteLine(a * 2 + this.b * 2);
        }
        protected override void Square()
        {
            Console.WriteLine(a * this.b);
        }
        public void out_info2(float a2, float b2)
        {
            Console.Write("Периметр фигуры: "); perimeter();
            Console.Write("Площадь фигуры: ");  Square();
        }
    }
}