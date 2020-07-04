using System;
namespace ngay2
{
    class bai6
    {
        static void Main()
        {
            int [][] a = new int [4][];
            Random rd = new Random();
            for(int i=0;i<4;i++){
                int[] arr = new int[4];
                for(int j=0;j<4;j++){
                    arr[j]= rd.Next(1,100);
                }
                a[i] = arr;
            }
            foreach(int [] element in a){
                foreach(int tam in element){
                    Console.Write(tam + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter column you want calculate");
            int col = Int32.Parse(Console.ReadLine())-1;
            int sum =0;
            for(int index=0;index<4;index++){
                sum +=a[index][col];
            }
            Console.WriteLine("Result : " + sum);
        }
    }
}