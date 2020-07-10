using System;

namespace bai3
{
    public class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;
        private int speed;
        private bool on;
        private int radius;
        private string color;
        
        public int Speed
        {
            get {return speed;}
            set {speed = value;}
        }
        public int Radius
        {
            get {return radius;}
            set {radius = value;}
        }
        public bool On
        {
            get {return on;}
            set {on = value;}
        }
        public string Color
        {
            get {return color;}
            set {color = value;}
        }
        public Fan()
        {
            speed = SLOW;
            on = false;
            radius = 5;
            color = "blue";
        }
        public Fan(int toc, bool mo, int dai, string mau)
        {
            speed = toc;
            on = mo;
            radius = dai;
            color = mau;
        }


        public void toString()
        {
            if (on)
            {
                Console.WriteLine($"{speed} + {color} + {radius} +fan is on");
            }
            else
            {
                Console.WriteLine($"{speed} + {color} + {radius} +fan is off");
            }
        }
    }
}