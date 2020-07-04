using System;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("1. ve hinh chu nhat");
            // Console.WriteLine("2. ve tam giac vuong");
            // Console.WriteLine("3. ve tam giac can");
            // Console.WriteLine("4. exit");
            // Console.WriteLine("lua chon hinh ban muon ve");
            // int so = Int32.Parse(Console.ReadLine());

            // if (so == 1)
            // {
            //     Console.WriteLine("Nhap chieu cao");
            //     int chieuCao = Int32.Parse(Console.ReadLine());
            //     Console.WriteLine("Nhap chieu rong");
            //     int chieuRong = Int32.Parse(Console.ReadLine());
            //     for (int i = 1; i <= chieuCao; i++)
            //     {
            //         for (int j = 1; j <= chieuRong; j++)
            //         {
            //             Console.Write("* ");
            //         }
            //         Console.WriteLine();
            //     }
            // }
            // if (so == 2)
            // {
            //     Console.WriteLine("Nhap chieu cao");
            //     int chieuCao = Int32.Parse(Console.ReadLine());
            //     for (int i = 1; i <= chieuCao; i++)
            //     {
            //         for (int j = 1; j <= i; j++)
            //         {
            //             Console.Write("* ");
            //         }
            //         Console.WriteLine();
            //     }
            // }
            // if (so == 3)
            // {
            //     Console.WriteLine("Nhap chieu cao");
            //     int chieuCao = Int32.Parse(Console.ReadLine());
            //     for (int i = 1; i <= chieuCao; i++)
            //     {
            //         for (int j = chieuCao; j >= i; j--)
            //         {
            //             Console.Write(" ");
            //         }
            //         for (int k = 1; k <= i; k++)
            //         {
            //             Console.Write("́*");
            //         }
            //         Console.WriteLine();
            //     }
            // }
            // else
            // {
            //     Environment.Exit(4);
            // }


            int a = 100;
            GetValue(a);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        static void GetValue(ref int x)
        {
            int temp = 5;
            x  = temp;
        }
    }
}
