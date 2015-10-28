using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class FibonacciNumbers : NaturalNumbers
    {
        public FibonacciNumbers()
        {
            first = 1;
            increment = 0;
        }

        public override int GetNext(int a)
        {
            int next = a + increment;
            increment = a;
            return next;

            /* Another solution
            int next = increment;
            increment = a;
            return x + next;
            */
        }
    }
}
