using System;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 3000;
            int number2 = 0;
            try
            {
                int result = number1 / number2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
