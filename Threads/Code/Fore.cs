using System;
using System.Threading;

namespace Code
{
  public static class Fore
  {
    public static void loop(object o)
    {
      for(int i = 0; i < (int)o; i++)
      {
        Console.WriteLine("ThreadProc {0}", i);
        Thread.Sleep(400);
      }
    }
  }
}