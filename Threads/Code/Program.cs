using System;
using System.Collections.Generic;
using System.Threading;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcct acct = new BankAcct(30);

            Thread[] threads = new Thread[40];

            Thread.CurrentThread.Name = "main";

            for(int i = 0; i < 40; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.RemoveFunds));
                t.Name = i.ToString();
                threads[i] = t;
            }

            for (int i = 0; i < 40; i++)
            {

                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);


            }

            Console.WriteLine("Current Priority : {0}",
                Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);

                Console.ReadLine();

        }
    }
}
