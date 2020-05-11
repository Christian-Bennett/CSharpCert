using System;
using System.Linq;

namespace Del
{
    class Program
    {
        delegate void d(int n);
        static void Main(string[] args)
        {
            //Does not have a return value
            Action<int> op = n => Console.WriteLine("{0} x 2 = {1}", n, n*2);
            
            //Does have return value
            Func<int, int> dop = x => { return x * 2; };

            //d op = n => { Console.WriteLine("{0} x 2 = {1}", n, n*2); };
            op(2);
            System.Console.WriteLine(dop(3));
            
        }
    }
}
