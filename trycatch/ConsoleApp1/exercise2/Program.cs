using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 99999;
            int number2 = 9999999;
            checked
            {
                try
                {
                    int result = number1 * number2;
                    Console.WriteLine(result);
                }
                catch (OverflowException)
                {
                    double result = (double)number1 * (double)number2;
                    //System.Console.WriteLine(e.Message);
                    Console.WriteLine("Exception: {0} > {1:E}.",
                     result, Int32.MaxValue);
                }
            }
        }
    }
}
