using System;
using System.IO;

namespace additionalcerise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter colmums : ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter rows : ");
            int m = Int32.Parse(Console.ReadLine());
            int[,] array = new int[m, n];
            Random rdd = new Random();
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    array[i, j] = rdd.Next(10, 70);
                }
            }
            using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\additionalcerise2\data.txt"))
            {
                sw.WriteLine($"Colums = {n}, Rows = {m}");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int[] arrayfake = new int[array.GetLength(1)];
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        arrayfake[j] = array[i, j];
                    }
                    var data1 = string.Join(' ', arrayfake);
                    sw.WriteLine(data1);
                }
            }
            using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\additionalcerise2\out.txt"))
            {
                int count = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] %2 == 0)
                            count++;
                    }
                }
                sw.Write("even number : ");
                sw.WriteLine(count);
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int[] arrayfake = new int[array.GetLength(1)];
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] % 5 == 0)
                            arrayfake[j] = array[i, j];
                        else
                            arrayfake[j] = 00;
                    }
                    var data1 = string.Join(' ', arrayfake);
                    sw.WriteLine(data1);
                }
            }
        }
    }
}
