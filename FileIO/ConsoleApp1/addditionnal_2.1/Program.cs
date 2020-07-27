using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace addditionnal_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var filePath = @"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\addditionnal_2.1\input.json";
                var result = new Data();
                using (StreamReader sr = File.OpenText(filePath))
                {
                    var data = sr.ReadToEnd();
                    result = JsonConvert.DeserializeObject<Data>(data);

                }
                List<Object> objtam = new List<Object>();
                //List<double> tam = new List<double>();
                //foreach(var item in result.objects)
                //{
                //    var ii = item.Average();
                //    tam.Add(ii);
                //}
                var ketqua = new kqua()
                {
                    objects = new List<Objtb>()
                };
                foreach (var item in result.objects)
                {
                    ketqua.objects.Add(new Objtb()
                    {
                        avera = item.Average()
                        //a = item.a,
                        //b = item.b,
                        //c = item.c
                    }); ;
                    objtam.Add(new Object()
                    {
                        a = item.a * 2,
                        b = item.b * 2,
                        c = item.c * 2
                    });
                }
                using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\addditionnal_2.1\output1.json"))
                {
                    var data = JsonConvert.SerializeObject(ketqua);
                    sw.Write(data);
                }
                using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\addditionnal_2.1\output2.json"))
                {
                    var data = JsonConvert.SerializeObject(objtam);
                    sw.Write(data);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("number so high");
            }
            
        }
    }
    class Data
    {
        //public Object objects { get; set; }
        public List<Object> objects { get; set; }
    }
    public class Object
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public double Average()
        {
            double sum = a + b + c;
            return sum / 3;
        }
    }
    class kqua
    {
        public List<Objtb> objects { get; set; }
    }
    public class Objtb
    {
        public double avera { get; set; }
    }
}
