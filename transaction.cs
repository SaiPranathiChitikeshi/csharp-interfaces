using System;
using System.Collections.Generic;
using System.Linq;

namespace transaction
{
    public interface Itransaction{
        public void showTransaction();
        public double getamnt();

    }
    public class Transaction:Itransaction{
        private string Code;
        private string date;
        private double amnt;
        public Transaction()
        {
            Code = " ";
            date = " ";
            amnt = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            Code = c;
            date = d;
            amnt = a;
        }
        public double getamnt()
        {
            return amnt;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", Code);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("amnt: {0}", getamnt());
 
    }
    }
    public class Program 
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Transaction t1 = new Transaction("001", "24/08/20120", 87900.00);
            Transaction t2 = new Transaction("002", "25/10/2020", 51900.00);
            t1.showTransaction();
            t2.showTransaction();
            //Console.ReadKey();
        }
    }
}

