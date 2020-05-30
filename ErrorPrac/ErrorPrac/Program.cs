using Demo;
using System;

namespace ErrorPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCode demo = new DemoCode();

            try
            {
                int res = demo.gpm(4);
                Console.WriteLine($"Value at position is {res}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }
    }
}
