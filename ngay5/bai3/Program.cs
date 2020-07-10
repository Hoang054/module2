using System;

namespace bai3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Fan fan1 = new Fan(Fan.FAST,true,10,"yellow");
            fan1.Speed= Fan.SLOW;
            fan1.toString();
            Fan fan2 = new Fan(Fan.MEDIUM,false,5,"blue");
            fan2.toString();
        }
    }
}
