using System;
namespace ngay2
{
    class bai2
    {
        static void Main()
        {
            int[] a = { 1, 4, 6, 3, 5 };
            Console.WriteLine("Enter number X to delete");
            int b = Int32.Parse(Console.ReadLine());
            int [] arr = new int[a.Length-1];
            bool check = true;
            int index = 0;
            for(int i=0 ;i<a.Length;i++){
                if(a[i]==b){
                    check = false;
                    index =i;
                    break;
                }
            }
            if(check){
                Console.WriteLine("X not exist in a");
                for(int i =0; i<a.Length;i++){
                Console.Write(a[i] +"\t");
            }
            }else{
                for(int i=0; i<arr.Length;i++){
                    if(i<index){
                        arr[i]=a[i];
                    }
                    else if(i>=index){
                        arr[i]=a[i+1];
                    }
                }
            for(int i =0; i<arr.Length;i++){
                Console.Write(arr[i] +"\t");
            }
            }
        }
    }
}