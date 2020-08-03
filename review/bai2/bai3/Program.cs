using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace bai3
{
    class Program
    {
        public static List<staff> newuser = new List<staff>()
        {
            new staff()
            {
              name = "hoang",
               email = "admin",
               password = "admin"
            }
        };
        public static Database newdatabase = new Database()
        {
            InformationStaff = new info(),
            Order = new List<order>(),
            Info = new infocustom()
        };
        public static List<Database> newdatabases = new List<Database>()
        {
            newdatabase
        };
        public static bill newbill = new bill() {
            Info = new infocustom()
        };
        public static List<bill> newbills = new List<bill>() 
        {
            newbill
        };
        public static Root root = new Root()
        {
            databases = newdatabases,
        };
        public static Root2 root2 = new Root2()
        {
            staffs = newuser

        };
        public static Root3 root3 = new Root3()
        {
            bills = newbills
        };
        public static order newcommodity = new order() {
        };
        public static Root4 root4 = new Root4()
        {
            commodities = new List<commodity>()
            {
                newcommodity
            }
        };
        static void Main(string[] args)
        {
            readeracc();
            while (true)
            {
                Console.Write("Enter email: ");
                string name = Console.ReadLine();
                Console.Write("Enter password: ");
                string pass = Console.ReadLine();
                bool check = true;
                foreach (var user in root2.staffs) {
                    if (name == root2.staffs[0].email && pass == root2.staffs[0].password)
                    {
                        check = false;
                        Console.WriteLine("login success");
                        Console.WriteLine("welcom admin");
                        Console.WriteLine("-----------------------");
                        while (true)
                        {
                            Console.WriteLine("Enter something to continue :)");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("1. show list staff");
                            Console.WriteLine("2. save order to json database/ pay");
                            Console.WriteLine("3. more staff to json database");
                            Console.WriteLine("4. change password");
                            Console.WriteLine("5. Creat account");
                            Console.WriteLine("6. Creat order ");
                            Console.WriteLine("7. Show list order");
                            Console.WriteLine("8. Find by Id");
                            Console.WriteLine("9. Find by name, addres custom");
                            Console.WriteLine("10. change status");
                            Console.WriteLine("11. Update ");
                            Console.WriteLine("12. add commodity");
                            Console.WriteLine("13. delete staff");
                            Console.WriteLine("14. Edit");
                            Console.WriteLine("15. show commodities");
                            Console.WriteLine("0. Exit");
                            string choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "1":
                                    showliststaff();
                                    break;
                                case "2":
                                    pay(newdatabase);
                                    break;
                                case "3":
                                    save();
                                    break;
                                case "4":
                                    changepass(user);
                                    break;
                                case "5":
                                    Creatuser();
                                    break;
                                case "6":
                                    creatOrder();
                                    break;
                                case "7":
                                    ShowAll();
                                    break;
                                case "8":
                                    while (true) {
                                        Database data = FindByID();
                                        if (data == null)
                                            Console.WriteLine("not find");
                                        else
                                        {
                                            Show(data);
                                            break;
                                        }
                                    }
                                    break;
                                case "9":
                                    while (true)
                                    {
                                        List<Database> data = Findbyaddress();
                                        if (data == null)
                                            Console.WriteLine("not find");
                                        else{
                                            Show(data);
                                            break;
                                        };
                                    }
                                    break;
                                case "10":
                                    orderstatus();
                                    break;
                                case "11":
                                    Update();
                                    break;
                                case "12":
                                    addcommodity();
                                    break;
                                case "13":
                                    Deleteuser();
                                    break;
                                case "14":
                                    edit();
                                    break;
                                case "15":
                                    showcommodity();
                                    break;
                            }
                            if (choice == "0")
                                break;
                        }
                        break;
                    }
                    else if (name == user.email && pass == user.password && name != root2.staffs[0].email)
                    {
                        check = false;
                        Console.WriteLine("login success");
                        Console.WriteLine($"Welcome {user.name}");
                        Console.WriteLine("-----------------------");
                        while (true)
                        {
                            Console.WriteLine("Enter something to continue :)");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("3. more staff to json database");
                            Console.WriteLine("4. change password");
                            Console.WriteLine("6. Creat order ");
                            Console.WriteLine("7. Show list order");
                            Console.WriteLine("8. Find by Id");
                            Console.WriteLine("9. Find by name, addres custom");
                            Console.WriteLine("11. Update ");
                            Console.WriteLine("0. Exit");
                            string choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "2":
                                    pay(newdatabase);
                                    break;
                                case "3":
                                    save();
                                    break;
                                case "4":
                                    changepass(user);
                                    break;
                                
                                case "6":
                                    creatOrder();
                                    break;
                                case "7":
                                    ShowAll();
                                    break;
                                case "8":
                                    FindByID();
                                    break;
                                case "9":
                                    Findbyaddress();
                                    break;
                                case "11":
                                    Update();
                                    break;
                            }
                            if (choice == "0")
                                break;
                        }
                        break;
                    }
                }
                if(check)
                    Console.WriteLine("email or password not match");
                else
                    break;
            }
        }
        public static void showliststaff()
        {
            readeracc();
            foreach(var item in root2.staffs)
            {
                Console.WriteLine($"{item.name} \t {item.email} \t{item.password}");
            }
        }
        public static void save()
        {
            readeracc();
            Console.WriteLine("add more staff");
            Console.Write("Enter name staff : ");
            staff newstaff = new staff()
            { 
                name = Console.ReadLine()
            };
            root2.staffs.Add(newstaff);
            writeracc();
        }
        public static void changepass(staff user)
        {
            Console.Write("Enter new password :");
            user.password = Console.ReadLine();
            Console.WriteLine("changed pass success");
        }
        public static void Creatuser()
        {
            readeracc();
            var user = new staff();
            while (true)
            {
                Console.WriteLine("Enter name");
                user.name = Console.ReadLine();
                Console.WriteLine("new user :");
                user.email = Console.ReadLine();
                bool check = true;
                foreach (var item in root2.staffs)
                {
                    if (item.email == user.email)
                    {
                        Console.WriteLine("Email existed, try email other");
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine("Email was accept!");
                    break;
                }
            }
            Console.WriteLine("password :");
            user.password = Console.ReadLine();
            
                root2.staffs.Add(user);

            writeracc();
            Console.WriteLine("Compelete creat user");
        }
        public static void Deleteuser()
        {
            readeracc();
            var user = new staff();
            while (true)
            {
                Console.WriteLine("Enter name");
                user.name = Console.ReadLine();
                bool check = true;
                foreach (var item in root2.staffs)
                {
                    if (item.name == user.name && item.email !="admin")
                    {
                        root2.staffs.Remove(item);
                        check = false;
                        break;
                    }
                }
                if (!check)
                {
                    Console.WriteLine("Email was delete!");
                    break;
                }
                else
                    Console.WriteLine("staff not exits");
            }
            writeracc();
        }
        public static void creatOrder()
        {
            reader();
            readeracc();
            readercommodity();
            newdatabase.ID = root.databases[root.databases.Count - 1].ID + 1;
            int amount1 = 0;
            var neworder = new commodity();
            while (true)
            {
                neworder = Findcommodity();
                if (neworder == null) 
                {
                    Console.WriteLine("not find commodity");
                }
                else
                {
                    Console.WriteLine("Enter amount");
                    amount1 = Int32.Parse(Console.ReadLine());
                }
                newdatabase.Order.Add(new order()
                {
                    amount = amount1,
                    Idproduct = neworder.Idproduct,
                    nameproduct = neworder.nameproduct,
                    price = neworder.price
                });
                Console.WriteLine("1. add more");
                Console.WriteLine("2. exit");
                string choice = Console.ReadLine();
                if(choice == "2")
                    break;
            }
            foreach (var item in newdatabase.Order)
            {
                newdatabase.totalprice += item.Total;
            }
            string tam = "";
            while (true)
            {
                Console.WriteLine("Enter name Staff:");
                tam = Console.ReadLine();
                bool check = true;
                foreach (var item in root2.staffs)
                {
                    if (item.name == tam)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    Console.WriteLine("staff not exits");
                else
                    break;
            }
            newdatabase.InformationStaff.nameStaff = tam;

            Console.WriteLine("Enter info custom: ");
            Console.Write("name :");
            newdatabase.Info.name = Console.ReadLine();

            Console.Write("age :");
            newdatabase.Info.age = Convert.ToInt32(Console.ReadLine());

            Console.Write("numberphone :");
            newdatabase.Info.numberphone = Console.ReadLine();

            Console.Write("address : ");
            newdatabase.Info.address = Console.ReadLine();

            root.databases.Add(newdatabase);
            
            writer();
        }
        public static void Show(Database item)
        {
            Console.WriteLine(".........................");
            Console.Write("ID: ");
            Console.WriteLine(item.ID);
            Console.Write("infor staff : ");
            Console.WriteLine(item.InformationStaff.nameStaff);
            Console.Write("infor customer : ");
            Console.WriteLine(item.Info.name);
            Console.WriteLine(item.Info.age);
            Console.WriteLine(item.Info.numberphone);
            foreach (var ii in item.Order)
            {
                Console.WriteLine($"{ii.nameproduct} \t {ii.amount} \t {ii.price} \t {ii.Total} ");
            }
            Console.WriteLine(item.Orderstatus);
            Console.WriteLine(".........................");
        }
        public static void Show(List<Database> it)
        {
            foreach (var item in it)
            {
                Console.WriteLine(".........................");
                Console.Write("ID: ");
                Console.WriteLine(item.ID);
                Console.Write("infor staff : ");
                Console.WriteLine(item.InformationStaff.nameStaff);
                Console.Write("infor customer : ");
                Console.WriteLine(item.Info.name);
                Console.WriteLine(item.Info.age);
                Console.WriteLine(item.Info.numberphone);
                foreach (var ii in item.Order)
                {
                    Console.WriteLine($"{ii.nameproduct} \t {ii.amount} \t {ii.price} \t {ii.Total} ");
                }
                Console.WriteLine(item.Orderstatus);
            }
            Console.WriteLine(".........................");
        }
        public static void ShowAll()
        {
            foreach (var item in root.databases)
            {
                Show(item);
            }
        }
        public static Database FindByID()
        {
            reader();
            Console.WriteLine("Enter Orderid for search:");
            int id = Int32.Parse(Console.ReadLine());
            bool check = true;
            Database tam = null;
            foreach (var item in root.databases)
            {
                if(item.ID == id)
                {
                    check = false;
                    tam=item;
                }
            }
            if (check)
                return null;
            else
                return tam;
        }
        public static List<Database> Findbyaddress()
        {
            reader();
            Console.WriteLine("Enter address or name custom: ");
            string address = Console.ReadLine();
            bool check = true;
            List<Database> tam = new List<Database>()
            {
                new Database()
            };
            foreach (var item in root.databases)
            {
                if(item.Info.address == address|| item.Info.name == address)
                {
                    check = false;
                    if(tam[0].Info == null)
                    {
                        tam[0] = item;
                    }
                    else
                        tam.Add(item);
                }
            }
            if (check)
                return null;
            else
                return tam;
        }
        public static commodity Findcommodity()
        {
            var newcom = new commodity() {};
            readercommodity();
            Console.WriteLine("Enter id or name order ");
            string name = Console.ReadLine();
            if (name[0].Equals("1"))
            {
                foreach (var item in root4.commodities)
                {
                    string tam = Convert.ToString(item.Idproduct);
                    if (name == tam)
                    {
                        newcom = (item);
                        break;
                    }
                }
            }
            else
            {
                foreach (var item in root4.commodities)
                {
                    if (name == item.nameproduct)
                    {
                        newcom = (item);
                        break;
                    }
                }
            }
            return newcom;
        }
        public static List<commodity> Findcommodities()
        {
            var listcom = new List<commodity>()
            {   null
                //new commodity()
                //{

                //}
            };
            readercommodity();
            Console.WriteLine("Enter id or name order ");
            string name = Console.ReadLine();
            bool check = true;
            if (name[0].Equals("1"))
            {
                foreach (var item in root4.commodities)
                {
                    string tam = Convert.ToString(item.Idproduct);
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (name[i] != tam[i])
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        listcom.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in root4.commodities)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (name[i] != item.nameproduct[i])
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        listcom.Add(item);
                    }
                }
            }
            return listcom;
        }
        public static void orderstatus()
        {
            Database newdata = FindByID();
            Show(newdata);
            if (newdata != null && newdata.Orderstatus == "take order")
            {
                while (true)
                {
                    Console.WriteLine("Change status order");
                    string status = Console.ReadLine();
                    if (status == "paid" || status == "cancel")
                    {
                        newdata.Orderstatus = status;
                        break;
                    }
                    else
                        Console.WriteLine("status just transform to paid or cancel");
                }
                foreach(var item in root.databases)
                {
                    if (newdata.ID == item.ID)
                        item.Orderstatus = newdata.Orderstatus; 
                }
                writer();
                Console.WriteLine("compelete change status");
                Console.WriteLine("....................................");
            }
            else
                Console.WriteLine("Not find order or order been cancel, paid");
        }
        public static void Update()
        {
            Database newdata = FindByID();
            if (newdata != null && newdata.Orderstatus == "take order")
            {
                Show(newdata);
                Console.WriteLine("change info for staff :");
                string infoname = Console.ReadLine();
                if (infoname != "")
                {
                    newdata.InformationStaff.nameStaff = infoname;
                }
                Console.WriteLine("change order yes or no: ");
                order updateorder = new order();
                string yes = Console.ReadLine();
                if (yes == "yes")
                {
                    Console.WriteLine("change name staff :");
                    string nameproduct = Console.ReadLine();
                    if (nameproduct != "")
                    {
                        updateorder.nameproduct = nameproduct;
                    }
                    Console.WriteLine("change price");  
                    double newprice = double.Parse(Console.ReadLine());
                    if (newprice != 0.0)
                    {
                        updateorder.price = newprice;
                    }
                    Console.WriteLine("change amout");
                    int newamout = int.Parse(Console.ReadLine());
                    if (newamout != 0)
                    {
                        updateorder.amount = newamout;
                    }
                }
                else { }
                Console.WriteLine("Change info custom yes or no");
                string no = Console.ReadLine();
                if (no == "yes")
                {
                    Console.WriteLine("change name custom");
                    string infonamecus = Console.ReadLine();
                    if (infonamecus != "")
                    {
                        newdata.Info.name = infoname;
                    }
                    Console.WriteLine("chang age");
                    int newage = int.Parse(Console.ReadLine());
                    if (newage != 0)
                    {
                        newdata.Info.age = newage;
                    }
                    Console.WriteLine("change numberphone");
                    string newnumber = Console.ReadLine();
                    if (newnumber != "")
                    {
                        newdata.Info.numberphone = newnumber;
                    }
                    Console.WriteLine("change addres");
                    string newadd = Console.ReadLine();
                    if (newadd != "")
                    {
                        newdata.Info.address = newadd;
                    }
                }
            }
            else
                Console.WriteLine("Not find order or The order has been canceled or paid");
        }
        public static void pay(Database newdatabase1)
        {
            newdatabase1.Orderstatus = "paid";
            newbill = new bill()
            {
                ID = newdatabase1.ID,
                Info = newdatabase1.Info,
                InformationStaff = newdatabase1.InformationStaff,
                Order = newdatabase1.Order,
                Orderstatus = newdatabase1.Orderstatus,
                totalprice = newdatabase1.totalprice,
                datetimme = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
            };
            using (StreamWriter sw = File.CreateText($@"C:\Users\Hoang\Documents\module2\review\bai2\bai3\{DateTime.Now.ToString("ddMMyyy")}_{newdatabase1.ID}")) 
            {
                var data = JsonConvert.SerializeObject(newbill);
                sw.Write(data);
            }
            writer();
            Console.WriteLine("Compelete pay");
        }
        public static void edit()
        {
            Database data =  FindByID();
            if(data != null)
            {
                while (true)
                {
                    Console.WriteLine("Enter for turn commodity : name, price, amount ");
                    data.Order.Add(new order
                    {
                        nameproduct = Console.ReadLine(),
                        price = double.Parse(Console.ReadLine()),
                        amount = Convert.ToInt32(Console.ReadLine()),
                    });
                    Console.WriteLine("1. add more");
                    Console.WriteLine("2. exit");
                    string choice = Console.ReadLine();
                    if (choice == "2")
                        break;
                }
                foreach (var item in newdatabase.Order)
                {
                    newdatabase.totalprice += item.Total;
                }
                Console.WriteLine("Enter info Staff:");
                string tam = Console.ReadLine();
                newdatabase.InformationStaff.nameStaff = tam;

                Console.WriteLine("Enter info custom: ");
                Console.Write("name :");
                newdatabase.Info.name = Console.ReadLine();

                Console.Write("age :");
                newdatabase.Info.age = Convert.ToInt32(Console.ReadLine());

                Console.Write("numberphone :");
                newdatabase.Info.numberphone = Console.ReadLine();

                Console.Write("address : ");
                newdatabase.Info.address = Console.ReadLine();
            }
        }
        public static void addcommodity()
        {
            readercommodity();
            while (true)
            {
                Console.WriteLine("Enter name commodity");
                var name = Console.ReadLine();
                bool check = true;
                foreach (var item in root4.commodities)
                {
                    if (name == item.nameproduct)
                    {
                        Console.WriteLine("this commodity has exit!");
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    newcommodity.nameproduct = name;
                    Console.WriteLine($"Enter price of {newcommodity.nameproduct} : ");
                    newcommodity.price = double.Parse(Console.ReadLine());
                    newcommodity.Idproduct = root4.commodities[root4.commodities.Count - 1].Idproduct + 1;
                    break;
                }
            }
            root4.commodities.Add(newcommodity);
            writercommodity();
            Console.WriteLine("compelete add");
            Console.WriteLine("...........................");
        }
        public static void showcommodity()
        {
            readercommodity();
            foreach(var item in root4.commodities)
            {
                Console.WriteLine($"{item.Idproduct } \t {item.nameproduct }\t {item.price}");
            }
        }
        public static void writer()
        {
            using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\review\bai2\bai3\database.json"))
            {
                var data = JsonConvert.SerializeObject(root);
                sw.Write(data);
            }
        }
        public static void reader()
        {
            using (StreamReader sr = File.OpenText(@"C:\Users\Hoang\Documents\module2\review\bai2\bai3\database.json"))
            {
                var data = sr.ReadToEnd();
                root = JsonConvert.DeserializeObject<Root>(data);
            }
        }
        public static void writeracc()
        {
            using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\review\bai2\bai3\dataaccount.json"))
            {
                var data = JsonConvert.SerializeObject(root2);
                sw.Write(data);
            }
        }
        public static void readeracc()
        {
            using (StreamReader sr = File.OpenText(@"C:\Users\Hoang\Documents\module2\review\bai2\bai3\dataaccount.json"))
            {
                var data = sr.ReadToEnd();
                root2 = JsonConvert.DeserializeObject<Root2>(data);
            }
        }
        public static void writercommodity()
        {
            using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\review\bai2\bai3\commoditydata.json"))
            {
                var data = JsonConvert.SerializeObject(root4);
                sw.Write(data);
            }
        }
        public static void readercommodity()
        {
            using (StreamReader sr = File.OpenText(@"C:\Users\Hoang\Documents\module2\review\bai2\bai3\commoditydata.json"))
            {
                var data = sr.ReadToEnd();
                root4 = JsonConvert.DeserializeObject<Root4>(data);
            }
        }
    }
}
