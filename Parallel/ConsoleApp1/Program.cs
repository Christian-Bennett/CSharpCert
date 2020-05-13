using System;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new CancellationTokenSource();
            try
            {
                var t1 = Task.Factory.StartNew(() => Work(1, 1200, source.Token)).ContinueWith((pt) => MoreWork(1, 2000, source.Token));
                source.Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }
            
            

            Console.WriteLine("Press");
            Console.ReadKey();
        }

        static void Work(int id, int sleepT, CancellationToken token)
        {
            if(token.IsCancellationRequested)
            {
                Console.WriteLine("Cancel Imminent");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("Task {0} Start", id);
            Thread.Sleep(sleepT);
            Console.WriteLine("Task {0} End", id);

        }

        static void MoreWork(int id, int sleepT, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancel Imminent");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("MoreWork {0} Start", id);
            Thread.Sleep(sleepT);
            Console.WriteLine("MoreWork {0} End", id);

        }
    }
}


//var t1 = Task.Factory.StartNew(() => Work(1, 1500));
//var t2 = Task.Factory.StartNew(() => Work(2, 3000));
//var t3 = Task.Factory.StartNew(() => Work(3, 1000));

//var taskList = new List<Task> { t1, t2, t3 };
//Task.WaitAll(taskList.ToArray());

//            for(var i = 0; i< 10; i++)
//            {
//                Console.WriteLine("Doing some other work");
//                Thread.Sleep(250);
//                Console.WriteLine("i = {0}", i);
//            }