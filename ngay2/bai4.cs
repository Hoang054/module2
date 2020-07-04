using System;
namespace ngay2
{
    class bai4
    {
        static void Main()
        {
            int [,] a = new int [3,3];
            int [,] b = new int [2,3];
            Enter(a,"a");
            Enter(b,"b");
            int [,] c = new int [a.GetLength(0)+b.GetLength(0),3];
            for(int i=0; i<c.GetLength(0);i++){
                if(i<a.GetLength(0)){
                for(int j=0; j<a.GetLength(1);j++){
                    c[i,j]= a[i,j];
                }}
                else{
                    for(int j=0; j<b.GetLength(1);j++){
                    c[i,j]= b[i-3,j];
                }
                }
            }
            for(int index1=0;index1<c.GetLength(0);index1++){
                for(int index=0;index<c.GetLength(1);index++){
                    Console.Write(c[index1,index] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void Enter(int [,] a,string ten){
            for(int i=0;i<a.GetLength(0);i++){
                for (int j=0;j<a.GetLength(1);j++){
                    Console.WriteLine("Enter element arr {0}[{1},{2}]",ten,i,j);
                    a[i,j]= Int32.Parse(Console.ReadLine());
                }
            }
        }
    }
}