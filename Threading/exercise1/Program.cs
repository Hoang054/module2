using System;
using System.Threading;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nbg1 = new NumberGenerator();
            var nbg2 = new NumberGenerator();
            Thread thread1 = new Thread(nbg1.Run);
            Thread thread2 = new Thread(nbg2.Run);
            thread1.Priority = ThreadPriority.Lowest;
            thread2.Priority = ThreadPriority.Highest;
            thread1.Start();
            thread2.Start();
            Console.WriteLine(nbg1.GetHashCode());
            Console.WriteLine(nbg2.GetHashCode());
            Console.ReadKey();
        }
    }
    class NumberGenerator
    {
        public void Run()
        {
            for(int i = 1; i< 11; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
                //Console.WriteLine(GetHashCode());
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
