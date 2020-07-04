using System;
namespace ngay2
{
    class bai3
    {
        static void Main()
        {
            Console.WriteLine("Enter the rows number :");
            int row = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column number :");
            int col = Int32.Parse(Console.ReadLine());
            int [,] a = new int [row,col];
            for(int i=0; i<row;i++){
                for(int j=0;j<col;j++){
            Console.WriteLine("Enter the number for a[{0},{1}]",i,j);
            a[i,j]= Int32.Parse(Console.ReadLine());
            }
            }
            Console.WriteLine("Your array:");
            for(int i=0; i<row;i++){
                for(int j=0;j<col;j++){
                    Console.Write(a[i,j] + "\t");
            }
            Console.WriteLine();
            }
            Methon(a);
        }
        public static void Methon(int [,] a)
        {
            int max = a[0,0];
            for(int i =0;i<a.GetLength(0);i++){
                for(int j =0;j<a.GetLength(1);j++){
                    if(a[i,j]>max){
                        max = a[i,j];
                    }
                }
            }
            Console.WriteLine("The largest element in array a is "+max);
        }
    }
}