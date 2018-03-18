using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Numbers
    {
        int a;
        int b;

        public Numbers(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Sum()
        {
            return a + b;
        }
    }
}
