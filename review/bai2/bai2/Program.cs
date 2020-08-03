using System;

namespace bai2
{
    class Program
    {
        public static int m = 0;
        public static int n = 0;
        public static int k = 0;
        public static int[,] matrixA = new int [0,0];
        public static int[,] matrixB = new int[0, 0];
        static void Main(string[] args)
        {
            //int[,] matrix = creatMatrix();
            Show(creatMatrix());
            Show(MultipleMaxtrix());

        }
        public static int[,] creatMatrix()
        {
            Console.Write("Enter rows n = ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter colums m = ");
            m = Int32.Parse(Console.ReadLine());
            matrixA = new int[n, m];
            Random rdd = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j =0; j < m; j++)
                {
                    matrixA[i, j] = rdd.Next(10, 50);
                    //Console.WriteLine(matrixA[i, j] + "\t");
                }
                //Console.WriteLine();
            }

            return matrixA;
        }
        public static int[,] MultipleMaxtrix()
        {
            Console.Write("Enter k = ");
            k = Int32.Parse(Console.ReadLine());
            matrixB = new int[m, k];
            Random rdd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    matrixB[i, j] = rdd.Next(10, 50);
                    Console.Write(matrixB[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] matrix = new int[n, k];
            for(int i =0;i < n; i++)
            {
                for(int j = 0; j < k; j++)
                {
                    for(int ii = 0;ii < m; ii++)
                    {
                        matrix[i, j] += matrixA[i, ii] * matrixB[ii, j]; 
                    }
                    //Console.WriteLine(matrix[i, j] + "\t");
                }
                //Console.WriteLine();
            }
            return matrix;
        }
        public static void Show(int[,] matrix)
        {
            for(int i =0; i< matrix.GetLength(0); i++)
            {
                for(int j = 0; j <matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}
