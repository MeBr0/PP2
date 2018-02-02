using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Complex
    {
        int a, b;

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Complex()
        {

        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.a = c1.a + c2.a;
            c.b = c1.b + c2.b;
            return c;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.a = c1.a - c2.a;
            c.b = c1.b - c2.b;
            return c;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.a = c1.a * c2.a;
            c.b = c1.b * c2.b;
            return c;
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.a = c1.a / c2.a;
            c.b = c1.b / c2.b;
            return c;
        }
        public override string ToString()
        {
            return a + "+" + b + "i";
        }
    }
}
