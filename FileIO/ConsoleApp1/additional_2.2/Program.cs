using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace additional_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Root();
            using (StreamReader sr = File.OpenText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\additional_2.2\data.json"))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Root>(data);
            }
            bool checkk = true;
            foreach (var std in result.students)
            {
                if (std.check())
                {
                    checkk = false;
                    break;
                }
            }
            if (checkk)
            {
                var newstudent = new newstudent()
                {
                    students = new List<classification>()
                };

                foreach (var std in result.students)
                {
                    newstudent.students.Add(new classification()
                    {
                        age = std.age,
                        average = std.Average(),
                        gender = std.gender,
                        name = std.name,
                        scores = std.scores
                    });
                }
                newstudent.Sort(newstudent.students, newstudent.students.Count);
                using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\additional_2.2\output.json"))
                {
                    var data = JsonConvert.SerializeObject(newstudent);
                    sw.Write(data);
                }
            }
            else
                Console.WriteLine("score > 10 or <0, so enter again score");
        }
    }
    class Root
    {
        public List<student> students {get; set;}
    }
    public class student
    {
        public int ID { get; set; }
        public string name{ get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public List<scores> scores { get; set; }
        public double Average()
        {
            double total = 0;
            foreach(var item in scores)
            {
                if(item.name == "Toan")
                total += item.score;
                total += item.score;
            }
            return total / 4;
        }
        public bool check()
        {
            bool check = true;
            foreach(var i in scores)
            {
                if (i.score < 0 && i.score > 10)
                    check = false;
            }
            return check;
        }
    }
    public class scores
    {
        public string name { get; set; }
        public double score { get; set; }
    }
    public class newstudent
    {
        public List<classification> students { get; set; }
        public void Sort(List<classification> students,int n)
        {
            for (int i = 0; i < n - 1 ; i++)
            {
                if (students[i].average < students[i + 1].average)
                {
                    var tam = students[i];
                    students[i] = students[i + 1];
                    students[i + 1] = tam;
                }
            }
            if(n > 1)
            Sort(students, n - 1);
        }
            
    }
    public class classification : student
    {
        public double average { get; set; }
        public string rank { get => Rank(); }
        private string Rank()
        {
            if (average >= 9)
            {
                return "Xuat sac";
            }
            if (average >= 8)
            {
                return "Gioi";
            }
            if (average >= 7)
            {
                return "Kha";
            }
            if (average >= 5)
            {
                return "TB";
            }
            return "Yeu";
        }
    }
    //public class sort : newstudent, IComparer
    //{
    //    public int Compare(object q, object p)
    //    {
    //        if(q.)
    //        //if ((a.x == b.x) && (a.y == b.y))
    //        //    return 0;
    //        //if ((a.x < b.x) || ((a.x == b.x) && (a.y < b.y)))
    //        //    return -1;

    //        //return 1;
    //    }
    //}
}
