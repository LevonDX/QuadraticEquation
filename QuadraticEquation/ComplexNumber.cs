using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    public struct ComplexNumber
    {
        private double b;

        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public ComplexNumber(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            if (b == 0)
                return $"{a}";

            if (a == 0)
                return $"i{b}"; 

            return $"{a} + i{b}";
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.a + c2.a, c1.b + c2.b);
        }

        public static implicit operator double(ComplexNumber c)
        {
            if (c.B != 0)
            {
                throw new InvalidCastException("Cannot convert complex number to double");
            }

            return c.A;
        }

    }
}