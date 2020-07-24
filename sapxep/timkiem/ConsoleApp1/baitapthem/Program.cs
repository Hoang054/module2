using System;

namespace baitapthem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { } ;
            string choice = "";
            while (choice != "5")
            {
                Console.WriteLine("1. Creat Array");
                Console.WriteLine("2. Check symmetrical array");
                Console.WriteLine("3. Sort");
                Console.WriteLine("4. Find Array");
                Console.WriteLine("5. Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        array = creatarray();
                        Show(array);
                        break;
                    case "2":
                        Console.WriteLine(IsSymmetricalArray(array));
                        break;
                    case "3":
                        SelectionSort(array);
                        break;
                    case "4":
                        Find(array);
                        break;
                }
            }
        }
        static int[] creatarray()
        {
            Console.Write("Enter length of array n = ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rdd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rdd.Next(30, 60);
            }
            return arr;
        }
        static string IsSymmetricalArray(int[] arr)
        {
            bool check = true;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                    check = false;
            }
            if (check == true)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int idx = i;
                //int min = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[idx])
                    {
                        idx = j;
                    }
                }
                int temp = arr[idx];
                arr[idx] = arr[i];
                arr[i] = temp;
            }
            foreach (int item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        static string BinarySearch(int[] arr, int x, int l, int r)
        {
            int m = l / 2 + r / 2;
            string result = "";
            if (arr[m] == x)
            {
                int n = m;
                result += m;
                bool checkLeft = false;
                bool checkRight = false;
                int i = 1;
                while (true)
                {
                    if ((m - i) >= 0 && (m - i) <= arr.Length - 1)
                    {
                        if (arr[m-i] == arr[m])
                        {
                            result += "**" + (m-i);

                        }
                        else
                        {
                            checkLeft = true;
                        }

                    }
                    else
                    {
                        checkLeft = true;
                    }
                    if ((m + i) >= 0 && (m + i) <= arr.Length - 1)
                    {
                        if (arr[m+i] == arr[m])
                        {
                            result += "**" + (m+i);

                        }
                        else
                        {
                            checkRight = true;
                        }
                    }
                    else
                    {
                        checkRight = true;
                    }
                    if (checkLeft && checkRight)
                    {
                        break;
                    }
                    i++;
                }
                }
            else if (l >= r)
                result = "no find or not sort yet";
            else if (x < arr[m])
            {
                return BinarySearch(arr, x, l, m - 1);
            }
            else
                return BinarySearch(arr, x, m + 1, r);
            return result;
        }
        static void Find(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                Console.WriteLine("Array not length");
            else
            {
                Console.Write("Enter number to find : ");
                int x = Int32.Parse(Console.ReadLine());
                Console.WriteLine(BinarySearch(arr, x, 0, arr.Length - 1));
            }
        }
        static void Show(int [] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}
