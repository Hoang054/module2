using System;
using System.Collections.Generic;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> person = new List<object>();
            person.Add(new Person()
            {
                Name = "Hoang",
                age = 20, gender = true
            });
            person.Add(new Person()
            {
                Name = "khoa",
                age = 20, gender = true
            });
            try
            {

                for (int i = 0;i <= person.Count; i++)
                {
                    person.RemoveAt(i);
                }
                Console.WriteLine(person.Count);

            }
            catch (InvalidOperationException e)
            {

                System.Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("{0}, {1}", ex.GetType().Name,ex.Message);
            }
            finally
            {
                Console.WriteLine("enenenend");
            }
        }
    }
    class Person
    {
        public int age;
        public string Name;
        public bool gender;
        public Person() { }
    }
}
