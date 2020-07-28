using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace additional_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[10];
            var Root = new Root()
            {
                Bill = new List<bill>()
                //{
                //    Dachon = new List<dachon>()
                //}
            };
            while (true) {
                var listdachon = new List<dachon>();
                var list = new List<int>();
                Console.WriteLine("1. Menu or add ");
                Console.WriteLine("2. Xem gio hang");
                Console.WriteLine("3. Thanh Toan");
                Console.WriteLine("4. Chinh sua gio hang");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int themmon = 0;
                        while (themmon != 11)
                        {
                            Console.WriteLine("1. Uu Dai 1 _ 100k");
                            Console.WriteLine("2. Uu Dai 2 _ 120k");
                            Console.WriteLine("3. Uu Dai 3 _ 10k");
                            Console.WriteLine("4. Uu Dai 4 _ 45k");
                            Console.WriteLine("5. Uu Dai 5 _ 55k");
                            Console.WriteLine("6. Uu Dai 6 _ 65k");
                            Console.WriteLine("7. Uu Dai 7 _ 110k");
                            Console.WriteLine("8. Uu Dai 8 _ 90k");
                            Console.WriteLine("9. Uu Dai 9 _ 99k");
                            Console.WriteLine("10. Uu Dai 10 _ 199k");
                            Console.WriteLine("11. Exit");
                            themmon = Int32.Parse(Console.ReadLine());
                            if (themmon != 11)
                                list.Add(themmon);
                        }
                        for (int i = 0; i < list.Count; i++)
                        {
                            switch (list[i])
                            {
                                case 1:
                                    array[0]++;
                                    break;
                                case 2:
                                    array[1]++;
                                    break;
                                case 3:
                                    array[2]++;
                                    break;
                                case 4:
                                    array[3]++;
                                    break;
                                case 5:
                                    array[4]++;
                                    break;
                                case 6:
                                    array[5]++;
                                    break;
                                case 7:
                                    array[6]++;
                                    break;
                                case 8:
                                    array[7]++;
                                    break;
                                case 9:
                                    array[8]++;
                                    break;
                                case 10:
                                    array[9]++;
                                    break;
                            }
                        }
                        
                            break;
                    case 2:
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] != 0)
                            {
                                Console.WriteLine($"Uu Dai {i + 1} : {array[i]}");
                                if (i == 0)
                                    Console.WriteLine($"tinh gia: {array[i] * 100000}");
                                else if (i == 1)
                                    Console.WriteLine($"tinh gia: {array[i] * 120000}");
                                else if (i == 2)
                                    Console.WriteLine($"tinh gia: {array[i] * 10000}");
                                else if (i == 3)
                                    Console.WriteLine($"tinh gia: {array[i] * 45000}");
                                else if (i == 4)
                                    Console.WriteLine($"tinh gia: {array[i] * 55000}");
                                else if (i == 5)
                                    Console.WriteLine($"tinh gia: {array[i] * 65000}");
                                else if (i == 6)
                                    Console.WriteLine($"tinh gia: {array[i] * 11000}");
                                else if (i == 7)
                                    Console.WriteLine($"tinh gia: {array[i] * 90000}");
                                else if (i == 8)
                                    Console.WriteLine($"tinh gia: {array[i] * 99000}");
                                else if (i == 9)
                                    Console.WriteLine($"tinh gia: {array[i] * 199000}");
                            }
                        }
                        break;
                    case 3:
                        int count = 0;
                        var possition = new List<int>();
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] != 0)
                            {
                                switch (i+1)
                                {
                                    case 1:
                                        listdachon.Add(new dachon()
                                        {
                                            name = "uu dai 1",
                                            soluong = array[i],
                                            tamtinh =array[i]*100000
                                        });
                                        count++;
                                        possition.Add(i + 1);
                                        break;
                                    case 2:
                                        listdachon.Add(new dachon()
                                        {
                                            name = "uu dai 2",
                                            soluong = array[i],
                                            tamtinh = array[i] * 120000
                                        });
                                        count++;
                                        possition.Add(i + 1);
                                        break;
                                    case 3:
                                        listdachon.Add(new dachon()
                                        {
                                            name = "uu dai 3",
                                            soluong = array[i],
                                            tamtinh = array[i] * 100000
                                        });
                                        count++;
                                        possition.Add(i + 1);
                                        break;
                                    case 4:
                                        listdachon.Add(new dachon()
                                        {
                                            name = "uu dai 4",
                                            soluong = array[i],
                                            tamtinh = array[i] * 45000
                                        });
                                        count++;
                                        possition.Add(i + 1);
                                        break;
                                    case 5:
                                        listdachon.Add(new dachon()
                                        {
                                            name = "uu dai 5",
                                            soluong = array[i],
                                            tamtinh = array[i] * 550000
                                        });
                                        count++;
                                        possition.Add(i + 1);
                                        break;
                                    case 6:
                                        listdachon.Add(new dachon()
                                        {
                                            name = "uu dai 6",
                                            soluong = array[i],
                                            tamtinh = array[i] * 65000
                                        });
                                        count++;
                                        possition.Add(i + 1);
                                        break;
                                    case 7:
                                        listdachon.Add(new dachon()
                                        {
                                            name = "uu dai 7",
                                            soluong = array[i],
                                            tamtinh = array[i] * 110000
                                        });
                                        count++;
                                        possition.Add(i + 1);
                                        break;
                                    case 8:
                                        listdachon.Add(new dachon()
                                        {
                                            name = "uu dai 8",
                                            soluong = array[i],
                                            tamtinh = array[i] * 90000
                                        });
                                        count++;
                                        possition.Add(i + 1);
                                        break;
                                    case 9:
                                        listdachon.Add(new dachon()
                                        {
                                            name = "uu dai 9",
                                            soluong = array[i],
                                            tamtinh = array[i] * 99000
                                        });
                                        count++;
                                        possition.Add(i + 1);
                                        break;
                                    case 10:
                                        listdachon.Add(new dachon()
                                        {
                                            name = "uu dai 10",
                                            soluong = array[i],
                                            tamtinh = array[i] * 199000
                                        });
                                        count++;
                                        possition.Add(i + 1);
                                        break;
                                }
                            }
                        }
                        double tamtinh = 0;
                        for (int i = 0; i < count; i++)
                        {
                            tamtinh += listdachon[i].tamtinh;
                        }
                        Root.Bill.Add(new bill(){
                            tongtien = tamtinh,
                            Dachon = listdachon
                        });
                        Console.WriteLine("complete pay.");
                        using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\additional_3\Bill.json"))
                        {
                            var data = JsonConvert.SerializeObject(Root);
                            
                            //JObject obj = JObject.Parse(data);
                            //dynamic json = JsonConvert.DeserializeObject(data);
                            //int i = 0;
                            //foreach (var item in json)
                            //{
                                
                            //    item.Property("tongtien").Remove();
                                
                            //    i++;
                            //}
                            sw.Write(data);
                        }
                        array = new int[10];
                        
                        break;
                    case 4:
                        while (true)
                        {
                            for (int i = 0; i < array.Length; i++)
                            {
                                if (array[i] != 0)
                                {
                                    Console.WriteLine($"Uu Dai {i + 1} : {array[i]}");
                                    if (i == 0)
                                        Console.WriteLine($"tinh gia: {array[i] * 100000}");
                                    else if (i == 1)
                                        Console.WriteLine($"tinh gia: {array[i] * 120000}");
                                    else if (i == 2)
                                        Console.WriteLine($"tinh gia: {array[i] * 10000}");
                                    else if (i == 3)
                                        Console.WriteLine($"tinh gia: {array[i] * 45000}");
                                    else if (i == 4)
                                        Console.WriteLine($"tinh gia: {array[i] * 55000}");
                                    else if (i == 5)
                                        Console.WriteLine($"tinh gia: {array[i] * 65000}");
                                    else if (i == 6)
                                        Console.WriteLine($"tinh gia: {array[i] * 11000}");
                                    else if (i == 7)
                                        Console.WriteLine($"tinh gia: {array[i] * 90000}");
                                    else if (i == 8)
                                        Console.WriteLine($"tinh gia: {array[i] * 99000}");
                                    else if (i == 9)
                                        Console.WriteLine($"tinh gia: {array[i] * 199000}");
                                    Console.WriteLine($"{i + 1}. xoa hoac chinh sua uu dai{i + 1}");
                                }
                            }
                            Console.WriteLine("0. exit");
                            Console.Write("Chon de chinh sua : ");
                            int chon = Int32.Parse(Console.ReadLine());
                            if (chon == 0)
                                break;
                            int chon2 = 0;

                            try
                            {
                                for (int i = 0; i < array.Length; i++)
                                {
                                    if (array[chon - 1] != 0)
                                    {
                                        if ((chon - 1) == i)
                                        {
                                            Console.WriteLine("1. xoa");
                                            Console.WriteLine("2. chinh sua");
                                            Console.WriteLine("3. exit");
                                            chon2 = Int32.Parse(Console.ReadLine());
                                            if (chon2 == 1)
                                            {
                                                array[i] = 0;
                                                Console.WriteLine($"Uu Dai {i + 1}: da duoc xoa");
                                            }
                                            else if (chon2 == 2)
                                            {
                                                Console.WriteLine("Nhap so luong mua chinh sua(co the la gia tri am)");
                                                int chinhsua = int.Parse(Console.ReadLine());
                                                if ((chinhsua + array[i]) > 0)
                                                {
                                                    array[i] += chinhsua;
                                                    Console.WriteLine("da cap nhat");
                                                }
                                                else if ((chinhsua + array[i]) == 0)
                                                {
                                                    array[i] = 0;
                                                    Console.WriteLine("mat hang da duoc xoa");
                                                    break;
                                                }
                                                else
                                                    Console.WriteLine("so luong am vuot qua gioi hang");
                                            }
                                            else if (chon2 == 3)
                                            {
                                                break;
                                            }

                                        }
                                    }
                                    else if (array[chon - 1] == 0)
                                    {
                                        Console.WriteLine("----------");
                                        Console.WriteLine("@@@@@@@@khong ton tai trong gio, vui long nhap lai");
                                        Console.WriteLine("....................");
                                        break;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("co gi do sai, vui long nhap lai");
                            }
                                
                        }
                        break;
                }
            }
        }
    }
}
