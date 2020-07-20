using System;

namespace baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a string :");
            //string tam = Console.ReadLine();
            //Console.WriteLine(sort(tam));
            Console.WriteLine(sort("abcabcde"));
        }
        static string sort(string str)
        {
            int count = 1;
            string tam = "";
            int max = 0;
            int vitri = 0;
            string rerult = "";
            //int[] frequentChar = new int[255];
            int i = 0;
            while (vitri  < str.Length - 2)
            {
                for (i = vitri; i < str.Length - 1; i++)
                {
                    int ascii = (int)str[i];
                    int ascii2 = (int)str[i + 1];
                    if (ascii < ascii2)
                    {
                        if (rerult == "")
                            rerult += str[i];
                        rerult += str[i + 1];
                        count++;
                        tam = rerult;
                    }
                    else
                    {
                        if (max < count) 
                        {
                            tam = rerult;
                            max = count;
                        }
                        rerult = "";
                    break;
                    }
                }
                vitri = i + 1;
                count = 1;
            }
            return tam;
        }
    }
}
