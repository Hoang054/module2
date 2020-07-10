using System;

namespace ngay5
{
    class bai1
    {

    }
    class QuadraticEquation
    {
        private double a {get;set;}
        private double b {get;set;}
        private double c {get;set;}
        public QuadraticEquation(double a, double b, double c){
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetDiscriminant(){
            double delta = b*b - 4*a*c;
            return delta;
        }
        public double GetRoot1(){
            double x1 = (-b + Math.Sqrt(b*b - 4*a*c))/(2*a);
            return x1;
        }
        public double GetRoot2(){
            double x2 = (-b - Math.Sqrt(b*b - 4*a*c))/(2*a);
            return x2;
        }

    }
    class Program1
    {
        public static void Main()
        {
            Console.WriteLine("Enter a of Equation");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b of Equation");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c of Equation");
            double c = double.Parse(Console.ReadLine());
            QuadraticEquation equation = new QuadraticEquation(a,b,c);
            Console.WriteLine(equation.GetDiscriminant());
        }
    }
}