using System;
using System.Collections.Generic;
using System.Text;

namespace additional_3
{
    class Root
    {
        public List<bill> Bill { get; set; }
    }
    public class bill
    {
        public double tongtien { get; set; }
        public List<dachon> Dachon { get; set; }
    }
    public class dachon
    {
        public string name { get; set; }
        public int soluong { get; set; }
        
        public double tamtinh { get; set; }
      
    }
}
