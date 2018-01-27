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

        int GCD(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            while(x != y)
            {
                if (x > y)
                {
                    x -= y;
                }
                if (y > x)
                {
                    y -= x;
                }
            }
            return x;
        }

        void Simp()
        {
            int q = GCD(a, b);
            a /= q;
            b /= q;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.a = c1.a * c2.b + c2.a * c1.b;
            c.b = c1.b * c2.b;
            c.Simp();
            return c;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.a = c1.a * c2.b - c2.a * c1.b;
            c.b = c1.b * c2.b;
            c.Simp();
            return c;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.a = c1.a * c2.a;
            c.b = c1.b * c2.b;
            c.Simp();
            return c;
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.a = c1.a * c2.b;
            c.b = c1.b * c2.a;
            c.Simp();
            return c;
        }
        public override string ToString()
        {
            if (a == 0) return "0";
            if (a == b) return "1";
            if (b == 1) return a + "";
            return a + "/" + b;
        }
    }
}
