using System;
using System.Threading;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var checkprime1 = new azyPrimeFactorization();
            var checkprime2 = new OptimizedPrimeFactorization();
            var thread1 = new Thread(checkprime1.Run);
            var thread2 = new Thread(checkprime2.Run);
            thread1.Start();
            thread2.Start();

        }
    }
    class azyPrimeFactorization
    {
        public void Run()
        {
            int i = 2;
            
            while (true)
            {
                bool check = false;
                for(int j =2; j < i; j++)
                {
                    if (i % j == 0 && i > 3)
                        check = true;
                }
                if (!check)
                {
                    Console.Write(i + "\t");
                }
                i++;
                //Thread.Sleep(500);
            }
        }
    }
    class OptimizedPrimeFactorization
    {
        public void Run()
        {
            int i = 2;
            while (true)
            {
                bool check = false;
                for (int j = 2; j < Math.Sqrt(i)+1; j++)
                {
                    if (i % j == 0 && i > 3)
                    { 
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    Console.Write(i + "\t");
                }
                i++;
                //Thread.Sleep(500);
            }
        }
    }
}
