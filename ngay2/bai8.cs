using System;
namespace ngay2
{
    class bai8
    {
        static void Main()
        {
            int [,] a = new int [5,5];
            Random rd = new Random();
            for(int i =0; i< 5; i++){
                for(int j=0; j<5; j++){
                    a[i,j]= rd.Next(1,100);
                }
            }
            for(int i =0; i< 5; i++){
                for(int j=0; j<5; j++){
                    Console.Write(a[i,j]+ "  ");
                }
                Console.WriteLine();
            }
            int sumdiago1 = 0;
            int sumdiago2 = 0;
            for(int i=0; i<5 ;i++){
                sumdiago1 += a[i,i];
                sumdiago2 += a[i,4-i];
            }
            Console.WriteLine("total diagonal1 : " +sumdiago1);
            Console.WriteLine("total diagonal2 : " +sumdiago2);

        }
    }
}