using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = characters[6];
            }
            //catch(ArgumentOutOfRangeException e)
            //{
            //    System.Console.WriteLine(e.Message);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    System.Console.WriteLine(ex.Message);
            //}
            catch (Exception e)
            {
                System.Console.WriteLine($"{e.GetType().Name},{e.Message}" );
            }
        }
    }
}
