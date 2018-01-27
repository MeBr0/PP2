using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Complex
    {
        int GCD(int a, int b)
        {
           while(a != b)
            {
                if(a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
        int a;
        int b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Complex()
        {

        }
        public void Simp()
        {
            int w = GCD(Math.Abs(this.a), Math.Abs(this.b));
            this.a /= w; //this.a = this.a / w;
            this.b /= w;
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
            if(c.b < 0)
            {
                c.a = -1 * c.a;
                c.b = -1 * c.b;
            }
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
