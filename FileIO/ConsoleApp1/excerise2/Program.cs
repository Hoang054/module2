using System;
using System.Collections.Generic;
using System.IO;

namespace exercise2
{
    class Program
    {
        public static List<product> newlist = new List<product>();
        public static int ID = 10000;
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("1. Add : ");
                Console.WriteLine("2. Show : ");
                Console.WriteLine("3. Find : ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Show();
                        break;
                    case 3:
                        Find();
                        break;
                }
            }
        }
        public static void Add()
        {
            Console.WriteLine("Name product : ");
            string name = Console.ReadLine();
            Console.WriteLine("Manu : ");
            string manu = Console.ReadLine();
            Console.WriteLine("Price : ");
            Double price = (double.Parse(Console.ReadLine()));
            Console.WriteLine("Other description : ");
            string other = Console.ReadLine();
            product newproduct = new product();
            ID++;
            newproduct.id = ID;
            newproduct.Name = name;
            newproduct.Manu = manu;
            newproduct.Other = other;
            newproduct.Price = price;
            newlist.Add(newproduct);
        }
        public static void Show()
        {
            for(int i =0; i<newlist.Count;i++)
            {
                newlist[i].ToString();
            }
        }
        public static void Find()
        {
            Console.Write("Enter name need to find :");
            string name = Console.ReadLine();
            bool tam = false;
            for (int i = 0; i < newlist.Count; i++)
            {
                if (newlist[i].Name == name)
                {
                    using (StreamWriter sr = File.AppendText($@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\excerise2\Product.txt"))
                    {
                        sr.WriteLine("****Product found : ");
                    }
                        newlist[i].ToString();
                    tam = true;
                }
            }
                if (tam == true)
                {
                    Console.WriteLine("has find");
                }
                else
                    Console.WriteLine("not find");
        }
    }
    class product
    {
        public int id ;
        private string name;
        private string manu;
        private double price;
        private string other;

        //public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Manu { get => manu; set => manu = value; }
        public double Price { get => price; set => price = value; }
        public string Other { get => other; set => other = value; }
        public product() { }
        public product(string Name, string Manu, double Price, String Other) 
        {
            this.Name = Name;
            this.Manu = Manu;
            this.Price = Price;
            this.Other = Other;
        }
        public override string ToString()
        {
            using (StreamWriter sr = File.AppendText($@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\excerise2\Product.txt"))
            {
                sr.WriteLine($"id : {id}");
                sr.WriteLine($"Name: {Name}");
                sr.WriteLine($"Manu: {Manu}");
                sr.WriteLine($"Price: {Price}");
                sr.WriteLine($"Other: {Other}");
            }
            return "";
        }
    }
}
