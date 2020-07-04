using System;
namespace ngay2
{
    class bai7
    {
        static void Main()
        {
            string s ="abcdef ghk";
            Console.Write("Enter 1 character :");
            char cha = char.Parse(Console.ReadLine());
            int count =0;
            for(int i =0;i<s.Length;i++){
                if(s[i]==cha){
                    Console.WriteLine("Position "+ i);
                    count++;
                }
            }
            Console.WriteLine("" + count);
        }
    }
}