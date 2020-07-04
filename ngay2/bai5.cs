using System;
namespace ngay2
{
    class bai5
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of array");
            int Length = Int32.Parse(Console.ReadLine());
            int[] a = new int [Length];
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("Enter the element a[{0}]",i);
                a[i]= Int32.Parse(Console.ReadLine());
            }
            int min = a[0];
            foreach( int tam in a)
            {
                if(tam<min){
                    min = tam;
                }
            }
            Console.WriteLine("Element smallest in the array is "+ min);
        }
    }
}