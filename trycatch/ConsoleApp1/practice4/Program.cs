using System;

namespace practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal price = 169.32m;
                Console.WriteLine("The cost is {0:C2}.", price);
            }
            catch (System.FormatException ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}
