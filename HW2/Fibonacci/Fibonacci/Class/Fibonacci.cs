using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonacci.Class
{
    public class Fibonacci
    {
        public Fibonacci()
        {
            res = new List<long>();
        }
        public int num { get; set; }

        public List<long> res { get; set; }

        public void Method(int n)
        {
            //Func<double, double> fib = null;
            //fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;

            //for (int i = 0; i < num; ++i)
            //    fib(i);


            long a = 0, b = 1, total = 0, i;  
            //int n = x;  
            for (i = 1; i <= n; i++) {  
                total = a + b;  
                a = b;  
                b = total;  
                total = a;  
                res.Add(total);
            }

        }
    }
}
