using System;

namespace baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 640, 4, 250, -12, 232, 11, -90 };
            InsertionSort(arr);
        }
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    for (int k = 0; k < arr.Length; k++)
                        Console.Write(arr[k] + " ");
                    Console.WriteLine();
                }
                arr[j + 1] = key;
                for (int k = 0; k < arr.Length; k++)
                    Console.Write(arr[k] + " ");
                Console.WriteLine();
            }
        }
    }
}
