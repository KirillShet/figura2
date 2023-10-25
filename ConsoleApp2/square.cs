using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class square1: Vod
    {
        protected float a;
        public void info5(float a5)
        {
            this.a = a5;
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