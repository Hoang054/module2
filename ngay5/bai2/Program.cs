using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Watch stopwatch = new Watch();
            stopwatch.Start();
            for(int i=0; i<50;i++){
                for(int j=0 ; j<200;j++){
                    Console.Write(12);
                }
            }
            Console.WriteLine();
            stopwatch.End();
            Console.WriteLine(stopwatch.check());
        }
    }
    public class Watch
    {
        public DateTime startime ;
        public DateTime endTime ;
        public void Start(){
            startime = DateTime.Now;
        }
        public void End(){
            endTime = DateTime.Now;
        }
        public double check(){
            return (endTime - startime).TotalMilliseconds;
        }
    }
}
