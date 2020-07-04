using System;
namespace ngay2
{
    class bai1
    {
        static void Main()
        {
            int[] a = { 1, 4, 6, 3, 5 };
            Console.WriteLine("Enter positon to insert :");
            int index = Int32.Parse(Console.ReadLine());
            int[] arr = new int[a.Length + 1];
            Console.WriteLine("Enter number to insert :");
            int b = Int32.Parse(Console.ReadLine());
            if (index <= 0 || index > a.Length)
            {
                Console.WriteLine("Cannot insert element into array.");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < index)
                    {
                        arr[i] = a[i];
                    }
                    else if (i > index)
                    {
                        arr[i] = a[i - 1];
                    }
                    else
                    {
                        arr[index] = b;
                    }
                }
            for(int i =0; i<arr.Length;i++){
                Console.Write(arr[i] +"\t");
            }
            }
        }
    }
}