using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Vod
    {
        public float a;
        public float b;
        public float h;
        public float r;
        public float n;
        public float c;
        protected float d;
        private float x;
        public void info(out float a)
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
            a = this.a;
        }
        
        public void info1(out float a, out float b)
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
        public void info2(out float a, out float b, out float c) 
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
        public void info3(out float a, out float h, out float n, out float r)
        {
            Console.WriteLine("Введите высоту пирамиды.");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите, какое должно быть основание: круг - 1 или n-угольник - 2");
            int change = Convert.ToInt32(Console.ReadLine());
            if (change == 2)
            {
                Console.WriteLine("Введите количество углов многоугольника.");
                this.n = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите длинну стороны основания.");
                this.a = float.Parse(Console.ReadLine());
                
            }
            else if (change == 1)
            {
                Console.WriteLine("Введите радиус круга.");
                this.r = float.Parse(Console.ReadLine());
            }
            a = this.a;
            n = this.n;
            r = this.r;
        }
    }
}
