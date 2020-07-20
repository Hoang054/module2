using System;

namespace thuchanh2
{
    class Program
    {
            static int[] list = { 2, 4, 7, 10, 11, 45, 50, 59, 60, 66, 69, 70, 79 };
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(list, 2));       /* 0 */
            Console.WriteLine(BinarySearch(list, 11));     /* 4 */
            Console.WriteLine(BinarySearch(list, 79));     /*12 */
            Console.WriteLine(BinarySearch(list, 1));       /*-1 */
            Console.WriteLine(BinarySearch(list, 5));       /*-1 */
            Console.WriteLine(BinarySearch(list, 80));     /*-1 */
        }
        static int BinarySearch(int[] list, int key)
        {
            int low = 0;
            int high = list.Length - 1;
            if (key > list[high] || key < list[0])
                return -1;
            while (high >= low)
            {
                int mid = (low + high) / 2;
                if (key < list[mid])
                    high = mid - 1;
                else if (key == list[mid])
                    return mid;
                else
                    low = mid + 1;
            }
            return -1; /* Now high < low, key not found */
        }

    }
}
