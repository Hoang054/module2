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
//                    writer.Write(writer.d);
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

namespace BinaryFileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;
            var path = @"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\exercise3\source.txt";
            var pathcopy = @"C:\Users\Hoang\Documents\module2\FileIO\ConsoleApp1\exercise3\target.txt";

            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";

            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream(path, FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }

            //writing into the file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();

            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream(path, FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }

            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();

            //writing into the file
            try
            {
                bw = new BinaryWriter(new FileStream(path, FileMode.Create));
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();
            Console.ReadKey();
        }
    }
}
