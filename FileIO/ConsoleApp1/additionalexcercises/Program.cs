using System;
using System.Collections.Generic;
using System.IO;

namespace additionalexcercises
{
    class Program
    {
        public static int rows = 0;
        public static int colums = 0;
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            int[,] array = new int[4,5];
            using (StreamReader sr = File.OpenText($@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\additionalexcercises\InputData.txt"))
            {
                //Console.WriteLine(sr.ReadToEnd());
                var line = string.Empty;
                //int number = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    data.Add(line);
                    
                }
                string[] tt = data[0].Split(' ');
                rows = Int32.Parse(tt[0]);
                colums = Int32.Parse(tt[1]);
                array = new int[rows, colums];
                for (int i = 0; i < rows; i++)
                    {
                        string[] tam = data[i + 1].Split(' ');
                        for (int j = 0; j < colums; j++)
                        {
                            array[i, j] = Int32.Parse(tam[j]);
                        }
                    }
            }
            using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\additionalexcercises\OutputData.txt"))
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        //Console.Write(array[i, j]+"  ");
                        sum += array[i, j];
                    }
                    //Console.WriteLine();
                }
                int sum1 = 0;
                int sum2 = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (soNguyenTo(array[i, j]))
                            sum1 += array[i, j];
                    }
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        if (array[i, j] % 2 != 0)
                            sum2 += array[i, j];
                    }
                }
                int sum3 = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum3 += array[i, 0] + array[i, colums - 1];
                }
                for (int j = 0; j < colums; j++)
                {
                    sum3 += array[0, j] + array[rows - 1, j];
                }
                sum3 -= array[0, 0] - array[rows - 1, colums - 1] - array[0, colums - 1] - array[rows - 1, 0];
                sw.WriteLine($"Sum of matrix: {sum}");
                sw.WriteLine($"Sum of prime number: {sum1}");
                sw.WriteLine($"Sum of odd number: {sum2}");
                sw.WriteLine($"Sum of border: {sum3}");
                sw.WriteLine("matrix x3 :");
                for (int i = 0; i < rows; i++)
                {
                    int[] arrayfake = new int[colums];
                    for (int j = 0; j < colums; j++)
                    {
                        arrayfake[j] = array[i, j]*3;
                    }
                    var data1 = string.Join(' ', arrayfake);
                    sw.WriteLine(data1);
                }
            }
            static bool soNguyenTo(int a)
            {
                bool check = true;
                for(int i = 2; i < a; i++)
                {
                    if(a%i==0)
                        check = false;
                }
                return check;
            }
        }
    }
}
