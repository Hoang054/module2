using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWriten = Book.WriteToFile();
            if (isWriten)
            {
                Book.ReadFromFile();
            }
            else
            {
                System.Console.WriteLine("Write data to file occur an error. Please try again !");
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    
        public static bool WriteToFile()
        {
            Book book = new Book();
            book.Title = "Đắc Nhân Tâm";
            book.Price = 123.5f;
            string inputXML = "input.xml";
            try
            {
                XDocument xDoc = XDocument.Load(@$"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\ConsoleApp2\{inputXML}");
               
                XElement newBook = new XElement( "book",
                new XElement("title", book.Title),
                new XElement("price", book.Price.ToString()));

                xDoc.Element("bookstore").Add(newBook);
                xDoc.Save("input.xml");
                return true;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                return false;
            }
        }
        public static void ReadFromFile()
        {
            XmlTextReader reader = new XmlTextReader("input.xml");
            //while (reader.Read())
            //{
            //    switch (reader.NodeType)
            //    {
            //        case XmlNodeType.Element:
            //            Console.Write("<" + reader.Name);
            //            Console.WriteLine(">");
            //            break;
            //        case XmlNodeType.Text:
            //            Console.WriteLine(reader.Value);
            //            break;
            //        case XmlNodeType.EndElement:
            //            Console.Write("</" + reader.Name);
            //            Console.WriteLine(">");
            //            break;
            //    }
            //}
            using (StreamWriter sw = File.CreateText(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\ConsoleApp2\input.xml"))
            {
                sw.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                while (reader.Read())
                {

                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            sw.Write("<" + reader.Name);
                            sw.WriteLine(">");
                            break;
                        case XmlNodeType.Text:
                            sw.WriteLine(reader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            sw.Write("</" + reader.Name);
                            sw.WriteLine(">");
                            break;
                    }
                }
            }
        }
    }
}
