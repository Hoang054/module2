using System;
using System.Threading;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var nubodd = new OddThread();
            var numeven = new EvenThread();
            Thread thread1 = new Thread(nubodd.Run);
            Thread thread2 = new Thread(numeven.Run);
            thread1.Start();
            thread1.Join();
            thread2.Start();
        }
    }
    class OddThread
    {
        public void Run()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
                Thread.Sleep(10);
            }
        }
    }
    class EvenThread
    {
        public void Run()
        {
            for(int i =1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                Thread.Sleep(15);
            }
        }
    }
}
