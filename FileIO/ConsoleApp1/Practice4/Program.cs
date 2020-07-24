using System;
using System.IO;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\Practice4\input.csv";
            int[] array = new int[0];
            using (StreamReader sr = File.OpenText(path))
            {
                var line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    
                    for (int i = 0; i < data.Length; i++)
                    {
                        Console.WriteLine(data[i]);
                    }
                }
            }
        }
    }
}
