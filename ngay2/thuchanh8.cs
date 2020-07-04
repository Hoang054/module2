using System;
namespace ngay2
{
    class thuchanh8
    {
        public static void Main(String[] args)
        {
            int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
            int index = minValue(arr);
            Console.WriteLine("The smallest element in the array is " + arr[index]+ " possition "+ index);
        }
        public static int minValue(int[] array)
        {

            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i +1;
                }
            }

            return index;
        }
        
    }
}