using System;
namespace ngay2
{
    class thuchanh5
    {
        static void Main()
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 30)
                    Console.WriteLine("Size should not exceed 30");

            } while (size > 30);
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter a mark for student " + (i + 1) + ": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            int count = 0;
            Console.WriteLine("List of mark: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + "\t");
                if (array[j] >= 5 && array[j] <= 10)
                    count++;
            }
            Console.Write("\n The number of students passing the exam is " + count);
        }
    }
}