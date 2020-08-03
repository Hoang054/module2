using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    class Root
    {
        public List<Database> databases { get; set; }
    }
    class Root2
    {
        public List<staff> staffs { get; set; }

    }
    class Root3
    {
        public List<bill> bills { get; set; }
    }
    class Root4
    {
        public List<commodity> commodities { get; set; }
    }
    public class commodity
    {
        public int Idproduct { get => idproduct; set => idproduct = value; }
        private int idproduct = 10000;
        public string nameproduct { get; set; }
        public double price { get; set; }
    }

    public class bill : Database
    {
        public string datetimme { get; set; }
    }
    public class Database
    {
        public info InformationStaff { get; set; }
        public List<order> Order { get; set; }
        public double totalprice { get; set; }
        private int id = 10000;
        public infocustom Info { get; set; }
        public int ID { get => id; set => id = value; }
        public string Orderstatus { get => orderstatus; set => orderstatus = value; }

        private string orderstatus = "take order";
        
    }
    public class order : commodity
    {
        public int amount { get; set; }
        public double Total { get => tam();}

        private double total;
        public double tam()
        {
            double tam = this.price * this.amount;
            this.total = tam;
            return this.total;
        }
    }
    public class info
    {
        public string nameStaff { get; set; }
       
    }
    public class infocustom
    {
        public string name { get; set; }
        public int age { get; set; }
        public string numberphone { get; set; }
        public string address { get; set; }
    }
    class listcustom
    {
        public List<infocustom> infocus { get; set; }
    }
    
    public class staff
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }    
    }
}

