//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;

//namespace exercise3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var path = @"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\exercise3\source.txt";
//            var pathcopy = @"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\exercise3\target.txt";

//            int i = 25;
//            double d = 3.14157;
//            bool b = true;
//            string s = "I am happy";

//            try
//            {
//                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Open)))
//                {
//                    writer.Write(Convert.ToString(i,2));
//                    writer.Write(d);
//                    writer.Write(b);
//                    writer.Write(s);
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine(e.Message + "\n Cannot create file.");
//                return;
//            }
//            //bw.Close();
//            //writing into the file
//            try
//            {
//                Byte[] data = File.ReadAllBytes(path);
//                StringBuilder sb = new StringBuilder();
//                foreach (byte tam in data)
//                {
//                    sb.Append(Convert.ToString(tam, 2).PadLeft(8, '0'));
//                }
//                File.WriteAllText(pathcopy, sb.ToString());
//                //using (BinaryReader read = new BinaryReader(File.Open(path, FileMode.Open)))
//                //{
//                //    Console.WriteLine(read.Read());
//                //    Console.WriteLine(read.Read());
//                //    Console.WriteLine(read.Read());
//                //    Console.WriteLine(read.Read());
//                //}
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine(e.Message + "\n Cannot write to file.");
//                return;
//            }


//            //reading from the file
//            //try
//            //{
//            //    using (BinaryWriter writer1 = new BinaryWriter(File.Open(pathcopy, FileMode.Create)))
//            //    {
//            //        for(int j = 0; j < data.Count; j++)
//            //        {
//            //            writer1.Write(data[j]);
//            //        }
//            //    }
//            //}
//            //catch (IOException e)
//            //{
//            //    Console.WriteLine(e.Message + "\n Cannot open file.");
//            //    return;
//            //}

//            //Console.ReadKey();
//        }
//    }
//}
using System;
using System.IO;

namespace Practice_CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo source = new FileInfo(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\exercise3\source.txt");
            FileInfo des = new FileInfo(@"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\exercise3");
            try
            {
                CopyFileUsingFileInfo(source, des);
                Console.WriteLine("Copy Completed");
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot Copy");
                Console.Error.WriteLine(e.Message);
            }
        }

        private static void CopyFileUsingFileInfo(FileInfo source, FileInfo des)
        {
            try
            {
                source.CopyTo(des.FullName, true);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message +"khong tim thay file");
                return;
            }
        }

        private static void CopyFileUsingStream(FileInfo source, FileInfo des)
        {
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(source.FullName);
                writer = new StreamWriter(des.FullName);
                Char[] buffer = new Char[1024];
                int length;
                while ((length = reader.Read(buffer)) > 0)
                {
                    writer.Write(buffer, 0, length);
                }
            }
            finally
            {
                reader.Close();
                reader.Dispose();
                writer.Close();
                writer.Dispose();
            }
        }
    }
}