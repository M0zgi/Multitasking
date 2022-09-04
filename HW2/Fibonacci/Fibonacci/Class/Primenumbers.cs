using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Fibonacci.Class
{
    public class Primenumbers
    {
        //public List<int> res = new List<int>();

        public Primenumbers()
        {
            res = new List<int>();
        }
        public List<int> res { get; set; }

        public bool IsPrime(int x)
        {
            for (int i = 2; i < x; i++)
                if ((x % i) == 0) 
                    return false;
            if (x <= 1) 
                return false;
            return true;
        }

        public List<int> Res(int x, int y)
        {
            int n = x;
            int m = y;
            for (int i = n; i < m; i++)
                if (IsPrime(i))
                    res.Add(i);
            return res;
        }
    }
}
