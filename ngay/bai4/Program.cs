using System;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap bao nhieu so nguyen to hien thi :");
            int so = Int32.Parse(Console.ReadLine());
            int dem =1;
            for(int i=2; dem<so;i++){
                if(i==2){
                    Console.WriteLine(i);
                }
                for(int j=2;j<i ;j++){
                    if(i%j==0){
                        break;
                    }else if(j==i-1){
                        Console.WriteLine(i);
                        dem++;
                    }
                }
            }
        }
    }
}
