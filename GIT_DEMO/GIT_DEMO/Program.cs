using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addtwonumbers(10,40));
            Console.WriteLine(product(34,78));
        }
        #region Add Two num
        public static int Addtwonumbers(int a, int b)
        {
            int c = a + b;
            return c;
        }
        #endregion

        #region Add Two product
        public static int product(int c, int d)
        {
            int e = c * d;
            return e;
        }
        #endregion
    }
}
