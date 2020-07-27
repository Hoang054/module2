using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace additional_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var listtable = new List<object>(20);
            var Root = new Root()
            {
                Table = new List<table>(20)
            };
            //for(int i = 0; i < 20; i++)
            //{
            //    Root.Table[i].name = $"{i}";
            //    Root.Table[i].Status = true;
            //}
            var selectc = new List<int>();
            while (true)
            {
                Console.WriteLine("1. Add table :");
                Console.WriteLine("2. Pay :");
                string chon = Console.ReadLine();
                if (chon == "1")
                {
                    selectc = new List<int>();
                    var newtable = new table();
                    Console.WriteLine("Please enter number of table :");
                    var index = Int32.Parse(Console.ReadLine());

                    bool check = true;
                    foreach (var item in Root.Table)
                    {
                        if (item.name == $"{index}")
                        {
                            item.Status = false;
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        var doituong = new table();
                        doituong.name = $"{index}";
                        doituong.Status = true;
                        Root.Table.Add(doituong);
                    }
                    int i = 0;
                    int posision = 0;
                    for (i = 0; i < Root.Table.Count; i++)
                    {
                        if ($"{index}" == Root.Table[i].name)
                        {
                            posision = i;
                            break;
                        }
                    }

                    while (Root.Table[posision].Status)
                    {
                        Root.Table[posision].selects = new select();
                        Console.WriteLine("1. cola:");
                        Console.WriteLine("2. pepsi");
                        Console.WriteLine("3. coffe");
                        Console.WriteLine("4. water");
                        Console.WriteLine("5. beer");
                        Console.WriteLine("6. Exit");
                        Console.Write("select drink:");

                        int tam = Int32.Parse(Console.ReadLine());
                        if (tam == 6)
                            break;
                        if (tam > 0 && tam < 6)
                        {
                            selectc.Add(tam);

                        }
                    }
                    while (!Root.Table[posision].Status)
                    {
                        Console.WriteLine("Table has been choose");
                        Console.WriteLine("1. add  order ");
                        Console.WriteLine("2. exit");
                        string tam3 = Console.ReadLine();
                        int tam2 = 0;
                        if (tam3 == "1")
                        {
                            while (tam2 != 6)
                            {
                                Console.WriteLine("1. cola:");
                                Console.WriteLine("2. pepsi");
                                Console.WriteLine("3. coffe");
                                Console.WriteLine("4. water");
                                Console.WriteLine("5. beer");
                                Console.WriteLine("6. Exit");
                                Console.Write("select drink:");
                                tam2 = Int32.Parse(Console.ReadLine());
                                selectc.Add(tam2);
                            }
                            //Root = new Root()
                            //{
                            //    Table = new List<table>()
                            //}
                        }
                        else if (tam3 == "2")
                            break;
                    }
                    //Root.Table[posision].selects
                    //select aa = new select();
                    foreach (var item in selectc)
                    {
                        if (item == 1)
                        {
                            Root.Table[posision].selects.Pricecoca++;
                        }
                        else if (item == 2)
                            Root.Table[posision].selects.Pricepepsi++;
                        else if (item == 3)
                            Root.Table[posision].selects.Pricecoffe++;
                        else if (item == 4)
                            Root.Table[posision].selects.Pricewater++;
                        else if (item == 5)
                            Root.Table[posision].selects.Pricebeer++;
                    }

                    //Root.Table.Add(new table()
                    //{
                    //    name = newtable.name,
                    //    selects = aa1,
                    //    Status = false
                    //});

                    Root.Table[posision].Status = false;

                    using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\additional_2.3\order.json"))
                    {
                        var data = JsonConvert.SerializeObject(Root);
                        sw.Write(data);
                    }
                }
                else if(chon == "2")
                {
                    Console.WriteLine("Please enter number of table :");
                    var index = Int32.Parse(Console.ReadLine());
                    int i;
                    int posision = -1 ;
                    for (i = 0; i < Root.Table.Count; i++)
                    {
                        if ($"{index}" == Root.Table[i].name)
                        {
                            posision = i;
                            break;
                        }
                    }
                    if(posision == -1)
                    {
                        Console.WriteLine("Invalid table.");
                    }
                    else
                    {
                        var Root2 = new Root2()
                        {
                            Table = new List<table1>(20)
                        };
                        foreach (var std in Root.Table)
                        {
                            Root2.Table.Add(new table1()
                            {
                                name = std.name,
                                selects = std.selects,
                                tinhtien = std.selects.tinhtien(),
                                giotinhtien = new DateTime()
                            });
                        }
                        Console.WriteLine("complete pay.");
                        using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\additional_2.3\Bill.json"))
                        {
                            var data = JsonConvert.SerializeObject(Root2);
                            sw.Write(data);
                        }
                        Root.Table.RemoveAt(posision);
                    }
                }
            }
        }
        
    }
    class Root
    {
        public List<menu> Menu { get; set; }
        public List<table> Table { get; set; }
    }
    class menu
    {
        public string name;
        public int price;
    }
    class table
    {
        public string name { get; set; }
        public select selects { get; set; }
        public bool Status { get => status; set => status = value; }

        private bool status = true;
    }
    public class select
    {
        private int pricecoca = 0;
        private int pricepepsi = 0;
        private int pricecoffe = 0;
        private int pricewater = 0;
        private int pricebeer = 0;

        public int Pricecoca { get => pricecoca; set => pricecoca = value; }
        public int Pricepepsi { get => pricepepsi; set => pricepepsi = value; }
        public int Pricecoffe { get => pricecoffe; set => pricecoffe = value; }
        public int Pricewater { get => pricewater; set => pricewater = value; }
        public int Pricebeer { get => pricebeer; set => pricebeer = value; }
        public double tinhtien()
        {
            double sum = pricebeer * 30000 + pricecoffe * 15000 + pricecoca * 10000 + pricepepsi * 10000 + pricewater * 5000;
            return sum;
        }
    }
    class Root2
    {

        public List<table1> Table { get; set; }
    }
    class table1
    {
        public string name { get; set; }
        
        public select selects { get; set; }
        public double tinhtien { get; set; }
        public DateTime giotinhtien { get; set; }
    }

}
