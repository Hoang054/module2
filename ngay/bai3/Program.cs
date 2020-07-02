using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so tien USD");
            double USD= double.Parse(Console.ReadLine());
            double VND = 23000 * USD;
            Console.WriteLine("{0} USD chuyen qua VND la: {1} VND",USD, VND);
        }
    }
}
