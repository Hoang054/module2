using System;

namespace baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 2, 4, 7, 10, 11, 45, 50, 59, 60, 66, 69, 70, 79 };
            Console.WriteLine(BinarySearch(list, 2, 0 , 12));       /* 0 */
            Console.WriteLine(BinarySearch(list, 11, 0, 12));     /* 4 */
            Console.WriteLine(BinarySearch(list, 79, 0, 12));     /*12 */
            Console.WriteLine(BinarySearch(list, 1, 0, 12));       /*-1 */
            Console.WriteLine(BinarySearch(list, 5, 0, 12));       /*-1 */
            Console.WriteLine(BinarySearch(list, 80, 0, 12));
        }
        static long BinarySearch(int[] list, int x, int l, int r)
        {
            int m = l / 2 + r / 2;
            //if (x > list[r] || x < list[l])
            //    return -1;
            if (list[m] == x)
                return m;
            else if (l >= r)
                return -1;
            else if (x < list[m])
            {
               return BinarySearch(list, x, l, m - 1);
            }
            else
               return BinarySearch(list, x, m + 1, r);
        }

    }
}
