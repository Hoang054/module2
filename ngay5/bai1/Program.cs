using System;

namespace bai1
{
    class QuadraticEquation
    {
        private double a { get; set; }
        private double b;
        private double c;
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetA()
        {
            return this.a;
        }
        public double GetB()
        {
            return this.b;
        }
        public double GetC()
        {
            return this.c;
        }
        public void SetA(double a)
        {
            this.a = a;
        }
        public void SetB(double a)
        {
            this.b = a;
        }
        public void SetC(double a)
        {
            this.c = a;
        }
        public double GetDiscriminant()
        {
            double delta = b * b - 4 * a * c;
            return delta;
        }
        public double GetRoot1()
        {
            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            return x1;
        }
        public double GetRoot2()
        {
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            return x2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a of Equation");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b of Equation");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c of Equation");
            double c = double.Parse(Console.ReadLine());
            QuadraticEquation equation = new QuadraticEquation(a, b, c);
            equation.SetA(1);
            Console.WriteLine($"pt : {a}x^2 + {b}x + c = 0 ");
            if (equation.GetDiscriminant() > 0)
            {
                Console.WriteLine($"equation has 2 solutions: {equation.GetRoot1()}, {equation.GetRoot2()}");
            }
            else if (equation.GetDiscriminant() == 0)
            {
                Console.WriteLine($"equation has a double solutions: {equation.GetRoot1()}");
            }
            else
            {
                Console.WriteLine("equation has no solutions");
            }
        }
    }
}
