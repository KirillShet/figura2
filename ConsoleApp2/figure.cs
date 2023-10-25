using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class figure: Vod
    {
        public float a1;
        public float b1;
        public float c1;
        public float P;
        public float V;
        public float Ap;
        public float S;
        protected float perimeter(float a1, float b1)
        {
            P = a1 * 2 + b1 * 2;
            return P;
        }
        protected float Square(float a1, float b1)
        {
            S = a1 * b1;
            return S;
        }
        protected float perimeter1(float a1)
        {
            P = 2 * (float)Math.PI * a1;
            return P;
        }
        protected float Square1(float a1)
        {
            S = (float)Math.PI * (float)Math.Pow(a1, 2);
            return S;
        }

        protected float perimeter2(float a1, float b1, float c1)
        {
            P = a1 + b1 + c1;
            return P;
        }
        protected float Square2(float a1, float b1, float c1)
        {
            S = (float)Math.Sqrt(perimeter2(a1, b1, c1) / 2 * (perimeter2(a1, b1, c1) / 2 - a1) * (perimeter2(a1, b1, c1) / 2 - b1) * (perimeter2(a1, b1, c1) / 2 - c1));
            return S;
        }
       
    }
}
