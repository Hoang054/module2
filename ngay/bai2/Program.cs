using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doc so");
            Console.WriteLine("Nhap so can doc");
            int so = Int32.Parse(Console.ReadLine());
            string chuyen;
            string chuyen1;
            int tam =so;
            double tam2=-1;
            if(so>10 && so<20){
                tam -=10;
            }
            if(so>=20){
                tam2 = so/10;
                tam2 = Math.Round(tam2,1);
                tam = so%10;
            }

            switch(tam){
                case 0:
                chuyen ="khong";
                break;
                case 1:
                chuyen ="Mot";
                break;
                case 2:
                chuyen ="Hai";
                break;
                case 3:
                chuyen ="Ba";
                break;
                case 4:
                chuyen ="Bon";
                break;
                case 5:
                chuyen ="Nam";
                break;
                case 6:
                chuyen ="Sau";
                break;
                case 7:
                chuyen ="Bay";
                break;
                case 8:
                chuyen ="Tam";
                break;
                case 9:
                chuyen ="Chin";
                break;
                case 10:
                chuyen ="Muoi";
                break;
                default:
                chuyen="";
                break;
            }
            switch( tam2 ){
                case 0:
                chuyen1 ="khong";
                break;
                case 1:
                chuyen1 ="Mot";
                break;
                case 2:
                chuyen1 ="Hai";
                break;
                case 3:
                chuyen1 ="Ba";
                break;
                case 4:
                chuyen1 ="Bon";
                break;
                case 5:
                chuyen1 ="Nam";
                break;
                case 6:
                chuyen1 ="Sau";
                break;
                case 7:
                chuyen1 ="Bay";
                break;
                case 8:
                chuyen1 ="Tam";
                break;
                case 9:
                chuyen1 ="Chin";
                break;
                case 10:
                chuyen1 ="Muoi";
                break;
                default:
                chuyen1="";
                break;
            }
            if(so<=10 && so>=0){
            Console.WriteLine("so {0} chuyen thanh chu la {1}", so, chuyen);}
            if(so<20 && so>10){
                Console.WriteLine("so {0} chuyen thanh chu la Muoi {1}",so, chuyen);
            }
            else{
                Console.WriteLine("so {0} chuyen thanh chu la {1} muoi {2}",so, chuyen1, chuyen);
            }
        }
    }
}
